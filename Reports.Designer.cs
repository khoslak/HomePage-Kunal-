namespace Homepage
{
    partial class Reports
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rdoOverdue = new System.Windows.Forms.RadioButton();
            this.rdoIssued = new System.Windows.Forms.RadioButton();
            this.rdoBooks = new System.Windows.Forms.RadioButton();
            this.lblReport = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(746, 152);
            this.dataGridView1.TabIndex = 15;
            // 
            // rdoOverdue
            // 
            this.rdoOverdue.AutoSize = true;
            this.rdoOverdue.Location = new System.Drawing.Point(29, 133);
            this.rdoOverdue.Name = "rdoOverdue";
            this.rdoOverdue.Size = new System.Drawing.Size(99, 17);
            this.rdoOverdue.TabIndex = 14;
            this.rdoOverdue.TabStop = true;
            this.rdoOverdue.Text = "Overdue Books";
            this.rdoOverdue.UseVisualStyleBackColor = true;
            // 
            // rdoIssued
            // 
            this.rdoIssued.AutoSize = true;
            this.rdoIssued.Location = new System.Drawing.Point(29, 109);
            this.rdoIssued.Name = "rdoIssued";
            this.rdoIssued.Size = new System.Drawing.Size(89, 17);
            this.rdoIssued.TabIndex = 13;
            this.rdoIssued.TabStop = true;
            this.rdoIssued.Text = "Issued Books";
            this.rdoIssued.UseVisualStyleBackColor = true;
            // 
            // rdoBooks
            // 
            this.rdoBooks.AutoSize = true;
            this.rdoBooks.Location = new System.Drawing.Point(29, 85);
            this.rdoBooks.Name = "rdoBooks";
            this.rdoBooks.Size = new System.Drawing.Size(69, 17);
            this.rdoBooks.TabIndex = 12;
            this.rdoBooks.TabStop = true;
            this.rdoBooks.Text = "All Books";
            this.rdoBooks.UseVisualStyleBackColor = true;
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReport.Location = new System.Drawing.Point(26, 41);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(107, 13);
            this.lblReport.TabIndex = 11;
            this.lblReport.Text = "Generate Reports";
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(29, 170);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(104, 23);
            this.btnReport.TabIndex = 16;
            this.btnReport.Text = "Generate Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rdoOverdue);
            this.Controls.Add(this.rdoIssued);
            this.Controls.Add(this.rdoBooks);
            this.Controls.Add(this.lblReport);
            this.Name = "Reports";
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rdoOverdue;
        private System.Windows.Forms.RadioButton rdoIssued;
        private System.Windows.Forms.RadioButton rdoBooks;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.Button btnReport;
    }
}