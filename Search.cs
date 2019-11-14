//Author: Ramandeep Kaur
// to search and request book

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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        //connection string
        private SqlConnection conn = new SqlConnection();
        private string connString = "Server=Laptop-TBE3GK6p\\SQLEXPRESS01; " +
                            "Database=Library; User=kaur4542; Password=JKhrt956";
        private SqlCommand cmd;

        // to request book
        private void Button1_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = connString;
            cmd = conn.CreateCommand();
            int isbn = Convert.ToInt32(cmbRequest.SelectedValue);//isbn
            string status = "Requested to Issue";
            string userID = LoginInfo.id;
            //DateTime issueDate = Convert.ToDateTime(2019-07-11);
            //DateTime returnDate = Convert.ToDateTime(2019-07-11);
            try
            {
                string query = "Insert into Requested_Book values('" + isbn +
                                   "','" + userID + "','" + status + "');";


                cmd.CommandText = query;
                conn.Open();
                cmd.ExecuteNonQuery();
                string msg = "Request is placed to issue Book";
                string caption = "Info";
                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //to search book
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //search by title
            if (rdoTitle.Checked == true)
            {
                string title = txtTitle.Text;
                conn.ConnectionString = connString;
                cmd = conn.CreateCommand();

                string query = "select * from Books where Title='" + title + "'";
                cmd.CommandText = query;
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;

                cmbRequest.DisplayMember = "Title";
                cmbRequest.ValueMember = "ISBN_No";
                cmbRequest.DataSource = dt;
                reader.Close();
                conn.Close();
            }

            //search by author
            else if (rdoAuthor.Checked == true)
            {
                string author = txtAuthor.Text;
                conn.ConnectionString = connString;
                cmd = conn.CreateCommand();

                string query = "select * from Books where Author='" + author + "'";
                cmd.CommandText = query;
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;

                cmbRequest.DisplayMember = "Title";
                cmbRequest.ValueMember = "ISBN_No";
                cmbRequest.DataSource = dt;
                reader.Close();
                conn.Close();
            }

            //search by category
            else if (rdoCategory.Checked == true)
            {
                string category = txtCategory.Text;
                conn.ConnectionString = connString;
                cmd = conn.CreateCommand();

                string query = "select * from Books where Category='" + category + "'";
                cmd.CommandText = query;
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;

                cmbRequest.DisplayMember = "Title";
                cmbRequest.ValueMember = "ISBN_No";
                cmbRequest.DataSource = dt;
                reader.Close();
                conn.Close();
            }

            //search by publisher
            else if (rdoPublisher.Checked == true)
            {
                string publisher = txtPublisher.Text;
                conn.ConnectionString = connString;
                cmd = conn.CreateCommand();

                string query = "select * from Books where Publisher='" + publisher + "'";
                cmd.CommandText = query;
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;

                cmbRequest.DisplayMember = "Title";
                cmbRequest.ValueMember = "ISBN_No";
                cmbRequest.DataSource = dt;
                reader.Close();
                conn.Close();
            }

            else
                MessageBox.Show("Please choose search criteria","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

        }
    }
}
