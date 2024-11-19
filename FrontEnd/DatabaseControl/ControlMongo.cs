using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Configuration;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.IO;
using System.Dynamic;
using ConverterProject.FrontEnd.Import;
using System.Text.RegularExpressions;

namespace ConverterProject.FrontEnd
{
    public partial class ControlMongo : UserControl
    {
        private string currentDatabase = "";
        private string currentCollection = "";
        string oldLogingPath = "mongologin.txt";
        List<string> tableList1 = new List<string>();
        List<DataTable> dataList = new List<DataTable>();

        public ControlMongo()
        {
            InitializeComponent();
        }
        private void ControlMongo_Load(object sender, EventArgs e)
        {
            exportButton.Enabled = false;
            sendButton.Enabled = false;
            connectedToLabel.Visible = false;
            importButton.Enabled = false;

            if (File.Exists(oldLogingPath))
            {
                using (StreamReader sr = new StreamReader(oldLogingPath))
                {
                    string line = sr.ReadLine();
                    if (line != "" && line != null)
                    {
                        string[] lines = line.Split(";");
                        connectionTextBox.Text = lines[0];
                        if (lines[1] == "checked")
                            rememberCheckBox.Checked = true;
                        else
                            rememberCheckBox.Checked = false;
                    }
                }
            }
        }

