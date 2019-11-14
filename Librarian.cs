//Author: Ramandeep Kaur
//issue books
//accept books
//show overdues and payments

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
    public partial class Librarian : Form
    {
        public Librarian()
        {
            InitializeComponent();
        }

        //connection string
        private SqlConnection conn = new SqlConnection();
        private string connString = "Server=Laptop-TBE3GK6p\\SQLEXPRESS01; " +
                            "Database=Library; User=kaur4542; Password=JKhrt956";
        private SqlCommand cmd;

        //display data in grid view and combo box from database
        private void Refresh()
        {
            conn.ConnectionString = connString;
            cmd = conn.CreateCommand();
            conn.Open();

            string status = "Requested to Return";
            string query2 = "select * from Members_Book where Status='" + status + "'";
            cmd.CommandText = query2;
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;

            cmbMembers.DisplayMember = "UserId";
            cmbMembers.ValueMember = "UserId";//////
            cmbMembers.DataSource = dt;

            cmbBooks.DisplayMember = "ISBN_No";
            cmbBooks.ValueMember = "ISBN_No";
            cmbBooks.DataSource = dt;
            reader.Close();

            string query3 = "select * from Requested_Book";
            cmd.CommandText = query3;
            SqlDataReader reader1 = cmd.ExecuteReader();
            DataTable dt1 = new DataTable();
            dt1.Load(reader1);
            dataGridView2.DataSource = dt1;

            comboBox2.DisplayMember = "User_Id";
            comboBox2.ValueMember = "User_Id";
            comboBox2.DataSource = dt1;

            comboBox3.DisplayMember = "ISBN_No";
            comboBox3.ValueMember = "ISBN_No";
            comboBox3.DataSource = dt1;


            reader1.Close();


            conn.Close();
        }

        //show Search form
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchLibrarian search = new SearchLibrarian();
            search.Show();
        }
        //show extensions form
        private void BtnExtension_Click(object sender, EventArgs e)
        {
            Extensions extensions = new Extensions();
            extensions.Show();
        }

        //show reports form
        private void BtnReports_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
        }

        //show librarian form
        private void Librarian_Load(object sender, EventArgs e)
        {
            Refresh();
            Refresh2();
        }

        //to add book, retuened by user, into books table
        //update status in members_book table
        //update book copies --inrement
        //update user limit --increment
        private void BtnAccept_Click(object sender, EventArgs e)
        {
            //update status in book_member
            //add book in database
            conn.ConnectionString = connString;
            cmd = conn.CreateCommand();
            int fid = Convert.ToInt32(cmbMembers.SelectedValue);
            int fid1 = Convert.ToInt32(cmbBooks.SelectedValue);
            //MessageBox.Show("fg", fid1.ToString());
            int copies;
            int copiesInc;
            int limit;
            int limitInc;
            string status = "Returned";
            try
            {
                //update status
                string query = "update Members_Book set Status ='" + status + "'where ISBN_No=" + fid1 + " and UserId = " + fid;
                cmd.CommandText = query;
                conn.Open();
                cmd.ExecuteScalar();

                //select books based on isbn
                string query2 = "select * from Books where ISBN_No='" + fid1 + "'";
                cmd.CommandText = query2;
                SqlDataReader reader1 = cmd.ExecuteReader();


                while (reader1.Read())
                {
                    copies = Convert.ToInt32(reader1["Copies_Available"]);
                    copiesInc = copies + 1;
                    LoginInfo.copies = copiesInc.ToString();

                }

                reader1.Close();

                string query4 = "select * from Members where UserID='" + fid + "'";
                cmd.CommandText = query4;
                SqlDataReader reader2 = cmd.ExecuteReader();

                while (reader2.Read())
                {
                    limit = Convert.ToInt32(reader2["BookLimit"]);
                    limitInc = limit + 1;
                    LoginInfo.limit = limitInc.ToString();

                }
                // MessageBox.Show("Limit", LoginInfo.limit.ToString());

                reader2.Close();

                //update copies available
                string query3 = "update Books set Copies_Available ='" + LoginInfo.copies + "'where ISBN_No=" + fid1;
                cmd.CommandText = query3;
                cmd.ExecuteNonQuery();

                //update members book limit
                string query5 = "update Members set BookLimit ='" + LoginInfo.limit + "'where UserId=" + fid;
                cmd.CommandText = query5;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book accepted");

                //method call
                History_Returned_Books(fid,fid1);

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
                //Refresh();

            }



        }

        //refreshes the form
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            //call refresh method 
            Refresh();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //call refresh method
            Refresh();

        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //to select title of the book from books table
        public string returnTitle(int isbn)
        {
            string title;


            string query = "select * from Books where ISBN_No='" + isbn + "'";
            cmd.CommandText = query;
            SqlDataReader reader1 = cmd.ExecuteReader();


            while (reader1.Read())
            {
                title = reader1["Title"].ToString();
                LoginInfo.title = title;

            }
            reader1.Close();
            return LoginInfo.title;
        }

        //insert data in the history_issued_books table
        public void historyIssueBooks(int user, int isbn, string title, string date)
        {
            //conn.Open();
            string query = "Insert into History_Issued_Books values('" + user +
                                   "','" + isbn + "','" + title + "','" + date + "');";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

        }

        //issues book to the member
        //update avaliable copies of books---decrement
        //update user limit --decrement
        //change status in members_book
        //delete from requested_book
        private void BtnIssue_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = connString;
            cmd = conn.CreateCommand();
            conn.Open();

            int isbn = Convert.ToInt32(comboBox3.SelectedValue);//isbn
            int user = Convert.ToInt32(comboBox2.SelectedValue);//member
            string status = "Issued";
            //string userID = LoginInfo.id;
            string issueDate = dateTimePicker1.Value.ToShortDateString();
            string dueDate = dateTimePicker2.Value.ToShortDateString();
            string title = returnTitle(isbn);//method call to get title
            historyIssueBooks(user, isbn, title, issueDate); //insert values into history_issue_books table
            int copies;
            int limit;
            int decrementLimit;
            int decrementCopies;

            string query1 = "select * from Books where ISBN_No='" + isbn + "'";
            cmd.CommandText = query1;
            SqlDataReader reader1 = cmd.ExecuteReader();


            while (reader1.Read())
            {
                copies = Convert.ToInt32(reader1["Copies_Available"]);
                decrementCopies = copies - 1;
                LoginInfo.decrementCopies = decrementCopies.ToString();

            }

            reader1.Close();
            string query4 = "select * from Members where UserID='" + user + "'";
            cmd.CommandText = query4;
            SqlDataReader reader2 = cmd.ExecuteReader();

            while (reader2.Read())
            {
                limit = Convert.ToInt32(reader2["BookLimit"]);
                decrementLimit = limit - 1;
                LoginInfo.decrementLimit = decrementLimit.ToString();

            }
            // MessageBox.Show("Limit", LoginInfo.decrementLimit.ToString());

            reader2.Close();

            try
            {
                //check user limit and copies available
                if ((Convert.ToInt32(LoginInfo.decrementLimit) > 0 &&
                    Convert.ToInt32(LoginInfo.decrementLimit) < 6) ||
                    Convert.ToInt32(LoginInfo.decrementCopies) > 0)
                {
                    //insert into members_book
                    string query = "Insert into Members_Book values('" + user +
                                   "','" + isbn + "','" + issueDate + "','" + dueDate + "','" + status + "');";

                    cmd.CommandText = query;
                    //conn.Open(); ----
                    cmd.ExecuteNonQuery();

                    //delete from requested_book
                    string query2 = "delete from Requested_Book where User_Id='" +
                                     user + "' and ISBN_No='" + isbn + "';";


                    cmd.CommandText = query2;
                    cmd.ExecuteNonQuery();

                    //update booklimit
                    string query5 = "update Members set BookLimit ='" + LoginInfo.decrementLimit + "'where UserId=" + user;
                    cmd.CommandText = query5;
                    cmd.ExecuteNonQuery();
                    //update copies
                    string query3 = "update Books set Copies_Available ='" + LoginInfo.decrementCopies + "'where ISBN_No=" + isbn;
                    cmd.CommandText = query3;
                    cmd.ExecuteNonQuery();
                    string msg = "Book Issued";
                    string caption = "Info";
                    MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    insertIntoOverdues();//method call...insert into overdues
                }//end of if

                else
                {
                    string msg = "Can not Issue Book! Either user has reached book limit or " +
                                 "library don not have any more copies ";
                    string caption = "Info";
                    MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
                //Refresh();

            }


        }

        //calculate the overdues
        private void insertIntoOverdues()
        {
            conn.Open();
            int user = Convert.ToInt32(LoginInfo.id);
            string status = "Issued";
            int isbn;
            DateTime issueDate;
            DateTime dueDate;
            int days;

            string query = "select * from Members_Book where UserId='" + user + "'";
            cmd.CommandText = query;
            SqlDataReader reader2 = cmd.ExecuteReader();


            while (reader2.Read())
            {
                isbn = Convert.ToInt32(reader2["ISBN_No"]);
                LoginInfo.isbn = isbn;
                issueDate = Convert.ToDateTime(reader2["IssueDate"]);
                LoginInfo.issueDate1 = issueDate;
                dueDate = Convert.ToDateTime(reader2["DueDate"]);
                LoginInfo.dueDate1 = dueDate;
            }
            reader2.Close();
            days = Convert.ToInt32((DateTime.Now - LoginInfo.dueDate1).TotalDays) - 1;
            string query2 = "Insert into Overdues values('" + user + "','" +
                LoginInfo.isbn + "','" + LoginInfo.issueDate1 + "','" + LoginInfo.dueDate1 + "','" + days + "');";
            cmd.CommandText = query2;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void BtnRefresh2_Click(object sender, EventArgs e)
        {
            Refresh2();
        }

        //display data in grid view and combo box
        private void Refresh2()
        {
            conn.ConnectionString = connString;
            cmd = conn.CreateCommand();
            conn.Open();
            string query4 = "select * from Overdues";
            cmd.CommandText = query4;
            SqlDataReader reader2 = cmd.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Load(reader2);
            dtGridViewOverdues.DataSource = dt2;
            reader2.Close();

            string query5 = "select * from Payments";
            cmd.CommandText = query5;
            SqlDataReader reader3 = cmd.ExecuteReader();
            DataTable dt3 = new DataTable();
            dt3.Load(reader3);
            dtGridViewPayments.DataSource = dt3;

            cmbSelUser.DisplayMember = "User_Id";
            cmbSelUser.ValueMember = "User_Id";
            cmbSelUser.DataSource = dt3;

            cmbSelIsbn.DisplayMember = "ISBN_No";
            cmbSelIsbn.ValueMember = "ISBN_No";
            cmbSelIsbn.DataSource = dt3;
            reader3.Close();
            conn.Close();
        }

        //calculate payments 
        private void BtnPayment_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = connString;
            cmd = conn.CreateCommand();
            int user = Convert.ToInt32(cmbSelUser.SelectedValue);
            int isbn = Convert.ToInt32(cmbSelIsbn.SelectedValue);
            
            string status = "Approved";
            try
            {
                string query = "update Payments set Status ='" + status + "'where ISBN_No=" + isbn +"and User_Id="+user;
                cmd.CommandText = query;
                conn.Open();
                cmd.ExecuteScalar();
                MessageBox.Show("Payment accepted");
                string query2 = "delete from Overdues where  ISBN_No=" + isbn + "and User_Id=" + user;
                cmd.CommandText = query2;
                
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
            }

           
        }

        //insert to historyreturnedbooks tables
        public void History_Returned_Books(int user,int isbn)
        {
            string date;
           
            string query = "select * from Members_Book where UserId='" + user + "'" +"and ISBN_No='"+isbn+"'";
            cmd.CommandText = query;
            SqlDataReader reader2 = cmd.ExecuteReader();


            while (reader2.Read())
            {
                
                date = reader2["DueDate"].ToString();
                LoginInfo.date = date;
            }
            reader2.Close();


            string query2 = "Insert into History_Returned_Books values('" + user +
                                   "','" + isbn + "','" +LoginInfo.date + "');";
            cmd.CommandText = query2;
            cmd.ExecuteNonQuery();
        }
    }
}
