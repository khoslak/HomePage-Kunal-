//Author: Ramandeep Kaur
//TO show the history of issued and returned books to member

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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        //connection string
        private SqlConnection conn = new SqlConnection();
        private string connString = "Server=Laptop-TBE3GK6p\\SQLEXPRESS01; " +
                            "Database=Library; User=kaur4542; Password=JKhrt956";
        private SqlCommand cmd;

        //populates data in grid view
        private void BtnShow_Click(object sender, EventArgs e)
        {
            // to show issued books
            if (rdoIssued.Checked == true)
            {
               
                conn.ConnectionString = connString;
                cmd = conn.CreateCommand();

                string query = "select * from History_Issued_Books where User_Id='" + LoginInfo.id + "'";
                cmd.CommandText = query;
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;

                reader.Close();
                conn.Close();
            }

            //to show returned books
            else if (rdoReturned.Checked == true)
            {
                
                conn.ConnectionString = connString;
                cmd = conn.CreateCommand();

                string query = "select * from History_Returned_Books where User_Id='" + LoginInfo.id + "'";
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
