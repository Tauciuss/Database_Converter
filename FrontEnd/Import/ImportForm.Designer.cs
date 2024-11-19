namespace ConverterProject.FrontEnd.Import
{
    partial class ImportForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.selectedTableRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newTableRadioButton = new System.Windows.Forms.RadioButton();
            this.importButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.selectedLabel = new System.Windows.Forms.Label();
            this.mongoWarningLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selected file:";
            // 
            // fileTextBox
            // 
            this.fileTextBox.Location = new System.Drawing.Point(88, 27);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.Size = new System.Drawing.Size(220, 23);
            this.fileTextBox.TabIndex = 1;
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(314, 26);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(31, 23);
            this.selectFileButton.TabIndex = 2;
            this.selectFileButton.Text = "...";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // selectedTableRadioButton
            // 
            this.selectedTableRadioButton.AutoSize = true;
            this.selectedTableRadioButton.Location = new System.Drawing.Point(6, 22);
            this.selectedTableRadioButton.Name = "selectedTableRadioButton";
            this.selectedTableRadioButton.Size = new System.Drawing.Size(98, 19);
            this.selectedTableRadioButton.TabIndex = 3;
            this.selectedTableRadioButton.TabStop = true;
            this.selectedTableRadioButton.Text = "Selected table";
            this.selectedTableRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newTableRadioButton);
            this.groupBox1.Controls.Add(this.selectedTableRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(9, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 54);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add to:";
            // 
            // newTableRadioButton
            // 
            this.newTableRadioButton.AutoSize = true;
            this.newTableRadioButton.Location = new System.Drawing.Point(110, 22);
            this.newTableRadioButton.Name = "newTableRadioButton";
            this.newTableRadioButton.Size = new System.Drawing.Size(78, 19);
            this.newTableRadioButton.TabIndex = 4;
            this.newTableRadioButton.TabStop = true;
            this.newTableRadioButton.Text = "New table";
            this.newTableRadioButton.UseVisualStyleBackColor = true;
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(270, 160);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(75, 23);
            this.importButton.TabIndex = 5;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(189, 160);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(270, 55);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(75, 23);
            this.viewButton.TabIndex = 7;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // selectedLabel
            // 
            this.selectedLabel.AutoSize = true;
            this.selectedLabel.Location = new System.Drawing.Point(9, 135);
            this.selectedLabel.Name = "selectedLabel";
            this.selectedLabel.Size = new System.Drawing.Size(102, 15);
            this.selectedLabel.TabIndex = 8;
            this.selectedLabel.Text = "Selected table: <>";
            // 
            // mongoWarningLabel
            // 
            this.mongoWarningLabel.AutoSize = true;
            this.mongoWarningLabel.Location = new System.Drawing.Point(88, 9);
            this.mongoWarningLabel.Name = "mongoWarningLabel";
            this.mongoWarningLabel.Size = new System.Drawing.Size(111, 15);
            this.mongoWarningLabel.TabIndex = 9;
            this.mongoWarningLabel.Text = "Select .json type file";
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 224);
            this.Controls.Add(this.mongoWarningLabel);
            this.Controls.Add(this.selectedLabel);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.selectFileButton);
            this.Controls.Add(this.fileTextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(407, 263);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(407, 263);
            this.Name = "ImportForm";
            this.ShowIcon = false;
            this.Text = "Import";
            this.Load += new System.EventHandler(this.ImportForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox fileTextBox;
        private Button selectFileButton;
        private RadioButton selectedTableRadioButton;
        private GroupBox groupBox1;
        private RadioButton newTableRadioButton;
        private Button importButton;
        private Button cancelButton;
        private Button viewButton;
        private Label selectedLabel;
        private Label mongoWarningLabel;
    }
}