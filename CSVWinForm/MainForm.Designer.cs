namespace CSVWinForm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ComboBoxSeperator = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonCSVImport = new System.Windows.Forms.Button();
            this.CreateCSV = new System.Windows.Forms.Button();
            this.AddColumn = new System.Windows.Forms.Button();
            this.SaveCSV = new System.Windows.Forms.Button();
            this.SpacesBox = new System.Windows.Forms.NumericUpDown();
            this.SpacesText = new System.Windows.Forms.Label();
            this.CompareCSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpacesBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(11, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1234, 677);
            this.dataGridView1.TabIndex = 0;
            // 
            // ComboBoxSeperator
            // 
            this.ComboBoxSeperator.FormattingEnabled = true;
            this.ComboBoxSeperator.Location = new System.Drawing.Point(11, 745);
            this.ComboBoxSeperator.Name = "ComboBoxSeperator";
            this.ComboBoxSeperator.Size = new System.Drawing.Size(131, 33);
            this.ComboBoxSeperator.TabIndex = 1;
            this.ComboBoxSeperator.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSeperator_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 720);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seperator";
            // 
            // ButtonCSVImport
            // 
            this.ButtonCSVImport.Location = new System.Drawing.Point(160, 737);
            this.ButtonCSVImport.Name = "ButtonCSVImport";
            this.ButtonCSVImport.Size = new System.Drawing.Size(133, 50);
            this.ButtonCSVImport.TabIndex = 3;
            this.ButtonCSVImport.Text = "Import CSV";
            this.ButtonCSVImport.UseVisualStyleBackColor = true;
            this.ButtonCSVImport.Click += new System.EventHandler(this.ButtonCSVImport_Click);
            // 
            // CreateCSV
            // 
            this.CreateCSV.Location = new System.Drawing.Point(307, 737);
            this.CreateCSV.Name = "CreateCSV";
            this.CreateCSV.Size = new System.Drawing.Size(133, 50);
            this.CreateCSV.TabIndex = 4;
            this.CreateCSV.Text = "Create CSV";
            this.CreateCSV.UseVisualStyleBackColor = true;
            this.CreateCSV.Click += new System.EventHandler(this.CreateCSV_Click);
            // 
            // AddColumn
            // 
            this.AddColumn.Location = new System.Drawing.Point(160, 810);
            this.AddColumn.Name = "AddColumn";
            this.AddColumn.Size = new System.Drawing.Size(133, 50);
            this.AddColumn.TabIndex = 5;
            this.AddColumn.Text = "Add Column";
            this.AddColumn.UseVisualStyleBackColor = true;
            this.AddColumn.Click += new System.EventHandler(this.AddColumn_Click);
            // 
            // SaveCSV
            // 
            this.SaveCSV.Location = new System.Drawing.Point(307, 810);
            this.SaveCSV.Name = "SaveCSV";
            this.SaveCSV.Size = new System.Drawing.Size(133, 50);
            this.SaveCSV.TabIndex = 6;
            this.SaveCSV.Text = "Save CSV";
            this.SaveCSV.UseVisualStyleBackColor = true;
            this.SaveCSV.Click += new System.EventHandler(this.SaveCSV_Click);
            // 
            // SpacesBox
            // 
            this.SpacesBox.Location = new System.Drawing.Point(11, 820);
            this.SpacesBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SpacesBox.Name = "SpacesBox";
            this.SpacesBox.Size = new System.Drawing.Size(133, 31);
            this.SpacesBox.TabIndex = 7;
            // 
            // SpacesText
            // 
            this.SpacesText.AutoSize = true;
            this.SpacesText.Location = new System.Drawing.Point(37, 792);
            this.SpacesText.Name = "SpacesText";
            this.SpacesText.Size = new System.Drawing.Size(67, 25);
            this.SpacesText.TabIndex = 8;
            this.SpacesText.Text = "Spaces";
            // 
            // CompareCSV
            // 
            this.CompareCSV.Location = new System.Drawing.Point(453, 737);
            this.CompareCSV.Name = "CompareCSV";
            this.CompareCSV.Size = new System.Drawing.Size(136, 50);
            this.CompareCSV.TabIndex = 9;
            this.CompareCSV.Text = "Compare  CSV";
            this.CompareCSV.UseVisualStyleBackColor = true;
            this.CompareCSV.Click += new System.EventHandler(this.CompareCSV_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1259, 943);
            this.Controls.Add(this.CompareCSV);
            this.Controls.Add(this.SpacesText);
            this.Controls.Add(this.SpacesBox);
            this.Controls.Add(this.SaveCSV);
            this.Controls.Add(this.AddColumn);
            this.Controls.Add(this.CreateCSV);
            this.Controls.Add(this.ButtonCSVImport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBoxSeperator);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "CSV";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpacesBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox ComboBoxSeperator;
        private Label label1;
        private Button ButtonCSVImport;
        private Button CreateCSV;
        private Button AddColumn;
        private Button SaveCSV;
        private NumericUpDown SpacesBox;
        private Label SpacesText;
        private Button CompareCSV;
    }
}