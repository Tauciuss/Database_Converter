namespace ConverterProject.FrontEnd.DatabaseControl
{
    partial class ControlSQLite
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
            this.rememberCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.importButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.connectedToLabel = new System.Windows.Forms.Label();
            this.mainGridView = new System.Windows.Forms.DataGridView();
            this.tablesLabel = new System.Windows.Forms.Label();
            this.tablesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.fileLocationTextBox = new System.Windows.Forms.TextBox();
            this.connectionButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
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
            // rememberCheckBox
            // 
            this.rememberCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rememberCheckBox.AutoSize = true;
            this.rememberCheckBox.Location = new System.Drawing.Point(250, 25);
            this.rememberCheckBox.Name = "rememberCheckBox";
            this.rememberCheckBox.Size = new System.Drawing.Size(130, 19);
            this.rememberCheckBox.TabIndex = 64;
            this.rememberCheckBox.Text = "Remember location";
            this.rememberCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 63;
            this.label1.Text = "Server: SQLite";
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(73, 3);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(64, 22);
            this.importButton.TabIndex = 62;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(143, 3);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(64, 22);
            this.sendButton.TabIndex = 61;
            this.sendButton.Text = "Share";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.shareButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(3, 3);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(64, 22);
            this.exportButton.TabIndex = 60;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // connectedToLabel
            // 
            this.connectedToLabel.AutoSize = true;
            this.connectedToLabel.Location = new System.Drawing.Point(3, 530);
            this.connectedToLabel.Name = "connectedToLabel";
            this.connectedToLabel.Size = new System.Drawing.Size(154, 15);
            this.connectedToLabel.TabIndex = 59;
            this.connectedToLabel.Text = "Connected to: <Databases>";
            // 
            // mainGridView
            // 
            this.mainGridView.AllowUserToAddRows = false;
            this.mainGridView.AllowUserToDeleteRows = false;
            this.mainGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainGridView.Location = new System.Drawing.Point(3, 3);
            this.mainGridView.Name = "mainGridView";
            this.mainGridView.RowTemplate.Height = 25;
            this.mainGridView.Size = new System.Drawing.Size(1003, 524);
            this.mainGridView.TabIndex = 58;
            // 
            // tablesLabel
            // 
            this.tablesLabel.AutoSize = true;
            this.tablesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablesLabel.Location = new System.Drawing.Point(3, 0);
            this.tablesLabel.Name = "tablesLabel";
            this.tablesLabel.Size = new System.Drawing.Size(107, 28);
            this.tablesLabel.TabIndex = 57;
            this.tablesLabel.Text = "Tables";
            this.tablesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tablesPanel
            // 
            this.tablesPanel.AutoScroll = true;
            this.tablesPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tablesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablesPanel.Location = new System.Drawing.Point(3, 31);
            this.tablesPanel.Name = "tablesPanel";
            this.tablesPanel.Size = new System.Drawing.Size(107, 544);
            this.tablesPanel.TabIndex = 56;
            // 
            // fileLocationTextBox
            // 
            this.fileLocationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileLocationTextBox.Location = new System.Drawing.Point(250, 4);
            this.fileLocationTextBox.Name = "fileLocationTextBox";
            this.fileLocationTextBox.Size = new System.Drawing.Size(175, 23);
            this.fileLocationTextBox.TabIndex = 54;
            // 
            // connectionButton
            // 
            this.connectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionButton.Location = new System.Drawing.Point(477, 5);
            this.connectionButton.Name = "connectionButton";
            this.connectionButton.Size = new System.Drawing.Size(75, 23);
            this.connectionButton.TabIndex = 48;
            this.connectionButton.Text = "Open";
            this.connectionButton.UseVisualStyleBackColor = true;
            this.connectionButton.Click += new System.EventHandler(this.connectionButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 65;
            this.label2.Text = "Database location:";
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(431, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(40, 25);
            this.searchButton.TabIndex = 66;
            this.searchButton.Text = "...";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tablesLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tablesPanel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 53);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(113, 578);
            this.tableLayoutPanel1.TabIndex = 67;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1122, 53);
            this.tableLayoutPanel2.TabIndex = 68;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.fileLocationTextBox);
            this.panel1.Controls.Add(this.rememberCheckBox);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.connectionButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(564, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 47);
            this.panel1.TabIndex = 64;
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(113, 53);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1009, 28);
            this.tableLayoutPanel3.TabIndex = 69;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.connectedToLabel, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.mainGridView, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(113, 81);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1009, 550);
            this.tableLayoutPanel4.TabIndex = 70;
            // 
            // ControlSQLite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "ControlSQLite";
            this.Size = new System.Drawing.Size(1122, 631);
            this.Load += new System.EventHandler(this.ControlSQLite_Load);
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

        }

        #endregion

        private CheckBox rememberCheckBox;
        private Label label1;
        private Button importButton;
        private Button sendButton;
        private Button exportButton;
        private Label connectedToLabel;
        private DataGridView mainGridView;
        private Label tablesLabel;
        private FlowLayoutPanel tablesPanel;
        private TextBox fileLocationTextBox;
        private Button connectionButton;
        private Label label2;
        private Button searchButton;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
    }
}
