using ConverterProject.FrontEnd;
using ConverterProject.FrontEnd.DatabaseControl;

namespace ConverterProject
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            ControlSql cq = new ControlSql();
            cq.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(cq);
        } 

       //SQL
        private void sQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            ControlSql cq = new ControlSql();
            cq.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(cq);
        }

        private void mongoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            ControlMongo cm = new ControlMongo();
            cm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(cm);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();
            sf.ShowDialog();
        }

        //Quit
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sQLiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            ControlSQLite cql = new ControlSQLite();
            cql.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(cql);
        }
    }
}