namespace ConverterProject.FrontEnd.SendControl.ConnectionControls
{
    partial class MongoConnectControl
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
            this.label8 = new System.Windows.Forms.Label();
            this.mongoConnectionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Connection:";
            // 
            // mongoConnectionTextBox
            // 
            this.mongoConnectionTextBox.Location = new System.Drawing.Point(81, 3);
            this.mongoConnectionTextBox.Name = "mongoConnectionTextBox";
            this.mongoConnectionTextBox.Size = new System.Drawing.Size(169, 23);
            this.mongoConnectionTextBox.TabIndex = 21;
            this.mongoConnectionTextBox.Text = "mongodb://127.0.0.1:27017";
            // 
            // MongoConnectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mongoConnectionTextBox);
            this.Name = "MongoConnectControl";
            this.Size = new System.Drawing.Size(586, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label8;
        private TextBox mongoConnectionTextBox;
    }
}
