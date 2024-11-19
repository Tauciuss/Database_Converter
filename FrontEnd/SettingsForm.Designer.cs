namespace ConverterProject.FrontEnd
{
    partial class SettingsForm
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
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exportLocationTextBox = new System.Windows.Forms.TextBox();
            this.importLocationTextBox = new System.Windows.Forms.TextBox();
            this.defaultExportButton = new System.Windows.Forms.Button();
            this.defaultImportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(445, 90);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(364, 90);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Default export location:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Default import location: ";
            // 
            // exportLocationTextBox
            // 
            this.exportLocationTextBox.Location = new System.Drawing.Point(178, 9);
            this.exportLocationTextBox.Name = "exportLocationTextBox";
            this.exportLocationTextBox.Size = new System.Drawing.Size(302, 23);
            this.exportLocationTextBox.TabIndex = 6;
            // 
            // importLocationTextBox
            // 
            this.importLocationTextBox.Location = new System.Drawing.Point(178, 47);
            this.importLocationTextBox.Name = "importLocationTextBox";
            this.importLocationTextBox.Size = new System.Drawing.Size(302, 23);
            this.importLocationTextBox.TabIndex = 7;
            // 
            // defaultExportButton
            // 
            this.defaultExportButton.Location = new System.Drawing.Point(480, 9);
            this.defaultExportButton.Name = "defaultExportButton";
            this.defaultExportButton.Size = new System.Drawing.Size(42, 23);
            this.defaultExportButton.TabIndex = 8;
            this.defaultExportButton.Text = "...";
            this.defaultExportButton.UseVisualStyleBackColor = true;
            this.defaultExportButton.Click += new System.EventHandler(this.defaultExportButton_Click);
            // 
            // defaultImportButton
            // 
            this.defaultImportButton.Location = new System.Drawing.Point(480, 47);
            this.defaultImportButton.Name = "defaultImportButton";
            this.defaultImportButton.Size = new System.Drawing.Size(42, 23);
            this.defaultImportButton.TabIndex = 9;
            this.defaultImportButton.Text = "...";
            this.defaultImportButton.UseVisualStyleBackColor = true;
            this.defaultImportButton.Click += new System.EventHandler(this.defaultImportButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(534, 122);
            this.Controls.Add(this.defaultImportButton);
            this.Controls.Add(this.defaultExportButton);
            this.Controls.Add(this.importLocationTextBox);
            this.Controls.Add(this.exportLocationTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button saveButton;
        private Button cancelButton;
        private Label label2;
        private Label label3;
        private TextBox exportLocationTextBox;
        private TextBox importLocationTextBox;
        private Button defaultExportButton;
        private Button defaultImportButton;
    }
}