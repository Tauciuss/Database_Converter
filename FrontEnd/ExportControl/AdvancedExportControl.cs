using ConverterProject.BackEnd;
using ConverterProject.BackEnd.SQL;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverterProject.FrontEnd.ExportControl
{
    public partial class AdvancedExportControl : UserControl
    {
        List<string> dbNames;
        List<string> tbNames;
        ExportForm exportForm;
        ServerRepositorySql srq;
        ServerRepositorySQLite srql;
        string repository = ""; //mssql, mongo, sqlite
        
        string path;
        string connectionString;

        //For MsSQL
        public AdvancedExportControl(ExportForm ef, ServerRepositorySql serverSql, ServerRepositorySQLite srql, string usedRepository, string connectionString)
        {
            InitializeComponent();
            
            exportForm = ef;
            srq = serverSql;
            this.srql = srql;
            repository = usedRepository;
            this.connectionString = connectionString;
            
        }
       
        private void AdvancedExportControl_Load(object sender, EventArgs e)
        {
            try
            {
                string filePath = "settings.txt";
                if (File.Exists(filePath))
                {
                    string settingsString = "";
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        settingsString = sr.ReadToEnd();
                    }
                    string[] lines = settingsString.Split(";"); //1 - Import, 2 - Export

                    if (lines[0] != null && lines[0] != "" && lines[1] != null && lines[1] != "")
                    {
                        locationTextBox.Text = lines[1];
                    }
                    else
                    {
                        locationTextBox.Text = "";
                    }
                }            

                if (repository == "mysql")
                {
                    dbNames = srq.GetDatabaseList();

                    databaseTreeView.Nodes.Clear();
                    databaseTreeView.BeginUpdate();
                    databaseTreeView.CheckBoxes = true;

                    int i = 0;
                    foreach (string dbName in dbNames)
                    {
                        databaseTreeView.Nodes.Add(dbName);
                        tbNames = srq.GetTableList(dbName);
                        foreach (string tbName in tbNames)
                        {
                            databaseTreeView.Nodes[i].Nodes.Add(tbName);
                        }
                        i++;
                    }
                    databaseTreeView.EndUpdate();
                }   
            
                if(repository == "mongo")
                {
                    databaseTreeView.Nodes.Clear();
                    databaseTreeView.BeginUpdate();
                    databaseTreeView.CheckBoxes = true;

                    MongoClient dbClient = new MongoClient(connectionString);
                    List<BsonDocument> dbList = dbClient.ListDatabases().ToList();

                    int i = 0;
                    foreach (var db in dbList)
                    {
                        string[] splitNames = db.ToString().Split('"');

                        if (splitNames[3] != "admin" && splitNames[3] != "local" && splitNames[3] != "config")
                        {
                            var db1 = dbClient.GetDatabase(splitNames[3]);
                            databaseTreeView.Nodes.Add(splitNames[3]);
                            List<BsonDocument> colList = db1.ListCollectionsAsync().Result.ToListAsync<BsonDocument>().Result;

                            foreach (var colName in colList)
                            {
                                string[] splitNames1 = colName.ToString().Split('"');
                                databaseTreeView.Nodes[i].Nodes.Add(splitNames1[3]);
                            }
                            i++;
                        }
                    }                
                    databaseTreeView.EndUpdate();
                }

                if(repository == "sqlite")
                {                

                    databaseTreeView.Nodes.Clear();
                    databaseTreeView.BeginUpdate();
                    databaseTreeView.CheckBoxes = true;
                    
                    tbNames = srql.GetTableList();
                    foreach (string tbName in tbNames)
                    {
                        databaseTreeView.Nodes.Add(tbName);
                    }
                    
                    databaseTreeView.EndUpdate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            try
            {
                var list = new List<TreeNode>();
                LookupChecks(databaseTreeView.Nodes, list);
                List<string> testQuikc = new List<string>();

                //Gets back all the parent nodes
                IList<TreeNode> nodesWithChildren = new List<TreeNode>();
                foreach (TreeNode node in databaseTreeView.Nodes)
                    if (node.Nodes.Count > 0) nodesWithChildren.Add(node);

                int s = 0;
                foreach (var item in list)
                {
                    foreach (var parentNode in nodesWithChildren)
                    {
                        if (item.Text == parentNode.Text)
                        {
                            s++;
                        }
                    }

                    if (s == 0)
                    {
                        if (repository == "mysql")
                        {
                            UsingMySqlRepository(item);
                        }
                        if (repository == "mongo")
                        {
                            UsingMongoDB(item);
                        }
                        if(repository == "sqlite")
                        {
                            UsingSqlite(item);
                        }
                    }
                    s = 0;
                }

                MessageBox.Show("Files have been exported!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in databaseTreeView.Nodes)
            {
                node.Checked = false;
                CheckChildren(node, false);
            }
        }

        private void CheckChildren(TreeNode rootNode, bool isChecked)
        {
            foreach (TreeNode node in rootNode.Nodes)
            {
                CheckChildren(node, isChecked);
                node.Checked = isChecked;
            }
        }

        private void allButton_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in databaseTreeView.Nodes)
            {
                node.Checked = true;
                CheckChildren(node, true);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            exportForm.Close();
        }

        private void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
        {
            foreach (TreeNode node in treeNode.Nodes)
            {
                node.Checked = nodeChecked;
                if (node.Nodes.Count > 0)
                {
                    this.CheckAllChildNodes(node, nodeChecked);
                }
            }
        }
        
        private void databaseTreeView_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown)
            {
                if (e.Node.Nodes.Count > 0)
                {
                    this.CheckAllChildNodes(e.Node, e.Node.Checked);
                }
            }
        }

        private void UsingMySqlRepository(TreeNode node)
        {
            if (formatComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select format.");
            }
            else if (formatComboBox.SelectedItem.ToString() == "CSV")
            {
                try
                {
                    DataTable dt = srq.GetData(node.Parent.Text, node.Text);
                    ExportToCSV(dt, node, node.Parent.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (formatComboBox.SelectedItem.ToString() == "JSON")
            {
                try
                {
                    DataTable dt = srq.GetData(node.Parent.Text, node.Text);
                    ExportToJSON(dt, node, node.Parent.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            else if (formatComboBox.SelectedItem.ToString() == "XML")
            {
                try
                {
                    DataTable dt = srq.GetData(node.Parent.Text, node.Text);
                    ExportToXML(dt, node, node.Parent.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void UsingMongoDB(TreeNode node)
        {
            if (formatComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select format.");
            }
            else if (formatComboBox.SelectedItem.ToString() == "CSV")
            {
                try
                {
                    DataTable dt = GetDataFromMongoDB(node.Parent.Text, node.Text);
                    ExportToCSV(dt, node, node.Parent.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (formatComboBox.SelectedItem.ToString() == "JSON")
            {
                try
                {
                    DataTable dt = GetDataFromMongoDB(node.Parent.Text, node.Text);
                    ExportToJSON(dt, node, node.Parent.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            else if (formatComboBox.SelectedItem.ToString() == "XML")
            {
                try
                {
                    DataTable dt = GetDataFromMongoDB(node.Parent.Text, node.Text);
                    ExportToXML(dt, node, node.Parent.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        
        private void UsingSqlite(TreeNode node)
        {
            if (formatComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select format.");
            }
            else if (formatComboBox.SelectedItem.ToString() == "CSV")
            {
                try
                {
                    DataTable dt = srql.GetData(node.Text);
                    ExportToCSV(dt, node, node.Parent.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (formatComboBox.SelectedItem.ToString() == "JSON")
            {
                try
                {
                    DataTable dt = srql.GetData(node.Text);
                    ExportToJSON(dt, node, node.Parent.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            else if (formatComboBox.SelectedItem.ToString() == "XML")
            {
                try
                {
                    DataTable dt = srql.GetData(node.Text);
                    ExportToXML(dt, node, node.Parent.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        
        private DataTable  GetDataFromMongoDB(string databaseName, string tableName)
        {
            DataTable dt = new DataTable();
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(databaseName);
            var col = db.GetCollection<BsonDocument>(tableName);
            List<BsonDocument> documents = col.Find(new BsonDocument()).ToList();
            dt = GetBsonDocumentToDataTable(documents);
            return dt;
        }

        private DataTable GetBsonDocumentToDataTable(List<BsonDocument> documents)
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

            dt = AddingData(result);

            if (File.Exists(@"temp.txt"))
            {
                File.Delete(@"temp.txt");
            }
            return dt;
        }
        
        private DataTable AddingData(List<string> stringList)
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
                    //row.Cells[c].Value = valuesMatrix[r, c];
                    tempValues.Add(valuesMatrix[r, c].Trim());
                }
                tempDt.Rows.Add(tempValues.ToArray());
            }

            return tempDt;
        }

        private int FindBiggestHeaderCount(List<string> lineWithout)
        {
            int[,] array = new int[lineWithout.Count, 2];

            foreach (string line in lineWithout)
            {
                string[] headerAndValue = Regex.Split(line, @",\W+");

                var kiek = 0;

                kiek = headerAndValue.Count();

                for (int i = 0; i < lineWithout.Count; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        array[i, j] = kiek;
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
                
        private void ExportToCSV(DataTable dt, TreeNode node, string folderName)
        {
            int columnCount = dt.Columns.Count;
            string columnNames = "";
            string[] outputCsv = new string[dt.Rows.Count + 1];
            for (int i = 0; i < columnCount; i++)
            {
                columnNames += dt.Columns[i].ColumnName.ToString() + ",";
            }
            outputCsv[0] += columnNames;

            
            for (int i = 1; i < dt.Rows.Count + 1; i++)
            {
                
                for (int j = 0; j < columnCount; j++)
                {
                    outputCsv[i] += Convert.ToString(dt.Rows[i - 1][j]) + ",";
                }
            }

            if (foldersCheckBox.Checked)
            {
                Directory.CreateDirectory(locationTextBox.Text + @"\" + folderName);

                string tempPath = locationTextBox.Text + @$"\{folderName}\" + node.Text + @".csv";
                File.WriteAllLines(tempPath, outputCsv);
            }
            else
            {
                string tempPath = locationTextBox.Text+ @"\" + node.Text + @".csv";
                File.WriteAllLines(tempPath, outputCsv);
            }
        }

        private void ExportToJSON(DataTable dt, TreeNode node, string folderName)
        {

            string output = JsonConvert.SerializeObject(dt);
            if (foldersCheckBox.Checked)
            {
                Directory.CreateDirectory(locationTextBox.Text + @"\" + folderName);
                string tempPath = locationTextBox.Text + @$"\{folderName}\" + node.Text + @".json";

                System.IO.File.WriteAllText(tempPath, output);
            }
            else
            {
                string tempPath = locationTextBox.Text + @"\" + node.Text + @".json";

                System.IO.File.WriteAllText(tempPath, output);
            }
        }

        private void ExportToXML(DataTable dt, TreeNode node, string folderName)
        {
            
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);

            if (foldersCheckBox.Checked)
            {
                Directory.CreateDirectory(locationTextBox.Text + @"\" + folderName);
                string tempPath = locationTextBox.Text + @$"\{folderName}\" + node.Text + @".xml";

                ds.WriteXml(tempPath);
            }
            else
            {
                string tempPath = locationTextBox.Text + @$"\{folderName}\" + node.Text + @".xml";

                ds.WriteXml(tempPath);
            }
        }
                
        void LookupChecks(TreeNodeCollection nodes, List<TreeNode> list)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Checked)
                    list.Add(node);

                LookupChecks(node.Nodes, list);
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (formatComboBox.SelectedItem != null)
                {
                    FolderBrowserDialog sfd = new FolderBrowserDialog();
                    bool fileError = false;

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        path = Path.GetFullPath(sfd.SelectedPath);
                        locationTextBox.Text = path;
                    }
                }
                else
                {
                    MessageBox.Show("Please select format.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Advanced export <change>: " + ex.Message);
            }
        }
    }
}
