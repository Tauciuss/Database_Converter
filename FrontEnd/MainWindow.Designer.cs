namespace ConverterProject
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.databasesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mongoDB = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(600, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selected database:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databasesMenu,
            this.settingsToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(996, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // databasesMenu
            // 
            this.databasesMenu.BackColor = System.Drawing.SystemColors.Control;
            this.databasesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sQLToolStripMenuItem,
            this.mongoDB,
            this.sQLiteToolStripMenuItem});
            this.databasesMenu.Name = "databasesMenu";
            this.databasesMenu.Size = new System.Drawing.Size(56, 20);
            this.databasesMenu.Text = "Servers";
            // 
            // sQLToolStripMenuItem
            // 
            this.sQLToolStripMenuItem.Name = "sQLToolStripMenuItem";
            this.sQLToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.sQLToolStripMenuItem.Text = "MsSQL";
            this.sQLToolStripMenuItem.Click += new System.EventHandler(this.sQLToolStripMenuItem_Click);
            // 
            // mongoDB
            // 
            this.mongoDB.Name = "mongoDB";
            this.mongoDB.Size = new System.Drawing.Size(128, 22);
            this.mongoDB.Text = "MongoDB";
            this.mongoDB.Click += new System.EventHandler(this.mongoToolStripMenuItem_Click);
            // 
            // sQLiteToolStripMenuItem
            // 
            this.sQLiteToolStripMenuItem.Name = "sQLiteToolStripMenuItem";
            this.sQLiteToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.sQLiteToolStripMenuItem.Text = "SQLite";
            this.sQLiteToolStripMenuItem.Click += new System.EventHandler(this.sQLiteToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainPanel.ColumnCount = 1;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 24);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 1;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.Size = new System.Drawing.Size(996, 657);
            this.mainPanel.TabIndex = 9;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(996, 681);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Share system";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem databasesMenu;
        private ToolStripMenuItem sQLToolStripMenuItem;
        private ToolStripMenuItem mongoDB;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem sQLiteToolStripMenuItem;
        private TableLayoutPanel mainPanel;
    }
}