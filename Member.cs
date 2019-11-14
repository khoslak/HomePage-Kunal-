//author: Ramandeep Kaur
//to request book
//to return book
//for extensions
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Homepage
{
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
        }

        //connection string
        private SqlConnection conn = new SqlConnection();
        private string connString = "Server=Laptop-TBE3GK6p\\SQLEXPRESS01; " +
                            "Database=Library; User=kaur4542; Password=JKhrt956";
        private SqlCommand cmd;

        //shows ViewAccountMember form
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAccountMember v = new ViewAccountMember();
            v.Show();
        }

        //shows search from
        private void SearchABookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
        }

        private void RequestABookToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //show editaccount form
        private void ViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditAccount editAccount = new EditAccount();
            editAccount.Show();
        }

        //displays data in grid view and combo box
        private void Refresh()
        {
            conn.ConnectionString = connString;
            cmd = conn.CreateCommand();


            string query = "select * from Members ";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            lblUser.Text = LoginInfo.Username;
            string id = LoginInfo.id;
            string query2 = "select * from Members_Book where UserId=" + id;
            cmd.CommandText = query2;
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;

            cmbReturn.DisplayMember = "ISBN_No";
            cmbReturn.ValueMember = "Member_Book_Id";
            cmbReturn.DataSource = dt;

            reader.Close();
        }

        //refreshes form
        private void Member_Load(object sender, EventArgs e)
        {
            try
            {
                //call refresh method
                Refresh();
                

            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                string caption = "error";
                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Dispose();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        

    }
        //shows search form

        private void BooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
            conn.ConnectionString = connString;
            cmd = conn.CreateCommand();
            int fid = Convert.ToInt32(cmbReturn.SelectedValue);
            string status = "Requested to Return";
            try
            {
                //update book status
                string query = "update Members_Book set Status ='" + status + "'where Member_Book_Id=" + fid;
                cmd.CommandText = query;
                conn.Open();
                cmd.ExecuteScalar();
            }

            catch (Exception ex)
            {
                string msg = ex.Message;
                string caption = "error";
                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                cmd.Dispose();
                conn.Close();
                Refresh();

            }
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
           
        }

        private void SearchBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
        }


        //to choose profile photo
        private void BtnProfilePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();  // TO open windows file explorer to pick an image for selection

            //filter to choose image files
            openFileDialog.Filter = "Image Files | *.JPG; *.BMP; *.PNG; *.JPEG; *.GIF ";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)  // to check if the image is actually selected
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;
                conn.ConnectionString = connString;
                cmd = conn.CreateCommand();
                String query = "UPDATE Members SET ImageLoc='" + pictureBox1.ImageLocation + "' WHERE USERID=" + LoginInfo.id;
                cmd.CommandText = query;
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();

            }
        }

        private void EditToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ViewAccountMember vs = new ViewAccountMember();
            vs.Show();
        }

        //to show edit account form
        private void ViewToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            EditAccount ea = new EditAccount();
            ea.Show();
        }
        //to log out user
        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("ARE YOU SURE YOU WANT TO LOG OUT ", DateTime.Now.ToLongDateString(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
                this.Close();
            else
            {

            }
        }

        private void BooksToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Search s = new Search();
            s.Show();
        }

        //to return book
        private void BtnReturn_Click_1(object sender, EventArgs e)
        {
            conn.ConnectionString = connString;
            cmd = conn.CreateCommand();
            int fid = Convert.ToInt32(cmbReturn.SelectedValue);
            string status = "Requested to Return";
            try
            {
                //update status
                string query = "update Members_Book set Status ='" + status + "'where Member_Book_Id=" + fid;
                cmd.CommandText = query;
                conn.Open();
                cmd.ExecuteScalar();
                MessageBox.Show("Request is placed to return book");
            }

            catch (Exception ex)
            {
                string msg = ex.Message;
                string caption = "error";
                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                cmd.Dispose();
                conn.Close();
                Refresh();

            }
        }

        private void RequestToDeleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //to show history from
        private void HistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
        }

        //to apply for extension
        private void BtnExtension_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = connString;
            cmd = conn.CreateCommand();
            int fid = Convert.ToInt32(cmbReturn.SelectedValue);
            string status = "Requested for Extension";
            try
            {
                //update status
                string query = "update Members_Book set Status ='" + status + "'where Member_Book_Id=" + fid;
                cmd.CommandText = query;
                conn.Open();
                cmd.ExecuteScalar();
                MessageBox.Show("Request is placed to Extend the due date for the selected book for 3 more days");
            }

            catch (Exception ex)
            {
                string msg = ex.Message;
                string caption = "error";
                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                cmd.Dispose();
                conn.Close();
                Refresh();

            }
        }

        //to show ViewExtensions from
        private void BtnNewDate_Click(object sender, EventArgs e)
        {
            ViewExtensions view = new ViewExtensions();
            view.Show();
        }

        //to show overdues form
        private void ViewOverduesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Overdues overdues = new Overdues();
            overdues.Show();

            
        }

        // to show PaymentsHistory form
        private void ViewPreviousPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentsHistory paymentsHistory = new PaymentsHistory();
            paymentsHistory.Show();
        }
    }
}
