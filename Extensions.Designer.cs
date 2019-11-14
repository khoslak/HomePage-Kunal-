namespace Homepage
{
    partial class Extensions
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
            this.cmbMembers = new System.Windows.Forms.ComboBox();
            this.cmbBooks = new System.Windows.Forms.ComboBox();
            this.lblSelectMember = new System.Windows.Forms.Label();
            this.lblSelectBook = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.returnDtae = new System.Windows.Forms.DateTimePicker();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnExtend = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMembers
            // 
            this.cmbMembers.FormattingEnabled = true;
            this.cmbMembers.Location = new System.Drawing.Point(205, 256);
            this.cmbMembers.Name = "cmbMembers";
            this.cmbMembers.Size = new System.Drawing.Size(121, 21);
            this.cmbMembers.TabIndex = 7;
            // 
            // cmbBooks
            // 
            this.cmbBooks.FormattingEnabled = true;
            this.cmbBooks.Location = new System.Drawing.Point(205, 220);
            this.cmbBooks.Name = "cmbBooks";
            this.cmbBooks.Size = new System.Drawing.Size(121, 21);
            this.cmbBooks.TabIndex = 6;
            // 
            // lblSelectMember
            // 
            this.lblSelectMember.AutoSize = true;
            this.lblSelectMember.Location = new System.Drawing.Point(47, 256);
            this.lblSelectMember.Name = "lblSelectMember";
            this.lblSelectMember.Size = new System.Drawing.Size(78, 13);
            this.lblSelectMember.TabIndex = 5;
            this.lblSelectMember.Text = "Select Member";
            // 
            // lblSelectBook
            // 
            this.lblSelectBook.AutoSize = true;
            this.lblSelectBook.Location = new System.Drawing.Point(47, 220);
            this.lblSelectBook.Name = "lblSelectBook";
            this.lblSelectBook.Size = new System.Drawing.Size(65, 13);
            this.lblSelectBook.TabIndex = 4;
            this.lblSelectBook.Text = "Select Book";
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Location = new System.Drawing.Point(47, 296);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(90, 13);
            this.lblReturnDate.TabIndex = 8;
            this.lblReturnDate.Text = "New Return Date";
            // 
            // returnDtae
            // 
            this.returnDtae.Enabled = false;
            this.returnDtae.Location = new System.Drawing.Point(205, 296);
            this.returnDtae.Name = "returnDtae";
            this.returnDtae.Size = new System.Drawing.Size(121, 20);
            this.returnDtae.TabIndex = 9;
            this.returnDtae.Value = new System.DateTime(2019, 7, 24, 0, 0, 0, 0);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(50, 346);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 10;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // btnExtend
            // 
            this.btnExtend.Enabled = false;
            this.btnExtend.Location = new System.Drawing.Point(50, 397);
            this.btnExtend.Name = "btnExtend";
            this.btnExtend.Size = new System.Drawing.Size(75, 23);
            this.btnExtend.TabIndex = 11;
            this.btnExtend.Text = "Extend";
            this.btnExtend.UseVisualStyleBackColor = true;
            this.btnExtend.Click += new System.EventHandler(this.BtnExtend_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(695, 141);
            this.dataGridView1.TabIndex = 12;
            // 
            // Extensions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExtend);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.returnDtae);
            this.Controls.Add(this.lblReturnDate);
            this.Controls.Add(this.cmbMembers);
            this.Controls.Add(this.cmbBooks);
            this.Controls.Add(this.lblSelectMember);
            this.Controls.Add(this.lblSelectBook);
            this.Name = "Extensions";
            this.Text = "Extensions";
            this.Load += new System.EventHandler(this.Extensions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMembers;
        private System.Windows.Forms.ComboBox cmbBooks;
        private System.Windows.Forms.Label lblSelectMember;
        private System.Windows.Forms.Label lblSelectBook;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.DateTimePicker returnDtae;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnExtend;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}