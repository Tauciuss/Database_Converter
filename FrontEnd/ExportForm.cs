using ConverterProject.FrontEnd.ExportControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConverterProject.BackEnd.SQL;
using ConverterProject.BackEnd;

namespace ConverterProject.FrontEnd
{
    public partial class ExportForm : Form
    {
        DataGridView publicData;
        string tableName;
        string usingServer;
        ServerRepositorySql srq;
        ServerRepositorySQLite srql;
        string connectionString;
        public ExportForm(DataGridView data, string dataTable, ServerRepositorySql connection, string serverInUse)
        {
            InitializeComponent();
            publicData = data;
            tableName = dataTable;
            srq = connection;
            usingServer = serverInUse;
        }

        public ExportForm(DataGridView data, string dataTable, ServerRepositorySQLite connection, string serverInUse)
        {
            InitializeComponent();
            publicData = data;
            tableName = dataTable;
            srql = connection;
            usingServer = serverInUse;
        }
        
        public ExportForm(DataGridView data, string connectionString, string dataTable, string serverInUse)
        {
            InitializeComponent();
            publicData = data;
            tableName = dataTable;
            usingServer = serverInUse;
            this.connectionString = connectionString;
        }

        private void ExportForm_Load(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            SimpleExportControl sec = new SimpleExportControl(publicData, tableName, this);
            sec.Dock = DockStyle.Fill;  
            mainPanel.Controls.Add(sec);
        }

        private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            SimpleExportControl sec = new SimpleExportControl(publicData, tableName, this);
            sec.Dock= DockStyle.Fill;
            mainPanel.Controls.Add(sec);
        }

        private void advancedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            AdvancedExportControl sec = new AdvancedExportControl(this, srq, srql, usingServer, connectionString);
            sec.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(sec);
        }
    }
}
