/**
Author: Ramandeep Kaur
Purpose: To provide extensions to the issued books on users request
 */

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
    public partial class Extensions : Form
    {
        public Extensions()
        {
            InitializeComponent();
        }

        //connection string
        private SqlConnection conn = new SqlConnection();
        private string connString = "Server=Laptop-TBE3GK6p\\SQLEXPRESS01; " +
                            "Database=Library; User=kaur4542; Password=JKhrt956";
        private SqlCommand cmd;

        //to check if a book can be issued to the member
        //extension can be given only if no other member requested it and the library has its ccopies
        private void BtnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                int isbn = Convert.ToInt32(cmbBooks.SelectedValue);

                int copies;
                string status;
                conn.Open();
                string query1 = "select * from Books where ISBN_No='" + isbn + "'";
                cmd.CommandText = query1;
                SqlDataReader reader1 = cmd.ExecuteReader();
                while (reader1.Read())
                {
                    copies = Convert.ToInt32(reader1["Copies_Available"]);
                    LoginInfo.availableCopies = copies.ToString();

                }

                reader1.Close();

                string query2 = "select * from Members_Book where ISBN_No='" + isbn + "'";
                cmd.CommandText = query2;
                SqlDataReader reader2 = cmd.ExecuteReader();
                while (reader2.Read())
                {
                    status = reader2["Status"].ToString();
                    LoginInfo.status = status.ToString();
                    string dueDate = reader2["DueDate"].ToString();
                    LoginInfo.dueDate = dueDate;

                }
                reader2.Close();

                
                if (LoginInfo.status != "Requested to Issue")
                {
                    if (Convert.ToInt32(LoginInfo.availableCopies) > 0)
                    {
                        string msg = "Extension can be provided for 3 more days";
                        string caption = "Info";
                        MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnExtend.Enabled = true;
                        returnDtae.Enabled = true;
                        DateTime extendedDate = Convert.ToDateTime(LoginInfo.dueDate).AddDays(3);
                        LoginInfo.extendedDueDate = extendedDate;
                        returnDtae.Value = extendedDate;

                    }
                }

                else
                {
                    string msg = "Extension can not be provided";
                    string caption = "Info";
                    MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnExtend.Enabled = true;
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

        //refresh the form on form load to fetch data from database
        private void Extensions_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        //to display the data in gridview and combobox
        public void Refresh()
        {
            conn.ConnectionString = connString;
            cmd = conn.CreateCommand();
            conn.Open();

            string status = "Requested for Extension";
            string query2 = "select * from Members_Book where Status='" + status + "'";
            cmd.CommandText = query2;
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;

            cmbMembers.DisplayMember = "UserId";
            cmbMembers.ValueMember = "UserId";
            cmbMembers.DataSource = dt;

            cmbBooks.DisplayMember = "ISBN_No";
            cmbBooks.ValueMember = "ISBN_No";
            cmbBooks.DataSource = dt;
            reader.Close();
            conn.Close();
        }

        //to insert data in extensions tables 
        //and to update the book's status in members_book 
        private void BtnExtend_Click(object sender, EventArgs e)
        {
            try
            {
                int isbn = Convert.ToInt32(cmbBooks.SelectedValue);
                int user = Convert.ToInt32(cmbMembers.SelectedValue);
                string query = "Insert into Extensions values('" + user +
                                       "','" + isbn + "','" + LoginInfo.dueDate + "','" + LoginInfo.extendedDueDate + "');";
                conn.Open();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                string msg = "Extension provided";
                string caption = "Info";
                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnExtend.Enabled = true;

                string status = "Extension Provided";
                string query2 = "update Members_Book set Status ='" + status + "'where ISBN_No=" + isbn + " and UserId = " + user;
                cmd.CommandText = query2;
                cmd.ExecuteScalar();
               // Refresh();
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

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            //Refresh();
        }
    }
}
