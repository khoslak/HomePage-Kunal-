namespace Homepage
{
    partial class Search
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rdoTitle = new System.Windows.Forms.RadioButton();
            this.rdoAuthor = new System.Windows.Forms.RadioButton();
            this.rdoCategory = new System.Windows.Forms.RadioButton();
            this.rdoPublisher = new System.Windows.Forms.RadioButton();
            this.btnRequest = new System.Windows.Forms.Button();
            this.cmbRequest = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(131, 58);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(131, 97);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 20);
            this.txtAuthor.TabIndex = 3;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(131, 143);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(100, 20);
            this.txtPublisher.TabIndex = 4;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(131, 187);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(100, 20);
            this.txtCategory.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(699, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(24, 224);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(207, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // rdoTitle
            // 
            this.rdoTitle.AutoSize = true;
            this.rdoTitle.Location = new System.Drawing.Point(24, 58);
            this.rdoTitle.Name = "rdoTitle";
            this.rdoTitle.Size = new System.Drawing.Size(45, 17);
            this.rdoTitle.TabIndex = 10;
            this.rdoTitle.TabStop = true;
            this.rdoTitle.Text = "Title";
            this.rdoTitle.UseVisualStyleBackColor = true;
            // 
            // rdoAuthor
            // 
            this.rdoAuthor.AutoSize = true;
            this.rdoAuthor.Location = new System.Drawing.Point(24, 97);
            this.rdoAuthor.Name = "rdoAuthor";
            this.rdoAuthor.Size = new System.Drawing.Size(56, 17);
            this.rdoAuthor.TabIndex = 11;
            this.rdoAuthor.TabStop = true;
            this.rdoAuthor.Text = "Author";
            this.rdoAuthor.UseVisualStyleBackColor = true;
            // 
            // rdoCategory
            // 
            this.rdoCategory.AutoSize = true;
            this.rdoCategory.Location = new System.Drawing.Point(24, 187);
            this.rdoCategory.Name = "rdoCategory";
            this.rdoCategory.Size = new System.Drawing.Size(67, 17);
            this.rdoCategory.TabIndex = 12;
            this.rdoCategory.TabStop = true;
            this.rdoCategory.Text = "Category";
            this.rdoCategory.UseVisualStyleBackColor = true;
            // 
            // rdoPublisher
            // 
            this.rdoPublisher.AutoSize = true;
            this.rdoPublisher.Location = new System.Drawing.Point(24, 143);
            this.rdoPublisher.Name = "rdoPublisher";
            this.rdoPublisher.Size = new System.Drawing.Size(68, 17);
            this.rdoPublisher.TabIndex = 13;
            this.rdoPublisher.TabStop = true;
            this.rdoPublisher.Text = "Publisher";
            this.rdoPublisher.UseVisualStyleBackColor = true;
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(372, 224);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(186, 23);
            this.btnRequest.TabIndex = 14;
            this.btnRequest.Text = "Request Book";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cmbRequest
            // 
            this.cmbRequest.FormattingEnabled = true;
            this.cmbRequest.Location = new System.Drawing.Point(372, 139);
            this.cmbRequest.Name = "cmbRequest";
            this.cmbRequest.Size = new System.Drawing.Size(186, 21);
            this.cmbRequest.TabIndex = 15;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbRequest);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.rdoPublisher);
            this.Controls.Add(this.rdoCategory);
            this.Controls.Add(this.rdoAuthor);
            this.Controls.Add(this.rdoTitle);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Name = "Search";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rdoTitle;
        private System.Windows.Forms.RadioButton rdoAuthor;
        private System.Windows.Forms.RadioButton rdoCategory;
        private System.Windows.Forms.RadioButton rdoPublisher;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.ComboBox cmbRequest;
    }
}