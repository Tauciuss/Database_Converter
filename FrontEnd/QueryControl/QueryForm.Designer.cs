namespace ConverterProject.FrontEnd.QuerryControl
{
    partial class QueryForm
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
            this.databaseComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.executeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.queryTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mainDataGrid = new System.Windows.Forms.DataGridView();
            this.loadButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // databaseComboBox
            // 
            this.databaseComboBox.FormattingEnabled = true;
            this.databaseComboBox.Location = new System.Drawing.Point(67, 0);
            this.databaseComboBox.Name = "databaseComboBox";
            this.databaseComboBox.Size = new System.Drawing.Size(121, 23);
            this.databaseComboBox.TabIndex = 0;
            this.databaseComboBox.SelectedIndexChanged += new System.EventHandler(this.databaseComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Database: ";
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(213, 3);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(64, 22);
            this.executeButton.TabIndex = 2;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(288, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(64, 22);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(1079, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(64, 22);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // queryTextBox
            // 
            this.queryTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryTextBox.Location = new System.Drawing.Point(3, 3);
            this.queryTextBox.Multiline = true;
            this.queryTextBox.Name = "queryTextBox";
            this.queryTextBox.Size = new System.Drawing.Size(1140, 285);
            this.queryTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Result:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainDataGrid
            // 
            this.mainDataGrid.AllowUserToAddRows = false;
            this.mainDataGrid.AllowUserToDeleteRows = false;
            this.mainDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.mainDataGrid.Location = new System.Drawing.Point(3, 322);
            this.mainDataGrid.Name = "mainDataGrid";
            this.mainDataGrid.ReadOnly = true;
            this.mainDataGrid.RowTemplate.Height = 25;
            this.mainDataGrid.Size = new System.Drawing.Size(1140, 286);
            this.mainDataGrid.TabIndex = 9;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(363, 3);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(64, 22);
            this.loadButton.TabIndex = 10;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.exportButton.Location = new System.Drawing.Point(1065, 0);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 22);
            this.exportButton.TabIndex = 11;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.executeButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.loadButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.saveButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cancelButton, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1146, 30);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.databaseComboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 24);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.queryTextBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.mainDataGrid, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1146, 611);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.exportButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 294);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1140, 22);
            this.panel2.TabIndex = 7;
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 641);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "QueryForm";
            this.ShowIcon = false;
            this.Text = "MsSQL Query";
            this.Load += new System.EventHandler(this.QueryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox databaseComboBox;
        private Label label1;
        private Button executeButton;
        private Button saveButton;
        private Button cancelButton;
        private TextBox queryTextBox;
        private Label label2;
        private DataGridView mainDataGrid;
        private Button loadButton;
        private Button exportButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
    }
}