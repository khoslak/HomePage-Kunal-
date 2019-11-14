//Author : Ramandeep Kaur
//Displays Home page

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //connection string
        private SqlConnection conn = new SqlConnection();
        private string connString = "Server=Laptop-TBE3GK6p\\SQLEXPRESS01; " +
                            "Database=Library; User=kaur4542; Password=JKhrt956";
        private SqlCommand cmd;
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        //to display Administrator form 
        private void BtnAdministrator_Click(object sender, EventArgs e)
        {
            Administrator administrator = new Administrator();
            administrator.Show();
            

        }

        //to display Librarian form
        private void BtnLibrarian_Click(object sender, EventArgs e)
        {
            Librarian librarian = new Librarian();
            librarian.Show();
        }

        private void CmbMember_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        //displays member form depending on the username and password
        private void LblSignin_Click(object sender, EventArgs e)
        {
           

            string username = txtUsername.Text;
            string password = txtPassword.Text;
            
            //check for empty fields
            if ((username == "") || (password == ""))
            {
                MessageBox.Show("Fileds cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    conn.ConnectionString = connString;
                    cmd = conn.CreateCommand();
                    string id;
                    string query = "select * from Members where Username='"+username+"'and Password='"+password+"'";
                    cmd.CommandText = query;
                    conn.Open();
                   // cmd.ExecuteNonQuery();
                    LoginInfo.Username = txtUsername.Text;
                    SqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        id = reader["UserId"].ToString();
                        LoginInfo.id = id;
                    }
                   
                   
                    Member member = new Member();
                    member.Show();
                    
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
        }
    }
}
