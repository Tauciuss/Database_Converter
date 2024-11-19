using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverterProject.FrontEnd.ExportControl
{
    public partial class SimpleExportControl : UserControl
    {
        DataGridView data;
        string tableName;
        string path;
        ExportForm exportForm;
        public SimpleExportControl(DataGridView dataGrid, string tableName, ExportForm ef)
        {
            InitializeComponent();
            data = dataGrid;
            this.tableName = tableName;
            exportForm = ef;

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
        }

        private void SimpleExportControl_Load(object sender, EventArgs e)
        {
            fileNameTextBox.Text = tableName;
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (formatComboBox.SelectedItem != null)
                {
                    FolderBrowserDialog fbd = new FolderBrowserDialog();
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        path = fbd.SelectedPath;
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
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            if (formatComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select format.");
            }
            else if (formatComboBox.SelectedItem.ToString() == "CSV")
            {
                if (fileNameTextBox.Text == "" || String.IsNullOrWhiteSpace(fileNameTextBox.Text))
                {
                    MessageBox.Show("Please give the file a name.");
                }
                else
                {
                    try
                    {
                        ExportToCSV();
                        MessageBox.Show("Data Exported Successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else if (formatComboBox.SelectedItem.ToString() == "JSON")
            {
                if (fileNameTextBox.Text == "" || String.IsNullOrWhiteSpace(fileNameTextBox.Text))
                {
                    MessageBox.Show("Please give the file a name.");
                }
                else
                {
                    try
                    {
                        ExportToJSON();
                        MessageBox.Show("Data Exported Successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            else if (formatComboBox.SelectedItem.ToString() == "XML")
            {
                if (fileNameTextBox.Text == "" || String.IsNullOrWhiteSpace(fileNameTextBox.Text))
                {
                    MessageBox.Show("Please give the file a name.");
                }
                else
                {
                    try
                    {
                        ExportToXML();
                        MessageBox.Show("Data Exported Successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error in Simple Export: " + ex.Message);
                    }
                }
            }
        }

        private void ExportToCSV()
        {
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
            string tempPath = locationTextBox.Text + @"\" + fileNameTextBox.Text + @".csv";
            File.WriteAllLines(tempPath, outputCsv);
        }

        private void ExportToJSON()
        {
            string tempPath = locationTextBox.Text + @"\" + fileNameTextBox.Text + @".json";
            string output = JsonConvert.SerializeObject(data.DataSource);
            System.IO.File.WriteAllText(tempPath, output);
        }

        private void ExportToXML()
        {
            string tempPath = locationTextBox.Text + @"\" + fileNameTextBox.Text + @".xml";
            DataTable dt = (DataTable)data.DataSource;
            dt.TableName = tableName;
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            ds.WriteXml(tempPath);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            exportForm.Close();
        }
    }
}