        private void showDatabasesButton_Click(object sender, EventArgs e)
        {
            if (connectionTextBox.Text != "" || connectionTextBox.Text != null)
            {
                try
                {
                    databasesPanel.Controls.Clear();
                    mainGridView.Controls.Clear();

                    MongoClient dbClient = new MongoClient(connectionTextBox.Text);
                    
                    List<BsonDocument> dbList = dbClient.ListDatabases().ToList();

                    databaseLabel.Text = "Databases: " + (dbList.Count - 3);
                    PopulateDatabases(dbList);
                    if (rememberCheckBox.Checked)
                        RememberLogin(connectionTextBox.Text);
                    else
                        ClearLogin();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong. Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please write the login information.");
            }            
        }

        private void ClearLogin()
        {
            if (File.Exists(oldLogingPath))
            {
                File.Delete(oldLogingPath);
            }
        }
        
        private void RememberLogin(string connection)
        {
            if (File.Exists(oldLogingPath))
            {
                using (StreamWriter sr = File.CreateText(oldLogingPath))
                {
                    sr.Flush();
                    string loginInformation = $"{connection};checked";
                    sr.WriteLine(loginInformation);
                    sr.Close();
                }
            }
            else
            {
                using (StreamWriter sr = new StreamWriter(oldLogingPath))
                {
                    sr.Flush();
                    string loginInformation = $"{connection};checked";
                    sr.WriteLine(loginInformation);
                }
            }
        }

        private void PopulateDatabases(List<BsonDocument> dbList)
        {
            foreach (var db in dbList)
            {
                Button dbButton = new Button();
                string[] splitNames = db.ToString().Split('"');
                
                if (splitNames[3] != "admin" && splitNames[3] != "local" && splitNames[3] != "config")
                {
                    dbButton.Text = splitNames[3];
                    dbButton.Width = databasesPanel.Width - 20;
                    dbButton.BackColor = Color.White;
                    dbButton.Click += collectionsButton_Click;
                    databasesPanel.Controls.Add(dbButton);
                }
            }
        }

        private void collectionsButton_Click(object sender, EventArgs e)
        {
            try
            {
                Button button = (Button)sender;
                tablesPanel.Controls.Clear();

                var client = new MongoClient(connectionTextBox.Text);
                var db = client.GetDatabase(button.Text);
                currentDatabase = button.Text;
                connectedToLabel.Visible = true;
                connectedToLabel.Text = "Database: " + currentDatabase;

                List<BsonDocument> colList = db.ListCollectionsAsync().Result.ToListAsync<BsonDocument>().Result;
                collectionLabel.Text = "Collections: " + colList.Count;
                PopulateTables(colList);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in database button: " + ex.Message);
            }
        }

        private void PopulateTables(List<BsonDocument> colList)
        {            
            List<string> collectionList = new List<string>();
            tableList1.Clear();

            foreach (var db in colList)
            {
                Button dbButton = new Button();
                string[] splitNames = db.ToString().Split('"');
                dbButton.Text = splitNames[3];
                tableList1.Add(splitNames[3]);
                dbButton.Width = tablesPanel.Width - 20;
                dbButton.BackColor = Color.White;
                dbButton.Click += dataButton_Click;
                tablesPanel.Controls.Add(dbButton);
            }
        }
        
        private void dataButton_Click(object sender, EventArgs e)
        {
            try
            {
                Button button = (Button)sender;
                currentCollection = button.Text;
                connectedToLabel.Visible = true;
                exportButton.Enabled = true;
                importButton.Enabled = true;
                sendButton.Enabled = true;
                connectedToLabel.Text = "Database: " + currentDatabase + " Table: " + currentCollection;

                List<string> collectionList = new List<string>();

                var client = new MongoClient(connectionTextBox.Text);
                var db = client.GetDatabase(currentDatabase);


                var col = db.GetCollection<BsonDocument>(button.Text);
                List<BsonDocument> documents = col.Find(new BsonDocument()).ToList();

                if (documents != null && documents.Count != 0)
                    ShowMongoInGrid(documents);
                else
                    MessageBox.Show($"Collection {currentCollection} is empty.");
        } 
            catch (Exception ex)
            {
                MessageBox.Show("Error in collection button: " + ex.Message);
            }
}   
        
        private void ShowMongoInGrid(List<BsonDocument> documents)
        {
            if (File.Exists(@"temp.txt"))
            {
                File.Delete(@"temp.txt");
            }

            List<string> lines = new List<string>();
            foreach (var tempDoc in documents) 
            {
                File.AppendAllText(@"temp.txt", tempDoc.ToJson() + "\n");
            }

            string[] newLines = File.ReadAllLines(@"temp.txt");

            //Fixing json 
            int t = 0;
            List<string> result = new List<string>();
            foreach (string line in newLines)
            {
                string[] splittedLine = line.Split(' ');
                List<string> removablesList = new List<string>();
                removablesList.Add(splittedLine[1]);
                removablesList.Add(splittedLine[3]);

                string newLine = line;
                foreach (string removeThis in removablesList)
                {
                    newLine = newLine.Replace(removeThis, "");
                }
                newLine = newLine.Remove(1, 3);
                if (t == 0)
                {
                    newLine = "" + newLine + "";

                }
                else if (t == newLines.Length - 1)
                {
                    newLine = newLine + "";
                }
                else
                {
                    newLine = newLine + "";
                }
                t++;
                result.Add(newLine);
            }

            AddingData(result);
            
            if (File.Exists(@"temp.txt"))
            {
                File.Delete(@"temp.txt");
            }            
        }
        
        private void AddingData(List<string> stringList)
        {
            List<string> headersList = new List<string>();
            List<string> lineWithout = new List<string>();

            foreach (string line in stringList)
            {
                string T = "";
                T = line.Replace(@"""", string.Empty);
                lineWithout.Add(T);
            }

            string Result = "";
            int index = 0;

            index = FindBiggestHeaderCount(lineWithout);
            string[] headerAndValue = Regex.Split(lineWithout[index], @",\W+");
            //Get headers
            foreach (string line in headerAndValue)
            {                
                Result = line.Replace("}", string.Empty).Replace("{", string.Empty).Replace(@"""", string.Empty);
                string[] splitted = Regex.Split(Result, " :");
                headersList.Add(splitted[0]);
                
            }

            string[,] valuesMatrix = new string[stringList.Count, headerAndValue.Length];

            int lineIndex = 0;
            //Get values            
            foreach (string line in lineWithout)
            {
                int valuesIndex = 0;
                string[] headerAndValue1 = line.Split(",");
                List<string> tempValuesList = new List<string>();
                foreach (string line1 in headerAndValue1)
                {
                    Result = line1.Replace("}", string.Empty).Replace("{", string.Empty).Replace(@"""", string.Empty);
                    string[] splitted = Regex.Split(Result, " :");
                    if (splitted.Length != 1)
                        valuesMatrix[lineIndex, valuesIndex] = splitted[1];
                    else
                        continue;
                    valuesIndex++;
                }
                lineIndex++;
            }

            DataTable tempDt = new DataTable();
            tempDt.Clear();

            //Display headers
            for (int i = 0; i < headersList.Count; i++) 
            {
                tempDt.Columns.Add(headersList[i].Trim());
            }
            //Display values
            for (int r = 0; r < stringList.Count; r++)
            {
                List<string> tempValues = new List<string>();
                for (int c = 0; c < headersList.Count; c++)
                {
                    if (valuesMatrix[r, c] != null)
                    {                        
                        tempValues.Add(valuesMatrix[r, c].Trim());
                    }
                }
                tempDt.Rows.Add(tempValues.ToArray());
            }

            UpdateGridView(tempDt);
        }

        private void UpdateGridView(DataTable dt)
        {
            mainGridView.DataSource = null;
            mainGridView.DataSource = dt;
        }

        private int FindBiggestHeaderCount (List<string> lineWithout)
        {
            int[,] array = new int[lineWithout.Count, 2];

            foreach (string line in lineWithout)
            {
                string[] headerAndValue = Regex.Split(line, @",\W+");
                //string[] headerAndValue = Regex.Split(line, @",");

                int howMuch = 0;

                howMuch = headerAndValue.Count();

                for (int i = 0; i < lineWithout.Count; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        array[i, j] = howMuch;
                    }
                }
            }

            int max = array.Cast<int>().Max();
            var index = 0;

            for (int i = 0; i < lineWithout.Count; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (array[i, j] == max)
                    {
                        index = i;
                    }
                }
            }
            return index;
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            ExportForm ex = new ExportForm(mainGridView, connectionTextBox.Text, currentCollection, "mongo");
            ex.ShowDialog();
        }

        private List<DataTable> GetDataList()
        {
            List<DataTable> list = new List<DataTable>();
            try
            {
                int dtCount = 0;
                foreach (string tableName in tableList1)
                {
                    dtCount++;
                    DataTable dt = GetDataFromMongoDB1(currentDatabase, tableName);
                    if(dt != null)
                    {
                        dt.TableName = tableName;
                        list.Add(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in GetDataList: " + ex.Message);
            }

            return list;
        }

        private DataTable GetDataFromMongoDB1(string databaseName, string tableName)
        {
            DataTable dt = new DataTable();

            var client = new MongoClient(connectionTextBox.Text);
            var db = client.GetDatabase(databaseName);


            var col = db.GetCollection<BsonDocument>(tableName);
            List<BsonDocument> documents = col.Find(new BsonDocument()).ToList();
            dt = GetBsonDocumentToDataTable1(documents);
            return dt;
        }

        private DataTable GetBsonDocumentToDataTable1(List<BsonDocument> documents)
        {
            if (documents.Count != 0 )
            {
                DataTable dt = new DataTable();
                if (File.Exists(@"temp.txt"))
                {
                    File.Delete(@"temp.txt");
                }
                
                List<string> lines = new List<string>();
                foreach (var tempDoc in documents)
                {
                    File.AppendAllText(@"temp.txt", tempDoc.ToJson() + "\n");
                }

                string[] newLines = File.ReadAllLines(@"temp.txt");

                //Fixing json 
                int t = 0;
                List<string> result = new List<string>();
                foreach (string line in newLines)
                {
                    string[] splittedLine = line.Split(' ');
                    List<string> removablesList = new List<string>();
                    removablesList.Add(splittedLine[1]);
                    removablesList.Add(splittedLine[3]);

                    string newLine = line;
                    foreach (string removeThis in removablesList)
                    {
                        newLine = newLine.Replace(removeThis, "");
                    }
                    newLine = newLine.Remove(1, 3);
                    if (t == 0)
                    {
                        newLine = "" + newLine + "";

                    }
                    else if (t == newLines.Length - 1)
                    {
                        newLine = newLine + "";
                    }
                    else
                    {
                        newLine = newLine + "";
                    }
                    t++;
                    result.Add(newLine);
                }

                dt = AddingData1(result);

                if (File.Exists(@"temp.txt"))
                {
                    File.Delete(@"temp.txt");
                }
                return dt;
            }
            else
            {
                return null;
            }
        }

        private DataTable AddingData1(List<string> stringList)
        {
            List<string> headersList = new List<string>();
            List<string> lineWithout = new List<string>();

            foreach (string line in stringList)
            {
                string T = "";
                T = line.Replace(@"""", string.Empty);
                lineWithout.Add(T);
            }

            string Result = "";
            int index = 0;

            index = FindBiggestHeaderCount(lineWithout);
            string[] headerAndValue = Regex.Split(lineWithout[index], @",\W+");
            //Get headers
            foreach (string line in headerAndValue)
            {
                Result = line.Replace("}", string.Empty).Replace("{", string.Empty).Replace(@"""", string.Empty);
                string[] splitted = Regex.Split(Result, " :");
                headersList.Add(splitted[0]);

            }

            string[,] valuesMatrix = new string[stringList.Count, headersList.Count];

            int lineIndex = 0;
            //Get values            
            foreach (string line in lineWithout)
            {
                int valuesIndex = 0;
                string[] headerAndValue1 = line.Split(",");
                List<string> tempValuesList = new List<string>();
                foreach (string line1 in headerAndValue1)
                {
                    Result = line1.Replace("}", string.Empty).Replace("{", string.Empty).Replace(@"""", string.Empty);
                    string[] splitted = Regex.Split(Result, " :");
                    if (splitted.Length != 1)
                        valuesMatrix[lineIndex, valuesIndex] = splitted[1];
                    else
                        continue;
                    valuesIndex++;
                }
                lineIndex++;
            }

            DataTable tempDt = new DataTable();
            tempDt.Clear();

            for (int i = 0; i < headersList.Count; i++)
            {
                tempDt.Columns.Add(headersList[i].Trim());
            }
            for (int r = 0; r < stringList.Count; r++)
            {
                List<string> tempValues = new List<string>();
                for (int c = 0; c < headersList.Count; c++)
                {
                    if (valuesMatrix[r, c] != null)
                    {
                        tempValues.Add(valuesMatrix[r, c].Trim());
                    }
                }
                tempDt.Rows.Add(tempValues.ToArray());
            }

            return tempDt;
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            ImportForm impf = new ImportForm(currentDatabase, currentCollection, connectionTextBox.Text, "mongodb");
            impf.ShowDialog();
        }

        private void shareButton_Click(object sender, EventArgs e)
        {
            dataList = GetDataList();
            ShareForm sd = new ShareForm(dataList, mainGridView, currentCollection, tableList1, "MongoDB");
            sd.ShowDialog();
        }
    }
}
