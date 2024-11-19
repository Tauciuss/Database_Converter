using ConverterProject.BackEnd;
using ConverterProject.BackEnd.SQL;
using ConverterProject.FrontEnd.SendControl;
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
    public partial class ShareForm : Form
    {
        DataGridView publicData;
        string tableName;
        List<string> tables;
        string selectedServer = null;
        List<DataTable> dataList = new List<DataTable>();
        public ShareForm(List<DataTable> dataList, DataGridView data, string dataTable, List<string> tableList, string selectedServer)
        {
            InitializeComponent();
            publicData = data;
            tableName = dataTable;
            this.tables = tableList;
            this.selectedServer = selectedServer;
            this.dataList = dataList;
        }
        private void SendForm_Load(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            SimpleShareControl ssc = new SimpleShareControl(publicData, tableName, this);
            ssc.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(ssc);
        }

        private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            SimpleShareControl ssc = new SimpleShareControl(publicData, tableName, this);
            ssc.Dock= DockStyle.Fill;
            mainPanel.Controls.Add(ssc);
        }

        private void advancedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            AdvancedShareControl ssc = new AdvancedShareControl(this, tables, selectedServer, dataList);
            ssc.Dock= DockStyle.Fill;
            mainPanel.Controls.Add(ssc);
        }
    }
}
