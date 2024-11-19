using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Collections;
using ConverterProject.BackEnd;
using ConverterProject.FrontEnd.Import;

namespace ConverterProject.FrontEnd.DatabaseControl
{
    public partial class ControlSQLite : UserControl
    {
        public SQLiteConnection myConnection;
        public ServerRepositorySQLite sr;
        public string currentTableName;
        public string currentDatabase;
        string oldLogingPath = "sqliteLogin.txt";
        List<string> tableList1 = new List<string>();
        List<DataTable> dataList = new List<DataTable>();

        public ControlSQLite()
        {
            InitializeComponent();
        }

        private void ControlSQLite_Load(object sender, EventArgs e)
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
                        fileLocationTextBox.Text = lines[0];
                        if (lines[1] == "checked")
                            rememberCheckBox.Checked = true;
                        else
                            rememberCheckBox.Checked = false;
                    }
                }
            }
        }

        private void connectionButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (fileLocationTextBox.Text != null && fileLocationTextBox.Text != "")
                {
                    if (rememberCheckBox.Checked)
                        RememberLogin(fileLocationTextBox.Text);
                    else
                        ClearLogin();
                    try
                    {
                        tablesPanel.Controls.Clear();
                        mainGridView.Controls.Clear();
                        sr = new ServerRepositorySQLite(fileLocationTextBox.Text);
                        List<string> tableNames = sr.GetTableList();
                        tablesLabel.Text = "Tables: " + tableNames.Count;
                        int width = tablesPanel.Width + 2;
                        connectedToLabel.Text = "Database: " + currentDatabase;
                        tableList1.Clear();

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
                else
                {
                    MessageBox.Show("Please select database.");
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fd = new OpenFileDialog();
                string filePath = null;

                if (fd.ShowDialog() == DialogResult.OK)
                {
                    filePath = fd.FileName;
                    fileLocationTextBox.Text = filePath;
                    currentDatabase = Path.GetFileNameWithoutExtension(filePath);
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        
        private void exportButton_Click(object sender, EventArgs e)
        {
            ExportForm ex = new ExportForm(mainGridView, currentTableName, sr, "sqlite");
            ex.ShowDialog();
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm(currentTableName, sr, "sqlite");
            importForm.ShowDialog();
        }

        private List<DataTable> GetDataList()
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

        private void shareButton_Click(object sender, EventArgs e)
        {
            dataList = GetDataList();
            ShareForm sd = new ShareForm(dataList, mainGridView, currentTableName, tableList1, "SQLite");
            sd.ShowDialog();
        }
    }
}
