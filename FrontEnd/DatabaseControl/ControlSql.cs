using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ConverterProject.BackEnd.SQL;
using ConverterProject.FrontEnd.QuerryControl;
using ConverterProject.FrontEnd.Import;

namespace ConverterProject.FrontEnd
{
    public partial class ControlSql : UserControl
    {

        ServerRepositorySql sr;
        string currentDatabase;
        string currentTableName;
        bool connected = false;
        string oldLogingPath = "sqllogin.txt";

        List<string> tableList1 = new List<string>();
        List<DataTable> dataList = new List<DataTable>();
        public ControlSql()
        {
            InitializeComponent();            
        }

        private void ControlSql_Load(object sender, EventArgs e)
        {
            exportButton.Enabled = false;
            sendButton.Enabled = false;
            connectedToLabel.Visible = false;
            queryButton.Enabled = false;
            importButton.Enabled = false;

            if (File.Exists(oldLogingPath))
            {
                using (StreamReader sr = new StreamReader(oldLogingPath))
                {
                    string line = sr.ReadLine();
                    if (line != "" && line != null)
                    {                        
                        string[] lines = line.Split(";");
                        serverNameTextBox.Text = lines[0];
                        usernameTextBox.Text = lines[1];
                        passwordTextBox.Text = lines[2];
                        if (lines[3] == "checked")
                            rememberCheckBox.Checked = true;
                        else
                            rememberCheckBox.Checked = false;
                    }
                }
                
            }
        }
        
        private void connectionButton_Click(object sender, EventArgs e)
        {
            string serverName = serverNameTextBox.Text;
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            try
            {
                sr = new ServerRepositorySql(serverName, username, password);
                if (sr.GetServerStatus())
                {
                    UploadData();
                    if (rememberCheckBox.Checked)
                        RememberLogin(serverName, username, password);
                    else
                        ClearLogin();
                }
                else
                    MessageBox.Show("Something went wrong with connection. Please check the login information.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }            
        }
        
        private void ClearLogin()
        {
            if (File.Exists(oldLogingPath))
            {
                File.Delete(oldLogingPath);
            }
        }
        
        private void RememberLogin(string serverName, string username, string password)
        {
            if (File.Exists(oldLogingPath))
            {
                using(StreamWriter sr = File.CreateText(oldLogingPath))
                {
                    sr.Flush();
                    string loginInformation = $"{serverName};{username};{password};checked";
                    sr.WriteLine(loginInformation);
                    sr.Close();
                }
            }
            else
            {
                using (StreamWriter sr = new StreamWriter(oldLogingPath))
                {
                    sr.Flush();
                    string loginInformation = $"{serverName};{username};{password};checked";
                    sr.WriteLine(loginInformation);
                }
            }            
        }
        
        private void UploadData()
        {
            try
            {
                databasesPanel.Controls.Clear();
                mainGridView.Controls.Clear();
                exportButton.Enabled = false;
                sendButton.Enabled = false;

                List<string> databasesNames = sr.GetDatabaseList();

                int width = databasesPanel.Width + 2;
                databaseLabel.Text = "Databases: " + databasesNames.Count;
                foreach (string databaseName in databasesNames)
                {
                    Button databaseButton = new Button();
                    databaseButton.Text = databaseName;
                    databaseButton.Width = width - 20;
                    databaseButton.BackColor = Color.White;
                    databaseButton.Click += DatabaseNameButton_Click;
                    databasesPanel.Controls.Add(databaseButton);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DatabaseNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                queryButton.Enabled = true;
                exportButton.Enabled = false;
                sendButton.Enabled = false;
                tablesPanel.Controls.Clear();
                tableList1.Clear();

                Button button = (Button)sender;
                currentDatabase = button.Text;
                connectedToLabel.Visible = true;
                connectedToLabel.Text = "Database: " + currentDatabase;

                int width = tablesPanel.Width + 2;

                List<string> tableNames = sr.GetTableList(button.Text);
                tablesLabel.Text = "Tables: " + tableNames.Count;
                foreach (string tableName in tableNames)
                {
                    Button databaseButton = new Button();
                    databaseButton.Text = tableName;
                    tableList1.Add(tableName);
                    databaseButton.Width = width - 20;
                    databaseButton.BackColor = Color.White;
                    databaseButton.Click += TableNameButton_Click;
                    tablesPanel.Controls.Add(databaseButton);
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void TableNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                exportButton.Enabled = true;
                sendButton.Enabled = true;
                importButton.Enabled = true;
                mainGridView.Controls.Clear();

                Button button = (Button)sender;
                currentTableName = button.Text;
                connectedToLabel.Visible = true;
                connectedToLabel.Text = "Database: " + currentDatabase + " Table: " + currentTableName;

                DataTable dt = sr.GetData(button.Text);
                mainGridView.DataSource = null;
                mainGridView.DataSource = dt;
                sr.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            ExportForm ex = new ExportForm(mainGridView, currentTableName, sr, "mysql");
            ex.ShowDialog();
        }

        private List<DataTable> GetDataList()
        {
            try
            {
                List<DataTable> list = new List<DataTable>();

                foreach (string tableName in tableList1)
                {
                    DataTable dt = sr.GetData(tableName);
                    dt.TableName = tableName;
                    list.Add(dt);
                }

                return list;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

        private void queryButton_Click(object sender, EventArgs e)
        {
            QueryForm qf = new QueryForm(sr);
            qf.ShowDialog();
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm(currentDatabase, currentTableName, sr, "mssql");
            importForm.ShowDialog();
        }

        private void shareButton_Click(object sender, EventArgs e)
        {
            dataList = GetDataList();
            ShareForm sd = new ShareForm(dataList, mainGridView, currentTableName, tableList1, "MsSQL");
            sd.ShowDialog();
        }
    }
}
