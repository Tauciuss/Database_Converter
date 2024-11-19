using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverterProject.FrontEnd.ShareControl.ConnectionControls
{
    public partial class SqliteConnectControl : UserControl
    {
        public SqliteConnectControl(string databasePath)
        {
            InitializeComponent();
            databasePathTextBox.Text = databasePath;
        }

        public string GetDatabasePath()
        {
            if (!String.IsNullOrWhiteSpace(databasePathTextBox.Text) && !String.IsNullOrEmpty(databasePathTextBox.Text))
            {
                return databasePathTextBox.Text;
            }
            else
                return null;
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
                    databasePathTextBox.Text = filePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
