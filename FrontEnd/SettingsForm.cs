using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverterProject.FrontEnd
{
    public partial class SettingsForm : Form
    {
        string settingsString = "";

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {                
                string filePath = "settings.txt";
                string[] lines = settingsString.Split(";"); //1 - Import, 2 - Export
                
                //Export
                if (!String.IsNullOrEmpty(exportLocationTextBox.Text))
                {
                    lines[1] = exportLocationTextBox.Text;                    
                }

                //Import
                if (!String.IsNullOrEmpty(importLocationTextBox.Text))
                {
                    lines[0] = importLocationTextBox.Text;
                }

                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.Write(lines[0]+";"+lines[1]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void defaultExportButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                exportLocationTextBox.Text = ofd.SelectedPath;
            }
        }

        private void defaultImportButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                importLocationTextBox.Text = ofd.SelectedPath;
            }
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            try
            {
                string filePath = "settings.txt";
                if (!File.Exists(filePath))
                {
                    File.Create(filePath).Close();
                }
                else
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        settingsString = sr.ReadToEnd();
                    }
                    string[] lines = settingsString.Split(";"); //1 - Import, 2 - Export

                    if (lines[0] != null && lines[0] != "" && lines[1] != null && lines[1] != "")
                    {
                        importLocationTextBox.Text = lines[0];
                        exportLocationTextBox.Text = lines[1];
                    }
                    else if ((lines[0] == null || lines[0] == "") && (lines[1] != null && lines[1] != ""))
                    {
                        importLocationTextBox.Text = "";
                    } 
                    else if ((lines[0] != null && lines[0] != "") && (lines[1] != null || lines[1] != ""))
                    {
                        exportLocationTextBox.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
