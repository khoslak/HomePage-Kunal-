//Author: Ramandeep Kaur
//To view extensions

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
    public partial class ViewExtensions : Form
    {
        public ViewExtensions()
        {
            InitializeComponent();
        }

        //connection string
        private SqlConnection conn = new SqlConnection();
        private string connString = "Server=Laptop-TBE3GK6p\\SQLEXPRESS01; " +
                            "Database=Library; User=kaur4542; Password=JKhrt956";
        private SqlCommand cmd;

        //to show member form
        private void BtnBack_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            member.Show();
              
        }

        //to view extensions--selects data from Members_Booktable

        private void ViewExtensions_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = connString;
            cmd = conn.CreateCommand();
            string id = LoginInfo.id;
            string query = "select * from Members_Book where UserId=" + id;
            conn.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            reader.Close();
            conn.Close();
        }
    }
}
