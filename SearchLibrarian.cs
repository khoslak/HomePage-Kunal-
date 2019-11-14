//Author : Ramandeep Kaur
//to search books

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
    public partial class SearchLibrarian : Form
    {
        public SearchLibrarian()
        {
            InitializeComponent();
        }

        //connection string
        private SqlConnection conn = new SqlConnection();
        private string connString = "Server=Laptop-TBE3GK6p\\SQLEXPRESS01; " +
                            "Database=Library; User=kaur4542; Password=JKhrt956";
        private SqlCommand cmd;

        //to search books
        private void BtnSearch_Click(object sender, EventArgs e)
        {

            //serach by title
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

               
                reader.Close();
                conn.Close();
            }

            else
                MessageBox.Show("Please choose search criteria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
