using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverterProject.FrontEnd.SendControl.ConnectionControls
{
    public partial class MongoConnectControl : UserControl
    {
        public MongoConnectControl(string connection)
        {
            InitializeComponent();
            mongoConnectionTextBox.Text = connection;
        }

        private void MongoConnectControl_Load(object sender, EventArgs e)
        {

        }

        public string GetMongoConnection()
        {
            if (!String.IsNullOrWhiteSpace(mongoConnectionTextBox.Text) && !String.IsNullOrEmpty(mongoConnectionTextBox.Text))
            {
                return mongoConnectionTextBox.Text;
            }
            else
                return null;
        }
    }
}
