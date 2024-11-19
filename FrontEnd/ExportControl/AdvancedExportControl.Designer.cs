namespace ConverterProject.FrontEnd.ExportControl
{
    partial class AdvancedExportControl
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.databaseTreeView = new System.Windows.Forms.TreeView();
            this.label4 = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.formatComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.allButton = new System.Windows.Forms.Button();
            this.foldersCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Advanced mode:";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(217, 0);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exportButton.Location = new System.Drawing.Point(298, 0);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 23);
            this.exportButton.TabIndex = 13;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // databaseTreeView
            // 
            this.databaseTreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.databaseTreeView.Location = new System.Drawing.Point(0, 0);
            this.databaseTreeView.Name = "databaseTreeView";
            this.databaseTreeView.Size = new System.Drawing.Size(217, 285);
            this.databaseTreeView.TabIndex = 16;
            this.databaseTreeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.databaseTreeView_AfterCheck);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Save location:";
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(324, 2);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(45, 23);
            this.changeButton.TabIndex = 23;
            this.changeButton.Text = "...";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(89, 3);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(229, 23);
            this.locationTextBox.TabIndex = 22;
            // 
            // formatComboBox
            // 
            this.formatComboBox.FormattingEnabled = true;
            this.formatComboBox.Items.AddRange(new object[] {
            "CSV",
            "JSON",
            "XML"});
            this.formatComboBox.Location = new System.Drawing.Point(89, -3);
            this.formatComboBox.Name = "formatComboBox";
            this.formatComboBox.Size = new System.Drawing.Size(162, 23);
            this.formatComboBox.TabIndex = 19;
            this.formatComboBox.Text = "Select...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Select file type:";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(223, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 25;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // allButton
            // 
            this.allButton.Location = new System.Drawing.Point(223, 32);
            this.allButton.Name = "allButton";
            this.allButton.Size = new System.Drawing.Size(75, 23);
            this.allButton.TabIndex = 26;
            this.allButton.Text = "All";
            this.allButton.UseVisualStyleBackColor = true;
            this.allButton.Click += new System.EventHandler(this.allButton_Click);
            // 
            // foldersCheckBox
            // 
            this.foldersCheckBox.AutoSize = true;
            this.foldersCheckBox.Location = new System.Drawing.Point(223, 61);
            this.foldersCheckBox.Name = "foldersCheckBox";
            this.foldersCheckBox.Size = new System.Drawing.Size(110, 19);
            this.foldersCheckBox.TabIndex = 27;
            this.foldersCheckBox.Text = "Seperate folders";
            this.foldersCheckBox.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(382, 411);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.formatComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 24);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.locationTextBox);
            this.panel2.Controls.Add(this.changeButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 29);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.databaseTreeView);
            this.panel3.Controls.Add(this.foldersCheckBox);
            this.panel3.Controls.Add(this.clearButton);
            this.panel3.Controls.Add(this.allButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(376, 285);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.exportButton);
            this.panel4.Controls.Add(this.cancelButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 384);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(376, 24);
            this.panel4.TabIndex = 4;
            // 
            // AdvancedExportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AdvancedExportControl";
            this.Size = new System.Drawing.Size(382, 411);
            this.Load += new System.EventHandler(this.AdvancedExportControl_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Button cancelButton;
        private Button exportButton;
        private TreeView databaseTreeView;
        private Label label4;
        private Button changeButton;
        private TextBox locationTextBox;
        private ComboBox formatComboBox;
        private Label label5;
        private Button clearButton;
        private Button allButton;
        private CheckBox foldersCheckBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}
