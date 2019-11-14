//Author: Ramandeep Kaur
//to calculate overdues

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
    public partial class Overdues : Form
    {
        public Overdues()
        {
            InitializeComponent();
        }

        //connection string
        private SqlConnection conn = new SqlConnection();
        private string connString = "Server=Laptop-TBE3GK6p\\SQLEXPRESS01; " +
                            "Database=Library; User=kaur4542; Password=JKhrt956";
        private SqlCommand cmd;

        //to display data in grid view

        private void Overdues_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = connString;
            cmd = conn.CreateCommand();
            
            conn.Open();
            string query = "select * from Overdues";
            cmd.CommandText = query;
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;

            cmbSelect.DisplayMember = "ISBN_No";
            cmbSelect.ValueMember = "ISBN_No";
            cmbSelect.DataSource = dt;
            conn.Close();
            reader.Close();
        }

        //calculate overdues and insert into payments table
        private void BtnPayment_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                int user = Convert.ToInt32(LoginInfo.id);
                int isbn;
                DateTime paymentDate = dateTimePicker1.Value;
                int days;
                decimal amount;
                string status = "Pending";
                int isbnSelected = Convert.ToInt32(cmbSelect.SelectedValue);

                string query = "select * from Overdues where User_Id='" + user + "'" + "and ISBN_No='" + isbnSelected + "'";
                cmd.CommandText = query;
                SqlDataReader reader2 = cmd.ExecuteReader();


                while (reader2.Read())
                {
                    isbn = Convert.ToInt32(reader2["ISBN_No"]);
                    LoginInfo.isbn1 = isbn;
                    days = Convert.ToInt32(reader2["Days"]);
                    LoginInfo.days = days;
                }
                reader2.Close();

                amount = LoginInfo.days * 10;//10 cents for each day

                string query2 = "Insert into Payments values('" + user + "','" +
                    LoginInfo.isbn1 + "','" + paymentDate + "','" + amount + "','" + status + "');";
                cmd.CommandText = query2;
                cmd.ExecuteNonQuery();
               
                string msg = "Payment made";
                string caption = "Info";
                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                string msg1 = ex.Message;
                string caption1 = "error";
                MessageBox.Show(msg1, caption1, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                cmd.Dispose();
                conn.Close();
                //Refresh();

            }

        }
    }
}
