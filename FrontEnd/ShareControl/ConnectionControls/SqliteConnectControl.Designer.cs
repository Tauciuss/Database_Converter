namespace ConverterProject.FrontEnd.ShareControl.ConnectionControls
{
    partial class SqliteConnectControl
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
            this.databasePathTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database path:";
            // 
            // databasePathTextBox
            // 
            this.databasePathTextBox.Location = new System.Drawing.Point(91, 3);
            this.databasePathTextBox.Name = "databasePathTextBox";
            this.databasePathTextBox.Size = new System.Drawing.Size(349, 23);
            this.databasePathTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(437, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(43, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "...";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // SqliteConnectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.databasePathTextBox);
            this.Controls.Add(this.label1);
            this.Name = "SqliteConnectControl";
            this.Size = new System.Drawing.Size(586, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox databasePathTextBox;
        private Button searchButton;
    }
}
