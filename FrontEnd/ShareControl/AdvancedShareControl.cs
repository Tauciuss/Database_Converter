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
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverterProject.FrontEnd.SendControl
{
    public partial class AdvancedShareControl : UserControl
    {
        ShareForm sf;
        List<string> tableNames;
        string selectedServer = null;
        List<DataTable> dataList = new List<DataTable>();

        #region Sqlite connection
        ServerRepositorySQLite srsq;
        SqliteConnectControl sqlitecc;
        string sqliteConnectionString = "";

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

        public AdvancedShareControl(ShareForm sf, List<string> tableNames, string selectedServer, List<DataTable> dataList)
        {
            InitializeComponent();
            this.sf = sf;
            databasesTreeView.CheckBoxes = true;
            this.tableNames = tableNames;
            this.selectedServer = selectedServer;
            this.dataList = dataList;
        }
        
        private void AdvancedShareControl_Load(object sender, EventArgs e)
        {
            checkButton.Enabled = false;
            shareButton.Enabled = false;
        }

        private void shareButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> selectedTables = GetCheckedNodes(tablesTreeView);
                List<string> selectedDatabases = GetCheckedNodes(databasesTreeView);                

                //Insert
                foreach(DataTable table in dataList)
                {
                    foreach (string selected in selectedTables)
                    {
                        if(selected == table.TableName)
                        {
                            foreach(string selectedDT in selectedDatabases)
                            {
                                if (serverComboBox.SelectedItem.ToString() == "MsSQL")
                                {
                                    CreateSQLTable(selectedDT, table, selected);
                                }
                                if (serverComboBox.SelectedItem.ToString() == "MongoDB")
                                {
                                    InsertDataIntoMongoServer(mongoServerString, selectedDT, selected, selected, table);
                                }
                                if (serverComboBox.SelectedItem.ToString() == "SQLite")
                                {
                                    CreateSQLiteTable(table, selected);
                                }
                            }
                        }
                            
                    }
                }
                //Complete
                MessageBox.Show("Tables have been shared.");
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            //Selected database tables
            tablesTreeView.Nodes.Clear();
            tablesTreeView.CheckBoxes = true;
            
            foreach(string tableName in tableNames)
            {
                tablesTreeView.Nodes.Add(tableName);
            }

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

            if(serverComboBox.SelectedItem.ToString() == "SQLite")
            {
                sqliteConnectionString = sqlitecc.GetDatabasePath();
                SqliteSelected();
            }
        }

        private void MongoDBSelected()
        {
            try
            {
                if (mongoServerString != null)
                {
                    databasesTreeView.Controls.Clear();
                    databasesTreeView.Nodes.Clear();
                    connectLabel.Text = "Connection: < >";
                    MongoClient dbClient = new MongoClient(mongoServerString);
                    List<BsonDocument> dbList = dbClient.ListDatabases().ToList();                   

                    foreach (var db in dbList)
                    {
                        string[] splitNames = db.ToString().Split('"');

                        if (splitNames[3] != "admin" && splitNames[3] != "local" && splitNames[3] != "config")
                        {
                            databasesTreeView.Nodes.Add(splitNames[3]);
                        }
                    }
                    connectLabel.Text = "Connection: Good";
                    shareButton.Enabled = true;
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

        private void MsSqlSelected()
        {
            try
            {
                if (sqlServerName != null && sqlServerUsername != null && sqlServerPassword != null)
                {
                    databasesTreeView.Controls.Clear();
                    databasesTreeView.Nodes.Clear();
                    connectLabel.Text = "Connection: < >";
                    srs = new ServerRepositorySql(sqlServerName, sqlServerUsername, sqlServerPassword);
                    connectLabel.Text = "Connection: Good";

                    List<string> dbNames = srs.GetDatabaseList();
                    List<string> tbNames = new List<string>();

                    databasesTreeView.Nodes.Clear();
                    databasesTreeView.BeginUpdate();
                    databasesTreeView.CheckBoxes = true;

                    //Populates tree view with dabtase names
                    foreach (string dbName in dbNames)
                    {
                        databasesTreeView.Nodes.Add(dbName);                        
                    }
                    databasesTreeView.EndUpdate();
                    shareButton.Enabled = true;
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
                if(sqliteConnectionString != null)
                {
                    databasesTreeView.Controls.Clear();
                    databasesTreeView.Nodes.Clear();
                    connectLabel.Text = "Connection: < >";
                    srsq = new ServerRepositorySQLite(sqliteConnectionString);
                    connectLabel.Text = "Connection: Good";
                    
                    databasesTreeView.Nodes.Add(srsq.GetDatabaseName());
                    
                    databasesTreeView.EndUpdate();
                    shareButton.Enabled = true;
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

        private void serverComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serverComboBox.SelectedItem.ToString() == "MsSQL")
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
                sqll.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(sqll);
            }
            checkButton.Enabled = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            sf.Close();
        }

        private void tablesTreeViewAll_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in tablesTreeView.Nodes)
            {
                node.Checked = true;
                CheckChildren(node, true);
            }
        }

        private void tablesTreeViewClear_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in tablesTreeView.Nodes)
            {
                node.Checked = false;
                CheckChildren(node, false);
            }
        }

        private void databaseTreeViewAll_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in databasesTreeView.Nodes)
            {
                node.Checked = true;
                CheckChildren(node, true);
            }
        }

        private void databaseTreeViewClear_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in databasesTreeView.Nodes)
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

        private List<string> GetCheckedNodes(TreeView rootNode)
        {
            List<string> result = new List<string>();

            foreach(TreeNode node in rootNode.Nodes)
            {
                if(node.Checked)
                    result.Add(node.Text);
            }

            return result;
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
                InsertDataIntoSQLServer(dt, selectedDatabase, tablename);
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
                string strconnection = srsq.GetConnectionPath();
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

        public void InsertDataIntoSQLServer(DataTable fileData, string database, string tableName)
        {            
            string sql = srs.GetConnectionString() + ";Initial Catalog = " + database;
            using (SqlConnection dbConnection = new SqlConnection(sql))
            {
                dbConnection.Open();
                using (SqlBulkCopy s = new SqlBulkCopy(dbConnection))
                {
                    foreach (DataColumn c in fileData.Columns)
                        s.ColumnMappings.Add(c.ColumnName.Trim(), c.ColumnName.Trim());

                    s.DestinationTableName = $"[dbo].[{tableName}]";
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
                SQLiteConnection con = srsq.GetSQLiteConnection();
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

        public async void InsertDataIntoMongoServer(string mongoConnection, string selectedDatabase, string selectedCollection, string tableName, DataTable dt)
        {
            
            //Export to Json
            string tempPath = tableName + @".json";
            string output = JsonConvert.SerializeObject(dt);
            System.IO.File.WriteAllText(tempPath, output);

            try
            {
                var mongoClient = new MongoClient(mongoConnection);
                var mongoDatabase = mongoClient.GetDatabase(selectedDatabase);
                var mongoCollection = mongoDatabase.GetCollection<BsonDocument>(selectedCollection);

                string text = System.IO.File.ReadAllText(tempPath);


                var a = BsonSerializer.Deserialize<BsonArray>(text).ToArray();

                for (int i = 0; i < a.Length; i++)
                {
                    var document = a[i].ToBsonDocument();
                    await mongoCollection.InsertOneAsync(document);
                }

                System.IO.File.Delete(tempPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
