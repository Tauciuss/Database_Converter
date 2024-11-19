namespace ConverterProject.FrontEnd.ExportControl
{
    partial class SimpleExportControl
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
            this.label2 = new System.Windows.Forms.Label();
            this.formatComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.exportButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Simple mode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select file type:";
            // 
            // formatComboBox
            // 
            this.formatComboBox.FormattingEnabled = true;
            this.formatComboBox.Items.AddRange(new object[] {
            "CSV",
            "JSON",
            "XML"});
            this.formatComboBox.Location = new System.Drawing.Point(86, -3);
            this.formatComboBox.Name = "formatComboBox";
            this.formatComboBox.Size = new System.Drawing.Size(121, 23);
            this.formatComboBox.TabIndex = 3;
            this.formatComboBox.Text = "Select...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "File name:";
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(86, -3);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(229, 23);
            this.fileNameTextBox.TabIndex = 5;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(96, -3);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(229, 23);
            this.locationTextBox.TabIndex = 6;
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(325, -4);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(45, 23);
            this.changeButton.TabIndex = 7;
            this.changeButton.Text = "...";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Export location:";
            // 
            // exportButton
            // 
            this.exportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exportButton.Location = new System.Drawing.Point(295, 3);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 23);
            this.exportButton.TabIndex = 10;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(214, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(379, 158);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.formatComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 27);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.fileNameTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 27);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.locationTextBox);
            this.panel3.Controls.Add(this.changeButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(373, 27);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cancelButton);
            this.panel4.Controls.Add(this.exportButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 125);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(373, 30);
            this.panel4.TabIndex = 3;
            // 
            // SimpleExportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SimpleExportControl";
            this.Size = new System.Drawing.Size(379, 158);
            this.Load += new System.EventHandler(this.SimpleExportControl_Load);
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
        private Label label2;
        private ComboBox formatComboBox;
        private Label label3;
        private TextBox fileNameTextBox;
        private TextBox locationTextBox;
        private Button changeButton;
        private Label label4;
        private Button exportButton;
        private Button cancelButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}
