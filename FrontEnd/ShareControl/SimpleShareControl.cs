using ConverterProject.BackEnd;
using ConverterProject.BackEnd.SQL;
using ConverterProject.FrontEnd.SendControl.ConnectionControls;
using ConverterProject.FrontEnd.ShareControl.ConnectionControls;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Data.SQLite;

namespace ConverterProject.FrontEnd.SendControl
{
    public partial class SimpleShareControl : UserControl
    {
        DataGridView data;
        string tableName;
        string selectedFormat;
        string path;
        ShareForm sendForm;

        #region Sqlite connection
        ServerRepositorySQLite sqlite;
        SqliteConnectControl sqlitecc;
        string sqliteSelectedDatabase;

        #endregion

        #region Mongo connection
        MongoConnectControl mocc;
        string connectionString = "";
        string mongoServerString;
        #endregion

        #region MsSQL connection
        ServerRepositorySql srs;
        SqlConnectControl sqcc;

        string sqlServerName;
        string sqlServerUsername;
        string sqlServerPassword;
        #endregion

        public SimpleShareControl(DataGridView dataGrid, string tableName, ShareForm sf)
        {
            InitializeComponent();
            data = dataGrid;
            this.tableName = tableName;
            sendForm = sf;
            selectedTableTextBox.Text = tableName;
        }

