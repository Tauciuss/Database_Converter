namespace ConverterProject.FrontEnd
{
    partial class ControlSql
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.connectionButton = new System.Windows.Forms.Button();
            this.serverNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.databasesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.databaseLabel = new System.Windows.Forms.Label();
            this.tablesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tablesLabel = new System.Windows.Forms.Label();
            this.mainGridView = new System.Windows.Forms.DataGridView();
            this.connectedToLabel = new System.Windows.Forms.Label();
            this.exportButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.queryButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rememberCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.mainGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectionButton
            // 
            this.connectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionButton.Location = new System.Drawing.Point(204, -2);
            this.connectionButton.Name = "connectionButton";
            this.connectionButton.Size = new System.Drawing.Size(75, 27);
            this.connectionButton.TabIndex = 1;
            this.connectionButton.Text = "Login";
            this.connectionButton.UseVisualStyleBackColor = true;
            this.connectionButton.Click += new System.EventHandler(this.connectionButton_Click);
            // 
            // serverNameTextBox
            // 
            this.serverNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.serverNameTextBox.Location = new System.Drawing.Point(91, 0);
            this.serverNameTextBox.Name = "serverNameTextBox";
            this.serverNameTextBox.Size = new System.Drawing.Size(188, 23);
            this.serverNameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Server name:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Username:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTextBox.Location = new System.Drawing.Point(78, 0);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(201, 23);
            this.usernameTextBox.TabIndex = 8;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.Location = new System.Drawing.Point(66, 0);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(134, 23);
            this.passwordTextBox.TabIndex = 9;
            // 
            // databasesPanel
            // 
            this.databasesPanel.AutoScroll = true;
            this.databasesPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.databasesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.databasesPanel.Location = new System.Drawing.Point(3, 31);
            this.databasesPanel.Name = "databasesPanel";
            this.databasesPanel.Size = new System.Drawing.Size(132, 239);
            this.databasesPanel.TabIndex = 18;
            // 
            // databaseLabel
            // 
            this.databaseLabel.AutoSize = true;
            this.databaseLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.databaseLabel.Location = new System.Drawing.Point(3, 0);
            this.databaseLabel.Name = "databaseLabel";
            this.databaseLabel.Size = new System.Drawing.Size(132, 28);
            this.databaseLabel.TabIndex = 0;
            this.databaseLabel.Text = "Databases";
            this.databaseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tablesPanel
            // 
            this.tablesPanel.AutoScroll = true;
            this.tablesPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tablesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablesPanel.Location = new System.Drawing.Point(3, 304);
            this.tablesPanel.Name = "tablesPanel";
            this.tablesPanel.Size = new System.Drawing.Size(132, 240);
            this.tablesPanel.TabIndex = 19;
            // 
            // tablesLabel
            // 
            this.tablesLabel.AutoSize = true;
            this.tablesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablesLabel.Location = new System.Drawing.Point(3, 273);
            this.tablesLabel.Name = "tablesLabel";
            this.tablesLabel.Size = new System.Drawing.Size(132, 28);
            this.tablesLabel.TabIndex = 20;
            this.tablesLabel.Text = "Tables";
            this.tablesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainGridView
            // 
            this.mainGridView.AllowUserToAddRows = false;
            this.mainGridView.AllowUserToDeleteRows = false;
            this.mainGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainGridView.Location = new System.Drawing.Point(3, 3);
            this.mainGridView.Name = "mainGridView";
            this.mainGridView.ReadOnly = true;
            this.mainGridView.RowTemplate.Height = 25;
            this.mainGridView.Size = new System.Drawing.Size(856, 493);
            this.mainGridView.TabIndex = 21;
            // 
            // connectedToLabel
            // 
            this.connectedToLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectedToLabel.Location = new System.Drawing.Point(3, 499);
            this.connectedToLabel.Name = "connectedToLabel";
            this.connectedToLabel.Size = new System.Drawing.Size(856, 20);
            this.connectedToLabel.TabIndex = 22;
            this.connectedToLabel.Text = "Connected to: <Databases>";
            this.connectedToLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(73, 3);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(64, 22);
            this.exportButton.TabIndex = 23;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(213, 3);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(64, 22);
            this.sendButton.TabIndex = 24;
            this.sendButton.Text = "Share";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.shareButton_Click);
            // 
            // queryButton
            // 
            this.queryButton.Location = new System.Drawing.Point(3, 3);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(64, 22);
            this.queryButton.TabIndex = 25;
            this.queryButton.Text = "Query";
            this.queryButton.UseVisualStyleBackColor = true;
            this.queryButton.Click += new System.EventHandler(this.queryButton_Click);
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(143, 3);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(64, 22);
            this.importButton.TabIndex = 26;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Server: MsSQL";
            // 
            // rememberCheckBox
            // 
            this.rememberCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rememberCheckBox.AutoSize = true;
            this.rememberCheckBox.Location = new System.Drawing.Point(165, 24);
            this.rememberCheckBox.Name = "rememberCheckBox";
            this.rememberCheckBox.Size = new System.Drawing.Size(114, 19);
            this.rememberCheckBox.TabIndex = 28;
            this.rememberCheckBox.Text = "Remember login";
            this.rememberCheckBox.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.databasesPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tablesLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tablesPanel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.databaseLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 53);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(138, 547);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1000, 53);
            this.tableLayoutPanel2.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.serverNameTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(145, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 47);
            this.panel1.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.usernameTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(430, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 47);
            this.panel2.TabIndex = 29;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.passwordTextBox);
            this.panel3.Controls.Add(this.rememberCheckBox);
            this.panel3.Controls.Add(this.connectionButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(715, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(282, 47);
            this.panel3.TabIndex = 30;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.queryButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.exportButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.importButton, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.sendButton, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(138, 53);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(862, 28);
            this.tableLayoutPanel3.TabIndex = 31;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.connectedToLabel, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.mainGridView, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(138, 81);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(862, 519);
            this.tableLayoutPanel4.TabIndex = 32;
            // 
            // ControlSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "ControlSql";
            this.Size = new System.Drawing.Size(1000, 600);
            this.Load += new System.EventHandler(this.ControlSql_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button connectionButton;
        private TextBox serverNameTextBox;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private FlowLayoutPanel databasesPanel;
        private Label databaseLabel;
        private FlowLayoutPanel tablesPanel;
        private Label tablesLabel;
        private DataGridView mainGridView;
        private Label connectedToLabel;
        private Button exportButton;
        private Button sendButton;
        private Button queryButton;
        private Button importButton;
        private Label label1;
        private CheckBox rememberCheckBox;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
    }
}
