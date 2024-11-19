namespace ConverterProject.FrontEnd
{
    partial class ControlMongo
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
            this.connectionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showDatabasesButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.databasesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.databaseLabel = new System.Windows.Forms.Label();
            this.tablesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.mainGridView = new System.Windows.Forms.DataGridView();
            this.collectionLabel = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.connectedToLabel = new System.Windows.Forms.Label();
            this.importButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rememberCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.mainGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectionTextBox
            // 
            this.connectionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionTextBox.Location = new System.Drawing.Point(208, 2);
            this.connectionTextBox.Name = "connectionTextBox";
            this.connectionTextBox.Size = new System.Drawing.Size(169, 23);
            this.connectionTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Connection:";
            // 
            // showDatabasesButton
            // 
            this.showDatabasesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showDatabasesButton.Location = new System.Drawing.Point(383, 3);
            this.showDatabasesButton.Name = "showDatabasesButton";
            this.showDatabasesButton.Size = new System.Drawing.Size(108, 23);
            this.showDatabasesButton.TabIndex = 9;
            this.showDatabasesButton.Text = "Login";
            this.showDatabasesButton.UseVisualStyleBackColor = true;
            this.showDatabasesButton.Click += new System.EventHandler(this.showDatabasesButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 12;
            // 
            // databasesPanel
            // 
            this.databasesPanel.AutoScroll = true;
            this.databasesPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.databasesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.databasesPanel.Location = new System.Drawing.Point(3, 31);
            this.databasesPanel.Name = "databasesPanel";
            this.databasesPanel.Size = new System.Drawing.Size(127, 239);
            this.databasesPanel.TabIndex = 22;
            // 
            // databaseLabel
            // 
            this.databaseLabel.AutoSize = true;
            this.databaseLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.databaseLabel.Location = new System.Drawing.Point(3, 0);
            this.databaseLabel.Name = "databaseLabel";
            this.databaseLabel.Size = new System.Drawing.Size(127, 28);
            this.databaseLabel.TabIndex = 0;
            this.databaseLabel.Text = "Databases:";
            this.databaseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tablesPanel
            // 
            this.tablesPanel.AutoScroll = true;
            this.tablesPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tablesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablesPanel.Location = new System.Drawing.Point(3, 304);
            this.tablesPanel.Name = "tablesPanel";
            this.tablesPanel.Size = new System.Drawing.Size(127, 240);
            this.tablesPanel.TabIndex = 24;
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
            this.mainGridView.Size = new System.Drawing.Size(861, 493);
            this.mainGridView.TabIndex = 25;
            // 
            // collectionLabel
            // 
            this.collectionLabel.AutoSize = true;
            this.collectionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.collectionLabel.Location = new System.Drawing.Point(3, 273);
            this.collectionLabel.Name = "collectionLabel";
            this.collectionLabel.Size = new System.Drawing.Size(127, 28);
            this.collectionLabel.TabIndex = 26;
            this.collectionLabel.Text = "Collections:";
            this.collectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(143, 3);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(64, 22);
            this.sendButton.TabIndex = 28;
            this.sendButton.Text = "Share";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.shareButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(3, 3);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(64, 22);
            this.exportButton.TabIndex = 27;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // connectedToLabel
            // 
            this.connectedToLabel.AutoSize = true;
            this.connectedToLabel.Location = new System.Drawing.Point(3, 499);
            this.connectedToLabel.Name = "connectedToLabel";
            this.connectedToLabel.Size = new System.Drawing.Size(154, 15);
            this.connectedToLabel.TabIndex = 29;
            this.connectedToLabel.Text = "Connected to: <Databases>";
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(73, 3);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(64, 22);
            this.importButton.TabIndex = 31;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Server: MongoDB";
            // 
            // rememberCheckBox
            // 
            this.rememberCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rememberCheckBox.AutoSize = true;
            this.rememberCheckBox.Location = new System.Drawing.Point(208, 25);
            this.rememberCheckBox.Name = "rememberCheckBox";
            this.rememberCheckBox.Size = new System.Drawing.Size(114, 19);
            this.rememberCheckBox.TabIndex = 33;
            this.rememberCheckBox.Text = "Remember login";
            this.rememberCheckBox.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.databaseLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.databasesPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tablesPanel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.collectionLabel, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 53);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(133, 547);
            this.tableLayoutPanel1.TabIndex = 34;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1000, 53);
            this.tableLayoutPanel2.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.connectionTextBox);
            this.panel1.Controls.Add(this.rememberCheckBox);
            this.panel1.Controls.Add(this.showDatabasesButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(503, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 47);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.exportButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.importButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.sendButton, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(133, 53);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(867, 28);
            this.tableLayoutPanel3.TabIndex = 36;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.mainGridView, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.connectedToLabel, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(133, 81);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(867, 519);
            this.tableLayoutPanel4.TabIndex = 37;
            // 
            // ControlMongo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label5);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "ControlMongo";
            this.Size = new System.Drawing.Size(1000, 600);
            this.Load += new System.EventHandler(this.ControlMongo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox connectionTextBox;
        private Label label1;
        private Button showDatabasesButton;
        private Label label5;
        private FlowLayoutPanel databasesPanel;
        private Label databaseLabel;
        private FlowLayoutPanel tablesPanel;
        private DataGridView mainGridView;
        private Label collectionLabel;
        private Button sendButton;
        private Button exportButton;
        private Label connectedToLabel;
        private Button importButton;
        private Label label2;
        private CheckBox rememberCheckBox;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
    }
}
