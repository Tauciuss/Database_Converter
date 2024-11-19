using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverterProject.FrontEnd.Import
{
    public partial class ViewForm : Form
    {
        DataTable tempData = null;
        public ViewForm(DataTable mainDataGrid)
        {
            InitializeComponent();
            tempData = mainDataGrid;
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            mainDataGrid.DataSource = tempData;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
