namespace ConverterProject.FrontEnd.SendControl
{
    partial class AdvancedShareControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.serverComboBox = new System.Windows.Forms.ComboBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.shareButton = new System.Windows.Forms.Button();
            this.connectLabel = new System.Windows.Forms.Label();
            this.databasesTreeView = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.databaseTreeViewAll = new System.Windows.Forms.Button();
            this.databaseTreeViewClear = new System.Windows.Forms.Button();
            this.tablesTreeView = new System.Windows.Forms.TreeView();
            this.tablesTreeViewClear = new System.Windows.Forms.Button();
            this.tablesTreeViewAll = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "Connect to:";
            // 
            // serverComboBox
            // 
            this.serverComboBox.FormattingEnabled = true;
            this.serverComboBox.Items.AddRange(new object[] {
            "MsSQL",
            "MongoDB",
            "SQLite"});
            this.serverComboBox.Location = new System.Drawing.Point(70, -3);
            this.serverComboBox.Name = "serverComboBox";
            this.serverComboBox.Size = new System.Drawing.Size(121, 23);
            this.serverComboBox.TabIndex = 50;
            this.serverComboBox.SelectedIndexChanged += new System.EventHandler(this.serverComboBox_SelectedIndexChanged);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(3, 54);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(605, 94);
            this.mainPanel.TabIndex = 49;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(163, 0);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(64, 22);
            this.cancelButton.TabIndex = 46;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 23);
            this.label4.TabIndex = 43;
            this.label4.Text = "Advanced mode:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // shareButton
            // 
            this.shareButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shareButton.Location = new System.Drawing.Point(233, 0);
            this.shareButton.Name = "shareButton";
            this.shareButton.Size = new System.Drawing.Size(64, 22);
            this.shareButton.TabIndex = 42;
            this.shareButton.Text = "Share";
            this.shareButton.UseVisualStyleBackColor = true;
            this.shareButton.Click += new System.EventHandler(this.shareButton_Click);
            // 
            // connectLabel
            // 
            this.connectLabel.AutoSize = true;
            this.connectLabel.Location = new System.Drawing.Point(3, 179);
            this.connectLabel.Name = "connectLabel";
            this.connectLabel.Size = new System.Drawing.Size(91, 15);
            this.connectLabel.TabIndex = 37;
            this.connectLabel.Text = "Connection: <>";
            // 
            // databasesTreeView
            // 
            this.databasesTreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.databasesTreeView.Location = new System.Drawing.Point(0, 0);
            this.databasesTreeView.Name = "databasesTreeView";
            this.databasesTreeView.Size = new System.Drawing.Size(148, 178);
            this.databasesTreeView.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 52;
            this.label2.Text = "Select tables:";
            // 
            // databaseTreeViewAll
            // 
            this.databaseTreeViewAll.Location = new System.Drawing.Point(154, 3);
            this.databaseTreeViewAll.Name = "databaseTreeViewAll";
            this.databaseTreeViewAll.Size = new System.Drawing.Size(75, 23);
            this.databaseTreeViewAll.TabIndex = 53;
            this.databaseTreeViewAll.Text = "All";
            this.databaseTreeViewAll.UseVisualStyleBackColor = true;
            this.databaseTreeViewAll.Click += new System.EventHandler(this.databaseTreeViewAll_Click);
            // 
            // databaseTreeViewClear
            // 
            this.databaseTreeViewClear.Location = new System.Drawing.Point(154, 32);
            this.databaseTreeViewClear.Name = "databaseTreeViewClear";
            this.databaseTreeViewClear.Size = new System.Drawing.Size(75, 23);
            this.databaseTreeViewClear.TabIndex = 54;
            this.databaseTreeViewClear.Text = "Clear";
            this.databaseTreeViewClear.UseVisualStyleBackColor = true;
            this.databaseTreeViewClear.Click += new System.EventHandler(this.databaseTreeViewClear_Click);
            // 
            // tablesTreeView
            // 
            this.tablesTreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.tablesTreeView.Location = new System.Drawing.Point(0, 0);
            this.tablesTreeView.Name = "tablesTreeView";
            this.tablesTreeView.Size = new System.Drawing.Size(148, 178);
            this.tablesTreeView.TabIndex = 57;
            // 
            // tablesTreeViewClear
            // 
            this.tablesTreeViewClear.Location = new System.Drawing.Point(154, 32);
            this.tablesTreeViewClear.Name = "tablesTreeViewClear";
            this.tablesTreeViewClear.Size = new System.Drawing.Size(75, 23);
            this.tablesTreeViewClear.TabIndex = 59;
            this.tablesTreeViewClear.Text = "Clear";
            this.tablesTreeViewClear.UseVisualStyleBackColor = true;
            this.tablesTreeViewClear.Click += new System.EventHandler(this.tablesTreeViewClear_Click);
            // 
            // tablesTreeViewAll
            // 
            this.tablesTreeViewAll.Location = new System.Drawing.Point(154, 3);
            this.tablesTreeViewAll.Name = "tablesTreeViewAll";
            this.tablesTreeViewAll.Size = new System.Drawing.Size(75, 23);
            this.tablesTreeViewAll.TabIndex = 58;
            this.tablesTreeViewAll.Text = "All";
            this.tablesTreeViewAll.UseVisualStyleBackColor = true;
            this.tablesTreeViewAll.Click += new System.EventHandler(this.tablesTreeViewAll_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 15);
            this.label6.TabIndex = 60;
            this.label6.Text = "Select databases:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.mainPanel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.connectLabel, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(611, 202);
            this.tableLayoutPanel1.TabIndex = 61;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.serverComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 22);
            this.panel1.TabIndex = 44;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkButton);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(605, 22);
            this.panel2.TabIndex = 50;
            // 
            // checkButton
            // 
            this.checkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkButton.Location = new System.Drawing.Point(538, 3);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(64, 22);
            this.checkButton.TabIndex = 47;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(401, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 15);
            this.label12.TabIndex = 48;
            this.label12.Text = "Checks the connection.";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 202);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(611, 230);
            this.tableLayoutPanel2.TabIndex = 62;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tablesTreeView);
            this.panel4.Controls.Add(this.tablesTreeViewAll);
            this.panel4.Controls.Add(this.tablesTreeViewClear);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(299, 178);
            this.panel4.TabIndex = 61;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.databasesTreeView);
            this.panel5.Controls.Add(this.databaseTreeViewAll);
            this.panel5.Controls.Add(this.databaseTreeViewClear);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(308, 23);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 178);
            this.panel5.TabIndex = 62;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cancelButton);
            this.panel6.Controls.Add(this.shareButton);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(308, 207);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(300, 20);
            this.panel6.TabIndex = 63;
            // 
            // AdvancedShareControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AdvancedShareControl";
            this.Size = new System.Drawing.Size(611, 432);
            this.Load += new System.EventHandler(this.AdvancedShareControl_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private ComboBox serverComboBox;
        private Panel mainPanel;
        private Button cancelButton;
        private Label label4;
        private Button shareButton;
        private Label connectLabel;
        private TreeView databasesTreeView;
        private Label label2;
        private Button databaseTreeViewAll;
        private Button databaseTreeViewClear;
        private TreeView tablesTreeView;
        private Button tablesTreeViewClear;
        private Button tablesTreeViewAll;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel2;
        private Button checkButton;
        private Label label12;
    }
}
