namespace ConverterProject.FrontEnd.SendControl
{
    partial class SimpleShareControl
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
            this.connectLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableNameTextBox = new System.Windows.Forms.TextBox();
            this.selectedTableTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.databaseComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.serverComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rememberCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectLabel
            // 
            this.connectLabel.AutoSize = true;
            this.connectLabel.Location = new System.Drawing.Point(3, 2);
            this.connectLabel.Name = "connectLabel";
            this.connectLabel.Size = new System.Drawing.Size(91, 15);
            this.connectLabel.TabIndex = 2;
            this.connectLabel.Text = "Connection: <>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Table name:";
            // 
            // tableNameTextBox
            // 
            this.tableNameTextBox.Location = new System.Drawing.Point(92, -3);
            this.tableNameTextBox.Name = "tableNameTextBox";
            this.tableNameTextBox.Size = new System.Drawing.Size(241, 23);
            this.tableNameTextBox.TabIndex = 4;
            // 
            // selectedTableTextBox
            // 
            this.selectedTableTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.selectedTableTextBox.Location = new System.Drawing.Point(89, 36);
            this.selectedTableTextBox.Name = "selectedTableTextBox";
            this.selectedTableTextBox.ReadOnly = true;
            this.selectedTableTextBox.Size = new System.Drawing.Size(134, 23);
            this.selectedTableTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Selected table:";
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.Location = new System.Drawing.Point(643, 1);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 7;
            this.sendButton.Text = "Share";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.shareButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Simple mode:";
            // 
            // databaseComboBox
            // 
            this.databaseComboBox.FormattingEnabled = true;
            this.databaseComboBox.Location = new System.Drawing.Point(67, -1);
            this.databaseComboBox.Name = "databaseComboBox";
            this.databaseComboBox.Size = new System.Drawing.Size(156, 23);
            this.databaseComboBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Database:";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(562, 1);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkButton.Location = new System.Drawing.Point(643, 1);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(75, 23);
            this.checkButton.TabIndex = 15;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(523, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 15);
            this.label12.TabIndex = 33;
            this.label12.Text = "Checks the connection.";
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(3, 54);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(721, 94);
            this.mainPanel.TabIndex = 34;
            // 
            // serverComboBox
            // 
            this.serverComboBox.FormattingEnabled = true;
            this.serverComboBox.Items.AddRange(new object[] {
            "MsSQL",
            "MongoDB",
            "SQLite"});
            this.serverComboBox.Location = new System.Drawing.Point(79, -3);
            this.serverComboBox.Name = "serverComboBox";
            this.serverComboBox.Size = new System.Drawing.Size(121, 23);
            this.serverComboBox.TabIndex = 35;
            this.serverComboBox.SelectedIndexChanged += new System.EventHandler(this.serverComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connect to:";
            // 
            // rememberCheckBox
            // 
            this.rememberCheckBox.AutoSize = true;
            this.rememberCheckBox.Location = new System.Drawing.Point(3, 5);
            this.rememberCheckBox.Name = "rememberCheckBox";
            this.rememberCheckBox.Size = new System.Drawing.Size(128, 19);
            this.rememberCheckBox.TabIndex = 57;
            this.rememberCheckBox.Text = "Remember settings";
            this.rememberCheckBox.UseVisualStyleBackColor = true;
            this.rememberCheckBox.CheckedChanged += new System.EventHandler(this.rememberCheckBox_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.mainPanel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(727, 578);
            this.tableLayoutPanel1.TabIndex = 58;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.serverComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 22);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.connectLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 184);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(721, 17);
            this.panel2.TabIndex = 35;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.databaseComboBox);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 207);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(721, 17);
            this.panel3.TabIndex = 36;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.selectedTableTextBox);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 230);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(721, 111);
            this.panel4.TabIndex = 37;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.tableNameTextBox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 347);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(721, 111);
            this.panel5.TabIndex = 38;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.rememberCheckBox);
            this.panel6.Controls.Add(this.cancelButton);
            this.panel6.Controls.Add(this.sendButton);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 464);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(721, 111);
            this.panel6.TabIndex = 39;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.checkButton);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 154);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(721, 24);
            this.panel7.TabIndex = 40;
            // 
            // SimpleShareControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SimpleShareControl";
            this.Size = new System.Drawing.Size(727, 578);
            this.Load += new System.EventHandler(this.SimpleSendControl_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label connectLabel;
        private Label label2;
        private TextBox tableNameTextBox;
        private TextBox selectedTableTextBox;
        private Label label3;
        private Button sendButton;
        private Label label4;
        private ComboBox databaseComboBox;
        private Label label5;
        private Button cancelButton;
        private Button checkButton;
        private Label label12;
        private Panel mainPanel;
        private ComboBox serverComboBox;
        private Label label1;
        private CheckBox rememberCheckBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
    }
}
