namespace Homepage
{
    partial class Librarian
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnExtension = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.cmbMembers = new System.Windows.Forms.ComboBox();
            this.cmbBooks = new System.Windows.Forms.ComboBox();
            this.lblSelectMember = new System.Windows.Forms.Label();
            this.lblSelectBook = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.cmbSelIsbn = new System.Windows.Forms.ComboBox();
            this.lblSelectUser = new System.Windows.Forms.Label();
            this.cmbSelUser = new System.Windows.Forms.ComboBox();
            this.btnRefresh2 = new System.Windows.Forms.Button();
            this.lblPayments = new System.Windows.Forms.Label();
            this.lblOverdue = new System.Windows.Forms.Label();
            this.dtGridViewPayments = new System.Windows.Forms.DataGridView();
            this.dtGridViewOverdues = new System.Windows.Forms.DataGridView();
            this.btnPayment = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewOverdues)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(802, 528);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRefresh);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnReports);
            this.tabPage1.Controls.Add(this.btnExtension);
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.btnAccept);
            this.tabPage1.Controls.Add(this.cmbMembers);
            this.tabPage1.Controls.Add(this.cmbBooks);
            this.tabPage1.Controls.Add(this.lblSelectMember);
            this.tabPage1.Controls.Add(this.lblSelectBook);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(794, 502);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Accept Books";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(458, 331);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(170, 23);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(60, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 150);
            this.dataGridView1.TabIndex = 15;
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(195, 6);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(183, 23);
            this.btnReports.TabIndex = 14;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.BtnReports_Click);
            // 
            // btnExtension
            // 
            this.btnExtension.Location = new System.Drawing.Point(384, 6);
            this.btnExtension.Name = "btnExtension";
            this.btnExtension.Size = new System.Drawing.Size(183, 23);
            this.btnExtension.TabIndex = 12;
            this.btnExtension.Text = "Extensions";
            this.btnExtension.UseVisualStyleBackColor = true;
            this.btnExtension.Click += new System.EventHandler(this.BtnExtension_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(6, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(183, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(458, 286);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(170, 23);
            this.btnAccept.TabIndex = 5;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // cmbMembers
            // 
            this.cmbMembers.FormattingEnabled = true;
            this.cmbMembers.Location = new System.Drawing.Point(205, 324);
            this.cmbMembers.Name = "cmbMembers";
            this.cmbMembers.Size = new System.Drawing.Size(121, 21);
            this.cmbMembers.TabIndex = 3;
            // 
            // cmbBooks
            // 
            this.cmbBooks.FormattingEnabled = true;
            this.cmbBooks.Location = new System.Drawing.Point(205, 288);
            this.cmbBooks.Name = "cmbBooks";
            this.cmbBooks.Size = new System.Drawing.Size(121, 21);
            this.cmbBooks.TabIndex = 2;
            // 
            // lblSelectMember
            // 
            this.lblSelectMember.AutoSize = true;
            this.lblSelectMember.Location = new System.Drawing.Point(79, 324);
            this.lblSelectMember.Name = "lblSelectMember";
            this.lblSelectMember.Size = new System.Drawing.Size(78, 13);
            this.lblSelectMember.TabIndex = 1;
            this.lblSelectMember.Text = "Select Member";
            // 
            // lblSelectBook
            // 
            this.lblSelectBook.AutoSize = true;
            this.lblSelectBook.Location = new System.Drawing.Point(79, 288);
            this.lblSelectBook.Name = "lblSelectBook";
            this.lblSelectBook.Size = new System.Drawing.Size(65, 13);
            this.lblSelectBook.TabIndex = 0;
            this.lblSelectBook.Text = "Select Book";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblIsbn);
            this.tabPage2.Controls.Add(this.cmbSelIsbn);
            this.tabPage2.Controls.Add(this.lblSelectUser);
            this.tabPage2.Controls.Add(this.cmbSelUser);
            this.tabPage2.Controls.Add(this.btnRefresh2);
            this.tabPage2.Controls.Add(this.lblPayments);
            this.tabPage2.Controls.Add(this.lblOverdue);
            this.tabPage2.Controls.Add(this.dtGridViewPayments);
            this.tabPage2.Controls.Add(this.dtGridViewOverdues);
            this.tabPage2.Controls.Add(this.btnPayment);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(794, 502);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Payments";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.TabPage2_Click);
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Location = new System.Drawing.Point(33, 434);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(77, 13);
            this.lblIsbn.TabIndex = 21;
            this.lblIsbn.Text = "Selected ISBN";
            // 
            // cmbSelIsbn
            // 
            this.cmbSelIsbn.FormattingEnabled = true;
            this.cmbSelIsbn.Location = new System.Drawing.Point(164, 431);
            this.cmbSelIsbn.Name = "cmbSelIsbn";
            this.cmbSelIsbn.Size = new System.Drawing.Size(121, 21);
            this.cmbSelIsbn.TabIndex = 20;
            // 
            // lblSelectUser
            // 
            this.lblSelectUser.AutoSize = true;
            this.lblSelectUser.Location = new System.Drawing.Point(33, 404);
            this.lblSelectUser.Name = "lblSelectUser";
            this.lblSelectUser.Size = new System.Drawing.Size(72, 13);
            this.lblSelectUser.TabIndex = 19;
            this.lblSelectUser.Text = "Selected user";
            // 
            // cmbSelUser
            // 
            this.cmbSelUser.FormattingEnabled = true;
            this.cmbSelUser.Location = new System.Drawing.Point(164, 401);
            this.cmbSelUser.Name = "cmbSelUser";
            this.cmbSelUser.Size = new System.Drawing.Size(121, 21);
            this.cmbSelUser.TabIndex = 18;
            // 
            // btnRefresh2
            // 
            this.btnRefresh2.Location = new System.Drawing.Point(164, 463);
            this.btnRefresh2.Name = "btnRefresh2";
            this.btnRefresh2.Size = new System.Drawing.Size(121, 23);
            this.btnRefresh2.TabIndex = 17;
            this.btnRefresh2.Text = "Refresh";
            this.btnRefresh2.UseVisualStyleBackColor = true;
            this.btnRefresh2.Click += new System.EventHandler(this.BtnRefresh2_Click);
            // 
            // lblPayments
            // 
            this.lblPayments.AutoSize = true;
            this.lblPayments.Location = new System.Drawing.Point(33, 198);
            this.lblPayments.Name = "lblPayments";
            this.lblPayments.Size = new System.Drawing.Size(53, 13);
            this.lblPayments.TabIndex = 16;
            this.lblPayments.Text = "Payments";
            // 
            // lblOverdue
            // 
            this.lblOverdue.AutoSize = true;
            this.lblOverdue.Location = new System.Drawing.Point(33, 19);
            this.lblOverdue.Name = "lblOverdue";
            this.lblOverdue.Size = new System.Drawing.Size(53, 13);
            this.lblOverdue.TabIndex = 15;
            this.lblOverdue.Text = "Overdues";
            // 
            // dtGridViewPayments
            // 
            this.dtGridViewPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewPayments.Location = new System.Drawing.Point(36, 228);
            this.dtGridViewPayments.Name = "dtGridViewPayments";
            this.dtGridViewPayments.Size = new System.Drawing.Size(640, 150);
            this.dtGridViewPayments.TabIndex = 14;
            // 
            // dtGridViewOverdues
            // 
            this.dtGridViewOverdues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewOverdues.Location = new System.Drawing.Point(36, 48);
            this.dtGridViewOverdues.Name = "dtGridViewOverdues";
            this.dtGridViewOverdues.Size = new System.Drawing.Size(640, 135);
            this.dtGridViewOverdues.TabIndex = 13;
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(36, 463);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(97, 23);
            this.btnPayment.TabIndex = 12;
            this.btnPayment.Text = "Make a Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.BtnPayment_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.dateTimePicker2);
            this.tabPage3.Controls.Add(this.dateTimePicker1);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.btnIssue);
            this.tabPage3.Controls.Add(this.comboBox2);
            this.tabPage3.Controls.Add(this.comboBox3);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(794, 502);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Issue Book";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Due Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Issue Date";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(198, 336);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 30;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(198, 310);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.Location = new System.Drawing.Point(198, 386);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(170, 23);
            this.btnIssue.TabIndex = 26;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.BtnIssue_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(198, 271);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 25;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(198, 235);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 24;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.ComboBox3_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Select Member";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Select Book";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(75, 38);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(643, 123);
            this.dataGridView2.TabIndex = 18;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Librarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 540);
            this.Controls.Add(this.tabControl1);
            this.Name = "Librarian";
            this.Text = "x";
            this.Load += new System.EventHandler(this.Librarian_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewOverdues)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnExtension;
        private System.Windows.Forms.Button btnSearch;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.ComboBox cmbMembers;
        private System.Windows.Forms.ComboBox cmbBooks;
        private System.Windows.Forms.Label lblSelectMember;
        private System.Windows.Forms.Label lblSelectBook;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblSelectUser;
        private System.Windows.Forms.ComboBox cmbSelUser;
        private System.Windows.Forms.Button btnRefresh2;
        private System.Windows.Forms.Label lblPayments;
        private System.Windows.Forms.Label lblOverdue;
        private System.Windows.Forms.DataGridView dtGridViewPayments;
        private System.Windows.Forms.DataGridView dtGridViewOverdues;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.ComboBox cmbSelIsbn;
    }
}