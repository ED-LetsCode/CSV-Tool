namespace CSVWinForm
{
    partial class CSVCompare
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.File1DataGridView = new System.Windows.Forms.DataGridView();
            this.File2DataGridView = new System.Windows.Forms.DataGridView();
            this.TextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.File1DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.File2DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // File1DataGridView
            // 
            this.File1DataGridView.AllowUserToAddRows = false;
            this.File1DataGridView.AllowUserToDeleteRows = false;
            this.File1DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.File1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.File1DataGridView.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.File1DataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.File1DataGridView.GridColor = System.Drawing.Color.Gainsboro;
            this.File1DataGridView.Location = new System.Drawing.Point(17, 20);
            this.File1DataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.File1DataGridView.Name = "File1DataGridView";
            this.File1DataGridView.ReadOnly = true;
            this.File1DataGridView.RowHeadersWidth = 62;
            this.File1DataGridView.RowTemplate.Height = 25;
            this.File1DataGridView.Size = new System.Drawing.Size(900, 698);
            this.File1DataGridView.TabIndex = 0;
            // 
            // File2DataGridView
            // 
            this.File2DataGridView.AllowUserToAddRows = false;
            this.File2DataGridView.AllowUserToDeleteRows = false;
            this.File2DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.File2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.File2DataGridView.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.File2DataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.File2DataGridView.GridColor = System.Drawing.Color.Gainsboro;
            this.File2DataGridView.Location = new System.Drawing.Point(951, 20);
            this.File2DataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.File2DataGridView.Name = "File2DataGridView";
            this.File2DataGridView.ReadOnly = true;
            this.File2DataGridView.RowHeadersWidth = 62;
            this.File2DataGridView.RowTemplate.Height = 25;
            this.File2DataGridView.Size = new System.Drawing.Size(900, 698);
            this.File2DataGridView.TabIndex = 1;
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(466, 758);
            this.TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(971, 307);
            this.TextBox.TabIndex = 2;
            this.TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CSVCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1869, 1088);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.File2DataGridView);
            this.Controls.Add(this.File1DataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CSVCompare";
            this.Text = "Compare";
            this.Load += new System.EventHandler(this.CompareForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.File1DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.File2DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView File1DataGridView;
        private DataGridView File2DataGridView;
        private TextBox TextBox;
    }
}