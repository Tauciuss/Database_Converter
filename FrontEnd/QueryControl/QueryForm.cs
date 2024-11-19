using ConverterProject.BackEnd;
using ConverterProject.BackEnd.SQL;
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

namespace ConverterProject.FrontEnd.QuerryControl
{
    public partial class QueryForm : Form
    {
        ServerRepositorySql sqlConnection = null;
        public QueryForm(ServerRepositorySql connection)
        {
            InitializeComponent();
            sqlConnection = connection;
        }

        private void QueryForm_Load(object sender, EventArgs e)
        {
            databaseComboBox.Items.Clear();
            queryTextBox.Enabled = false;
            executeButton.Enabled = false;
            saveButton.Enabled = false;
            loadButton.Enabled = false;
            exportButton.Enabled = false;
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            try
            {
                if (sqlConnection != null)
                {
                    sqlConnection.CloseConnection();
                    List<string> databaseList = sqlConnection.GetDatabaseList();
                    if (databaseList.Count > 0) // FIX
                    {
                        foreach (string table in databaseList)
                        {
                            databaseComboBox.Items.Add(table);
                        }
                        sqlConnection.CloseConnection();
                    }
                    else
                    {
                        MessageBox.Show("Connection lost. Please Login to the server again");
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void executeButton_Click(object sender, EventArgs e)
        {            
            try
            {
                sqlConnection.CloseConnection();
                SqlConnection conn = sqlConnection.GetConnection();
                if (queryTextBox.Text != "" || queryTextBox.Text != null) {
                    if (databaseComboBox.SelectedItem != null)
                    {
                        string command = @"use " + databaseComboBox.SelectedItem.ToString() + @";" + queryTextBox.Text;
                        List<string?> databaseList = new List<string?>();
                        DataTable dt = new DataTable();

                        conn.Open();
                        SqlCommand cmd = new SqlCommand(command, conn);
                        dt.Load(cmd.ExecuteReader());
                        conn.Close();
                        LoadDataGridView(dt);
                    }
                    else
                    {
                        MessageBox.Show("Please select a database.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        private void LoadDataGridView(DataTable dataTable)
        {
            mainDataGrid.DataSource = dataTable;
            sqlConnection.CloseConnection();
            exportButton.Enabled = true;
        }
        
        private void loadButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (queryTextBox.Text != "" || queryTextBox.Text != null)
                {
                    OpenFileDialog sfd = new OpenFileDialog();
                    string path = "";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        path = Path.GetFullPath(sfd.FileName);
                    }

                    string readText = File.ReadAllText(path);
                    queryTextBox.Text = readText;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (queryTextBox.Text != "" || queryTextBox.Text != null)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = $"Txt (*.txt)|*.txt";
                    string path = "";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        path = Path.GetDirectoryName(sfd.FileName);
                    }
                    //Change this one ASAP
                    File.WriteAllText(sfd.FileName, queryTextBox.Text);
                    MessageBox.Show("Load was complete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            if(mainDataGrid.DataSource != null)
            {
                try
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = $"Csv (*.csv)|*.csv";
                    string path = "";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        path = Path.GetDirectoryName(sfd.FileName);
                    }

                    DataGridView data = mainDataGrid;
                    int columnCount = data.Columns.Count;
                    string columnNames = "";
                    string[] outputCsv = new string[data.Rows.Count + 1];
                    for (int i = 0; i < columnCount; i++)
                    {
                        columnNames += data.Columns[i].HeaderText.ToString() + ",";
                    }
                    outputCsv[0] += columnNames;

                    for (int i = 1; i < data.Rows.Count; i++)
                    {
                        for (int j = 0; j < columnCount; j++)
                        {
                            outputCsv[i] += Convert.ToString(data.Rows[i - 1].Cells[j].Value) + ",";
                        }
                    }
                    string tempPath = sfd.FileName;
                    File.WriteAllLines(tempPath, outputCsv);
                    MessageBox.Show("Exported was successful.");

                } catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void databaseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            queryTextBox.Enabled = true;
            executeButton.Enabled = true;
            saveButton.Enabled = true;
            loadButton.Enabled = true;
        }
    }
}
