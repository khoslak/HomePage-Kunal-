namespace Homepage
{
    partial class Member
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Member));
            this.btnProfilePhoto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.cmbReturn = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestToDeleteAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOverduesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPreviousPaymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExtension = new System.Windows.Forms.Button();
            this.btnNewDate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProfilePhoto
            // 
            this.btnProfilePhoto.Location = new System.Drawing.Point(598, 238);
            this.btnProfilePhoto.Margin = new System.Windows.Forms.Padding(2);
            this.btnProfilePhoto.Name = "btnProfilePhoto";
            this.btnProfilePhoto.Size = new System.Drawing.Size(115, 37);
            this.btnProfilePhoto.TabIndex = 24;
            this.btnProfilePhoto.Text = "Upload Profile Photo";
            this.btnProfilePhoto.UseVisualStyleBackColor = true;
            this.btnProfilePhoto.Click += new System.EventHandler(this.BtnProfilePhoto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(554, 36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(36, 224);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(190, 23);
            this.btnReturn.TabIndex = 22;
            this.btnReturn.Text = "Return Book";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.BtnReturn_Click_1);
            // 
            // cmbReturn
            // 
            this.cmbReturn.FormattingEnabled = true;
            this.cmbReturn.Location = new System.Drawing.Point(36, 178);
            this.cmbReturn.Name = "cmbReturn";
            this.cmbReturn.Size = new System.Drawing.Size(190, 21);
            this.cmbReturn.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 296);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(730, 150);
            this.dataGridView1.TabIndex = 20;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(164, 75);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 13);
            this.lblUser.TabIndex = 19;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(33, 75);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 13);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Username";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.booksToolStripMenuItem,
            this.paymentsToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.requestToDeleteAccountToolStripMenuItem,
            this.historyToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.editToolStripMenuItem.Text = "View";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click_1);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.viewToolStripMenuItem.Text = "Change Contact Info";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.ViewToolStripMenuItem_Click_1);
            // 
            // requestToDeleteAccountToolStripMenuItem
            // 
            this.requestToDeleteAccountToolStripMenuItem.Name = "requestToDeleteAccountToolStripMenuItem";
            this.requestToDeleteAccountToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.requestToDeleteAccountToolStripMenuItem.Text = "Request to Delete Account";
            this.requestToDeleteAccountToolStripMenuItem.Click += new System.EventHandler(this.RequestToDeleteAccountToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.HistoryToolStripMenuItem_Click);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.booksToolStripMenuItem.Text = "Books";
            this.booksToolStripMenuItem.Click += new System.EventHandler(this.BooksToolStripMenuItem_Click_1);
            // 
            // paymentsToolStripMenuItem
            // 
            this.paymentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewOverduesToolStripMenuItem,
            this.viewPreviousPaymentsToolStripMenuItem});
            this.paymentsToolStripMenuItem.Name = "paymentsToolStripMenuItem";
            this.paymentsToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.paymentsToolStripMenuItem.Text = "Payments";
            // 
            // viewOverduesToolStripMenuItem
            // 
            this.viewOverduesToolStripMenuItem.Name = "viewOverduesToolStripMenuItem";
            this.viewOverduesToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.viewOverduesToolStripMenuItem.Text = "View Overdues";
            this.viewOverduesToolStripMenuItem.Click += new System.EventHandler(this.ViewOverduesToolStripMenuItem_Click);
            // 
            // viewPreviousPaymentsToolStripMenuItem
            // 
            this.viewPreviousPaymentsToolStripMenuItem.Name = "viewPreviousPaymentsToolStripMenuItem";
            this.viewPreviousPaymentsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.viewPreviousPaymentsToolStripMenuItem.Text = "View previous payments";
            this.viewPreviousPaymentsToolStripMenuItem.Click += new System.EventHandler(this.ViewPreviousPaymentsToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.LogOutToolStripMenuItem_Click);
            // 
            // btnExtension
            // 
            this.btnExtension.Location = new System.Drawing.Point(36, 253);
            this.btnExtension.Name = "btnExtension";
            this.btnExtension.Size = new System.Drawing.Size(190, 23);
            this.btnExtension.TabIndex = 25;
            this.btnExtension.Text = "Apply for Extension";
            this.btnExtension.UseVisualStyleBackColor = true;
            this.btnExtension.Click += new System.EventHandler(this.BtnExtension_Click);
            // 
            // btnNewDate
            // 
            this.btnNewDate.Location = new System.Drawing.Point(287, 253);
            this.btnNewDate.Name = "btnNewDate";
            this.btnNewDate.Size = new System.Drawing.Size(169, 23);
            this.btnNewDate.TabIndex = 26;
            this.btnNewDate.Text = "Check new return date";
            this.btnNewDate.UseVisualStyleBackColor = true;
            this.btnNewDate.Click += new System.EventHandler(this.BtnNewDate_Click);
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNewDate);
            this.Controls.Add(this.btnExtension);
            this.Controls.Add(this.btnProfilePhoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.cmbReturn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Member";
            this.Text = "Member";
            this.Load += new System.EventHandler(this.Member_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProfilePhoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ComboBox cmbReturn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestToDeleteAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewOverduesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPreviousPaymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.Button btnExtension;
        private System.Windows.Forms.Button btnNewDate;
    }
}