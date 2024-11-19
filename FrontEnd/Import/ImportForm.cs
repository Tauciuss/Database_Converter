using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using ConverterProject.BackEnd.SQL;
using System.Data.SqlClient;
using Newtonsoft.Json;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using ConverterProject.BackEnd;

namespace ConverterProject.FrontEnd.Import
{
    public partial class ImportForm : Form
    {
        public string filePath = "";
        public string fileFormat = "";
        public string tableName = "";
        public string fileName = "";
        ServerRepositorySql sr;
        ServerRepositorySQLite srl;
        string selectedDatabase = "";
        string selectedServer = "";
        string selectedCollection = "";
        string mongoConnection = "";
        public ImportForm(string selectedDatabase, string selectedTableName, ServerRepositorySql sqlServerRepository, string selectedServer)
        {
            InitializeComponent();
            tableName = selectedTableName;
            selectedLabel.Text = "Selected table: " + selectedTableName;
            sr = sqlServerRepository;
            this.selectedServer = selectedServer;
            this.selectedDatabase = selectedDatabase;
            mongoWarningLabel.Visible = false;
        }

        public ImportForm(string selectedTableName, ServerRepositorySQLite sqlServerRepository, string selectedServer)
        {
            InitializeComponent();
            tableName = selectedTableName;
            selectedLabel.Text = "Selected table: " + selectedTableName;
            srl = sqlServerRepository;
            this.selectedServer = selectedServer;
            this.selectedDatabase = selectedDatabase;
            mongoWarningLabel.Visible = false;
        }