        private void SimpleSendControl_Load(object sender, EventArgs e)
        {
            databaseComboBox.Enabled = false;
            selectedTableTextBox.Enabled = false;
            tableNameTextBox.Enabled = false;
            checkButton.Enabled = false;
            sendButton.Enabled = false;


            if (File.Exists("shareSettingsFile.txt"))
            {
                databaseComboBox.Enabled = true;
                selectedTableTextBox.Enabled = true;
                tableNameTextBox.Enabled = true;
                checkButton.Enabled = true;
                sendButton.Enabled = true;

                string line = "";
                using (StreamReader sr = new StreamReader("shareSettingsFile.txt"))
                {
                    line = sr.ReadLine();
                }
                string[] lines = line.Split(";");
                if(lines[0] == "MsSQL")
                {
                    serverComboBox.Text = lines[0];
                    sqlServerName = lines[1];
                    sqlServerUsername = lines[2];
                    sqlServerPassword = lines[3];
                    SqlConnectControl sc = new SqlConnectControl(lines[1], lines[2], lines[3]);
                    mainPanel.Controls.Clear();
                    mainPanel.Controls.Add(sc);                    
                    databaseComboBox.Text = lines[5];
                    tableNameTextBox.Text = lines[6];                    
                }
                if (lines[0] == "MongoDB")
                {
                    serverComboBox.Text = lines[0];
                    mongoServerString = lines[1];
                    databaseComboBox.Text = lines[3];
                    MongoConnectControl mc = new MongoConnectControl(lines[1]);
                    mainPanel.Controls.Clear();
                    mainPanel.Controls.Add(mc);
                    tableNameTextBox.Text = lines[4];                    
                }
                if (lines[0] == "SQLite")
                {
                    serverComboBox.Text = lines[0];
                    sqliteSelectedDatabase = lines[1];
                    SqliteConnectControl sc = new SqliteConnectControl(lines[1]);
                    mainPanel.Controls.Clear();
                    mainPanel.Controls.Add(sc);
                    databaseComboBox.Text = lines[3];
                    tableNameTextBox.Text= lines[4];                    
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            sendForm.Close();
            if (rememberCheckBox.Checked != true)
            {
                RemoveSettings();
            }
        }

        private void shareButton_Click(object sender, EventArgs e)
        {
            if (serverComboBox.SelectedItem.ToString() == "MsSQL")
            {
                if (tableNameTextBox.Text != null)
                {
                    ExportToJSON();
                    DataTable dt = GetDataTableFromJSON();
                    CreateSQLTable(databaseComboBox.SelectedItem.ToString(), dt, tableNameTextBox.Text);
                    MessageBox.Show("Files sent.");
                    File.Delete(tableNameTextBox.Text + @".json");
                    if (rememberCheckBox.Checked != true && File.Exists("shareSettingsFile.txt"))
                    {
                        RemoveSettings();
                    }
                }
                else
                {
                    MessageBox.Show("Error: Table name field is empty.");
                }
            }
            if (serverComboBox.SelectedItem.ToString() == "MongoDB")
            {
                if (tableNameTextBox.Text != null)
                {
                    ExportToJSON();
                    InsertDataIntoMongoServer(mongoServerString, databaseComboBox.SelectedItem.ToString(), tableNameTextBox.Text);
                    MessageBox.Show("Files sent.");
                    File.Delete(tableNameTextBox.Text + @".json");
                    if (rememberCheckBox.Checked != true && File.Exists("shareSettingsFile.txt"))
                    {
                        RemoveSettings();
                    }
                }
                else
                {
                    MessageBox.Show("Error: Table name field is empty.");
                }
            }
            if (serverComboBox.SelectedItem.ToString() == "SQLite")
            {
                if (tableNameTextBox.Text != null)
                {
                    ExportToJSON();
                    DataTable dt = GetDataTableFromJSON();
                    CreateSQLiteTable(dt, tableNameTextBox.Text);
                    MessageBox.Show("Files sent.");
                    File.Delete(tableNameTextBox.Text + @".json");
                    if (rememberCheckBox.Checked != true && File.Exists("shareSettingsFile.txt"))
                    {
                        RemoveSettings();
                    }
                }
                else
                {
                    MessageBox.Show("Error: Table name field is empty.");
                }
            }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if (serverComboBox.SelectedItem.ToString() == "MsSQL")
            {
                sqlServerName = sqcc.GetSqlServerName();
                sqlServerUsername = sqcc.GetSqlServerUsername();
                sqlServerPassword = sqcc.GetSqlServerPassword();

                MsSqlSelected();
            }
            if (serverComboBox.SelectedItem.ToString() == "MongoDB")
            {
                mongoServerString = mocc.GetMongoConnection();
                MongoDBSelected();
            }
            if (serverComboBox.SelectedItem.ToString() == "SQLite")
            {
                sqliteSelectedDatabase = sqlitecc.GetDatabasePath();
                SqliteSelected();
            }
        }

        private void MsSqlSelected()
        {
            try
            {
                if (sqlServerName != null && sqlServerUsername != null && sqlServerPassword != null)
                {
                    connectLabel.Text = "Connection: < >";
                    srs = new ServerRepositorySql(sqlServerName, sqlServerUsername, sqlServerPassword);
                    connectLabel.Text = "Connection: Good";
                    databaseComboBox.Items.Clear();
                    databaseComboBox.Enabled = true;
                    tableNameTextBox.Enabled = true;
                    foreach(string item in srs.GetDatabaseList())
                    {
                        databaseComboBox.Items.Add(item);
                    }
                    sendButton.Enabled = true;
                }
                else
                {
                    connectLabel.Text = "Connection: Bad";
                    MessageBox.Show("Error: Not all connection fields are filled.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SqliteSelected()
        {
            try
            {
                if (sqliteSelectedDatabase != null)
                {
                    connectLabel.Text = "Connection: < >";
                    sqlite = new ServerRepositorySQLite(sqliteSelectedDatabase);
                    connectLabel.Text = "Connection: Good";

                    databaseComboBox.Items.Clear();
                    databaseComboBox.Enabled = true;
                    tableNameTextBox.Enabled = true;

                    databaseComboBox.Items.Add(sqlite.GetDatabaseName());
                    
                    sendButton.Enabled = true;
                }
                else
                {
                    connectLabel.Text = "Connection: Bad";
                    MessageBox.Show("Error: Not all connection fields are filled.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void MongoDBSelected()
        {
            try
            {
                if(mongoServerString != null)
                {
                    connectLabel.Text = "Connection: < >";
                    MongoClient dbClient = new MongoClient(mongoServerString);
                    List<BsonDocument> dbList = dbClient.ListDatabases().ToList();
                    databaseComboBox.Enabled = true;
                    tableNameTextBox.Enabled = true;

                    foreach (var db in dbList)
                    {
                        string[] splitNames = db.ToString().Split('"');

                        if (splitNames[3] != "admin" && splitNames[3] != "local" && splitNames[3] != "config")
                        {
                            databaseComboBox.Items.Add(splitNames[3]);
                        }
                    }
                    connectLabel.Text = "Connection: Good";
                    sendButton.Enabled = true;
                }
                else
                {
                    connectLabel.Text = "Connection: Bad";
                    MessageBox.Show("Error: Not all connection fields are filled.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ExportToJSON()
        {
            string tempPath = tableNameTextBox.Text + @".json";
            string output = JsonConvert.SerializeObject(data.DataSource);
            System.IO.File.WriteAllText(tempPath, output);
        }

        private DataTable GetDataTableFromJSON()
        {
            string filePath = tableNameTextBox.Text + @".json";
            DataTable dt = new DataTable();
            try
            {
                if (filePath != null)
                {
                    string jsonFromFile;
                    using (var reader = new StreamReader(filePath))
                    {
                        jsonFromFile = reader.ReadToEnd();
                    }

                    dt = JsonConvert.DeserializeObject<DataTable>(jsonFromFile);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            return dt;
        }
        
        public async void InsertDataIntoMongoServer(string mongoConnection, string selectedDatabase, string selectedCollection)
        {
            string filePath = tableNameTextBox.Text + @".json";
            try
            {
                var mongoClient = new MongoClient(mongoConnection);
                var mongoDatabase = mongoClient.GetDatabase(selectedDatabase);
                var mongoCollection = mongoDatabase.GetCollection<BsonDocument>(selectedCollection);

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

        public void CreateSQLTable(string selectedDatabase, DataTable dt, string tablename)
        {
            try
            {
                string strconnection = srs.GetConnectionString();
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void CreateSQLiteTable(DataTable dt, string tablename)
        {
            try
            {
                string strconnection = sqlite.GetConnectionPath();
                string table = "";                                
                table += "create table [" + tablename + "] ";
                table += "(";
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    if (i != dt.Columns.Count - 1)
                        table += $"{dt.Columns[i].ColumnName} TEXT" + ", ";
                    else
                        table += $"{dt.Columns[i].ColumnName} TEXT";
                }
                table += ") ";

                InsertQuerySQLite(table, strconnection);
                InsertDataIntoSQLiteServer(dt, tablename);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in CreateSQLiteTable: " + ex.Message);
            }
        }

        public void InsertQuerySQLite(string qry, string connection)
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection(@$"data source = {connection};Version=3");
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = qry;
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in insert query sqlite: " + ex.Message);
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void InsertDataIntoSQLServer(DataTable fileData)
        {
            string database = databaseComboBox.SelectedItem.ToString();
            string sql = srs.GetConnectionString() + ";Initial Catalog = " + database;
            using (SqlConnection dbConnection = new SqlConnection(sql))
            {
                dbConnection.Open();
                using (SqlBulkCopy s = new SqlBulkCopy(dbConnection))
                {
                    foreach (DataColumn c in fileData.Columns)
                        s.ColumnMappings.Add(c.ColumnName.Trim(), c.ColumnName.Trim());

                    s.DestinationTableName = $"[dbo].[{tableNameTextBox.Text}]";
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

        public void InsertDataIntoSQLiteServer(DataTable fileData, string tableName)
        {
            try
            {
                SQLiteConnection con = sqlite.GetSQLiteConnection();
                con.Open();
                SQLiteCommand cmd = con.CreateCommand();
                cmd.CommandText = string.Format("SELECT * FROM {0}", tableName);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                SQLiteCommandBuilder builder = new SQLiteCommandBuilder(adapter);
                adapter.Update(fileData);
                con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error in insert data into sqlite server: " + Ex.Message);
            }
        }

        private void serverComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(serverComboBox.SelectedItem.ToString() == "MsSQL")
            {
                mainPanel.Controls.Clear();
                SqlConnectControl sc = new SqlConnectControl("","","");
                sqcc = sc;
                sc.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(sc);
            }

            if (serverComboBox.SelectedItem.ToString() == "MongoDB")
            {
                mainPanel.Controls.Clear();
                MongoConnectControl mc = new MongoConnectControl("");
                mocc = mc;
                mc.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(mc);
            }

            if (serverComboBox.SelectedItem.ToString() == "SQLite")
            {
                mainPanel.Controls.Clear();
                SqliteConnectControl sqll = new SqliteConnectControl("");
                sqlitecc = sqll;
                sqcc.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(sqll);
            }
            checkButton.Enabled = true;
        }

        private void rememberCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (rememberCheckBox.Checked)
            {
                RememberSettings();
            }
            else
            {
                RemoveSettings();
            }
        }

        private void RememberSettings()
        {
            if (tableNameTextBox.Text != null && tableNameTextBox.Text.Length > 0)
            {
                if (!File.Exists("shareSettingsFile.txt"))
                {
                    File.Create("shareSettingsFile.txt").Close();
                }
                else
                {
                    File.Delete("shareSettingsFile.txt");
                }
                string selectedServer = serverComboBox.SelectedItem.ToString();
                string connectString = "";
                if (selectedServer == "MsSQL")
                {
                    connectString = sqlServerName + ";" + sqlServerUsername + ";" + sqlServerPassword;
                }
                if (selectedServer == "MongoDB")
                {
                    connectString = mongoServerString;
                }
                if (selectedServer == "SQLite")
                {
                    connectString = sqliteSelectedDatabase;
                }
                string enableFields = "1";
                string selectedDatabase = databaseComboBox.SelectedItem.ToString();
                string tableName = tableNameTextBox.Text;
                string rememberSettings = "checked";

                string finalSetting = selectedServer + ";" + connectString + ";" + enableFields + ";" + selectedDatabase + ";" + tableName + ";" + rememberSettings;
                File.Create("shareSettingsFile.txt").Close();
                using (StreamWriter sw = new StreamWriter("shareSettingsFile.txt"))
                {
                    sw.WriteLine(finalSetting);
                }
            }
            else
            {
                MessageBox.Show("Please fill table name field.");
            }
        }

        private void RemoveSettings()
        {
            if (File.Exists("shareSettingsFile.txt"))
            {
                File.Delete("shareSettingsFile.txt");
            }
        }
    }
}
