//Author: Ramandeep Kaur
//to generate reports

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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        //connection string
        private SqlConnection conn = new SqlConnection();
        private string connString = "Server=Laptop-TBE3GK6p\\SQLEXPRESS01; " +
                            "Database=Library; User=kaur4542; Password=JKhrt956";
        private SqlCommand cmd;

        //to generate reports
        private void BtnReport_Click(object sender, EventArgs e)
        {
            //to display all books
            if (rdoBooks.Checked == true)
            {
                
                conn.ConnectionString = connString;
                cmd = conn.CreateCommand();

                string query = "select * from Books ";
                cmd.CommandText = query;
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
                reader.Close();
                conn.Close();
            }

            //to display issued books
            else if (rdoIssued.Checked == true)
            {
                string issued = "Issued";
                conn.ConnectionString = connString;
                cmd = conn.CreateCommand();

                string query = "select * from Members_Book where Status='" + issued + "'";
                cmd.CommandText = query;
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;

                reader.Close();
                conn.Close();
            }
        }
    }
}