        public ImportForm(string selectedDatabase, string selectedCollection, string mongoConnection, string selectedServer)
        {
            InitializeComponent();
            this.selectedServer= selectedServer;
            selectedLabel.Text = "Selected collection: " + selectedCollection;
            this.selectedCollection = selectedCollection;
            this.selectedDatabase = selectedDatabase;
            this.mongoConnection = mongoConnection;

            if(selectedServer == "mongodb")
            {
                newTableRadioButton.Enabled = false;
                mongoWarningLabel.Visible = true;
                selectedTableRadioButton.Checked = true;
            }
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedTableRadioButton.Checked)
                {
                    DataTable dt = new DataTable();
                    dt = null;
                    if (fileFormat == ".csv")
                        dt = GetDataTableFromCSV();
                    if (fileFormat == ".json")
                        dt = GetDataTableFromJSON();
                    if(fileFormat == ".xml")
                        dt = GetDataTableFromXML();

                    if (selectedServer == "mssql")
                        InsertDataIntoSQLServer(dt);

                    if(selectedServer == "mongodb" && fileFormat == ".json")
                    {
                        InsertDataIntoMongoServer();
                    } else if(selectedServer == "mongodb")
                    {
                        MessageBox.Show("You must select .json format file.");
                    }
                    
                    MessageBox.Show("Data added to the table: " + tableName);
                }
                else if (newTableRadioButton.Checked)
                {
                    DataTable dt = new DataTable();
                    dt = null;
                    if (fileFormat == ".csv")
                        dt = GetDataTableFromCSV();
                    if (fileFormat == ".json")
                        dt = GetDataTableFromJSON();
                    if (fileFormat == ".xml")
                        dt = GetDataTableFromXML();

                    if (selectedServer == "mssql")
                    {
                        string tableName1 = fileName;
                        CreateSQLTable(dt, tableName1);
                    }
                                        
                    MessageBox.Show("Data added to database: " + selectedDatabase);
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void CreateSQLTable(DataTable dt, string tablename)
        {
            try
            {
                string strconnection = sr.GetConnectionString();
                string table = "";

                table += $"use [{selectedDatabase}] ";
                table += "create table [" + tablename + "] ";
                table += "(";
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    if (i != dt.Columns.Count - 1)
                        table += $"{dt.Columns[i].ColumnName} varchar (max)" + ", ";
                    else
                        table += $"{dt.Columns[i].ColumnName} varchar (max)";
                }
                table += ") ";

                InsertQuery(table, strconnection);
                InsertDataIntoSQLServer(dt);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void InsertQuery(string qry, string connection)
        {
            try 
            { 
                SqlConnection conn = new SqlConnection(connection);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = qry;
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        
        public void InsertDataIntoSQLServer(DataTable fileData)
        {
            string database = selectedDatabase;
            string sql = sr.GetConnectionString() + ";Initial Catalog = " + database;
            using (SqlConnection dbConnection = new SqlConnection(sql))
            {
                dbConnection.Open();
                using (SqlBulkCopy s = new SqlBulkCopy(dbConnection))
                {
                    foreach (DataColumn c in fileData.Columns)
                        s.ColumnMappings.Add(c.ColumnName, c.ColumnName);

                    s.DestinationTableName = $"[dbo].[{fileName}]";
                    try
                    {
                        s.WriteToServer(fileData);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        public async void InsertDataIntoMongoServer() 
        {
            try
            {                
                var mongoClient = new MongoClient(mongoConnection);
                var mongoDatabase = mongoClient.GetDatabase(selectedDatabase);
                string newCollectionName = fileName;
                var mongoCollection = mongoDatabase.GetCollection<BsonDocument>(newCollectionName);

                string text = System.IO.File.ReadAllText(filePath);


                var a = BsonSerializer.Deserialize<BsonArray>(text).ToArray();

                for (int i = 0; i < a.Length; i++)
                {
                    var document = a[i].ToBsonDocument();
                    await mongoCollection.InsertOneAsync(document);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void selectFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog sfd = new OpenFileDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                { 
                    fileTextBox.Text = sfd.FileName.ToString();
                    filePath = Path.GetFullPath(sfd.FileName);
                    fileFormat = Path.GetExtension(sfd.FileName);
                    fileName = Path.GetFileNameWithoutExtension(sfd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                if(fileFormat == ".csv")
                    dt = GetDataTableFromCSV();
                if (fileFormat == ".json")
                    dt = GetDataTableFromJSON();
                if (fileFormat == ".xml")
                    dt = GetDataTableFromXML();
                    
                ViewForm vf = new ViewForm(dt);
                vf.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private DataTable GetDataTableFromXML()
        {
            DataTable dt = new DataTable();

            using(StreamReader sr = new StreamReader(filePath))
            {
                DataSet ds = new DataSet();
                ds.ReadXml(sr);
                dt = ds.Tables[0];
            }
            return dt;
        }

        private DataTable GetDataTableFromJSON()
        {
            DataTable dt = new DataTable();
            try
            {
                if(filePath != null)
                {
                    string jsonFromFile;
                    using(var reader = new StreamReader(filePath))
                    {
                        jsonFromFile = reader.ReadToEnd();
                    }

                    dt = JsonConvert.DeserializeObject<DataTable>(jsonFromFile);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return dt;
        }
        private DataTable GetDataTableFromCSV()
        {
            DataTable dt = new DataTable();
            try
            {
                if (filePath != null) {
                    using (TextFieldParser reader = new TextFieldParser(filePath))
                    {
                        reader.SetDelimiters(new string[] { "," });
                        reader.HasFieldsEnclosedInQuotes = true;
                        string[] colFields = reader.ReadFields();
                        foreach (string column in colFields)
                        {
                            DataColumn datecolumn = new DataColumn(column);
                            datecolumn.AllowDBNull = true;
                            dt.Columns.Add(datecolumn);
                        }
                        while (!reader.EndOfData)
                        {
                            string[] fieldData = reader.ReadFields();
                            for (int i = 0; i < fieldData.Length; i++)
                            {
                                if (fieldData[i] == "")
                                {
                                    fieldData[i] = null;
                                }
                            }
                            dt.Rows.Add(fieldData);
                        }
                    }
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return dt;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImportForm_Load(object sender, EventArgs e)
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
                    fileTextBox.Text = lines[0];
                }
                else
                {
                    fileTextBox.Text = "";
                }
            }
        }
    }
}
