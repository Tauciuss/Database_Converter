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
    public partial class SqlConnectControl : UserControl
    {
        public SqlConnectControl(string serverName, string serverPassword, string serverUsername)
        {
            InitializeComponent();
            serverNameTextBox.Text = serverName;
            serverPasswordTextBox.Text = serverPassword;
            serverUsernameTextBox.Text = serverUsername;
        }

        public string GetSqlServerName()
        {
            if (!String.IsNullOrWhiteSpace(serverNameTextBox.Text) && !String.IsNullOrEmpty(serverNameTextBox.Text))
            {
                return serverNameTextBox.Text;
            }
            else
                return null;
        }

        public string GetSqlServerPassword()
        {
            if (!String.IsNullOrWhiteSpace(serverPasswordTextBox.Text) && !String.IsNullOrEmpty(serverPasswordTextBox.Text))
            {
                return serverPasswordTextBox.Text;
            }
            else
                return null;
        }

        public string GetSqlServerUsername()
        {
            if (!String.IsNullOrWhiteSpace(serverUsernameTextBox.Text) && !String.IsNullOrEmpty(serverUsernameTextBox.Text))
            {
                return serverUsernameTextBox.Text;
            }
            else
                return null;
        }
    }
}
