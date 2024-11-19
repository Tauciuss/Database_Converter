namespace ConverterProject.FrontEnd.SendControl.ConnectionControls
{
    partial class SqlConnectControl
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
            this.serverPasswordTextBox = new System.Windows.Forms.TextBox();
            this.serverNameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.serverUsernameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 39;
            this.label1.Text = "Server name:";
            // 
            // serverPasswordTextBox
            // 
            this.serverPasswordTextBox.Location = new System.Drawing.Point(84, 61);
            this.serverPasswordTextBox.Name = "serverPasswordTextBox";
            this.serverPasswordTextBox.PasswordChar = '*';
            this.serverPasswordTextBox.Size = new System.Drawing.Size(160, 23);
            this.serverPasswordTextBox.TabIndex = 43;
            this.serverPasswordTextBox.Text = "tutis2";
            // 
            // serverNameTextBox
            // 
            this.serverNameTextBox.Location = new System.Drawing.Point(84, 3);
            this.serverNameTextBox.Name = "serverNameTextBox";
            this.serverNameTextBox.Size = new System.Drawing.Size(160, 23);
            this.serverNameTextBox.TabIndex = 38;
            this.serverNameTextBox.Text = "localhost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 40;
            this.label6.Text = "Username:";
            // 
            // serverUsernameTextBox
            // 
            this.serverUsernameTextBox.Location = new System.Drawing.Point(84, 32);
            this.serverUsernameTextBox.Name = "serverUsernameTextBox";
            this.serverUsernameTextBox.Size = new System.Drawing.Size(160, 23);
            this.serverUsernameTextBox.TabIndex = 42;
            this.serverUsernameTextBox.Text = "tutis1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 41;
            this.label7.Text = "Password:";
            // 
            // SqlConnectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serverPasswordTextBox);
            this.Controls.Add(this.serverNameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.serverUsernameTextBox);
            this.Controls.Add(this.label7);
            this.Name = "SqlConnectControl";
            this.Size = new System.Drawing.Size(586, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox serverPasswordTextBox;
        private TextBox serverNameTextBox;
        private Label label6;
        private TextBox serverUsernameTextBox;
        private Label label7;
    }
}
