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

    public partial class ViewAccountMember : Form
    {
        public ViewAccountMember()
        {
            InitializeComponent();
        }

        private SqlConnection conn = new SqlConnection();
        private string connString = "Server=Laptop-TBE3GK6p\\SQLEXPRESS01; " +
                            "Database=Library; User=kaur4542; Password=JKhrt956";
        private SqlCommand cmd;
        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        public void refreshAccountMember()
        {
            conn.ConnectionString = connString;
            cmd = conn.CreateCommand();
            try
            {
                String query = "SELECT * FROM Members WHERE USERID=" + LoginInfo.id;
                cmd.CommandText = query;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                txtUserId.Text = reader[0].ToString();
                txtUserName.Text = reader[1].ToString();
                txtUserPassword.Text = reader[2].ToString();
                if (reader[5].ToString().Equals("NULL"))
                {
                    txtPhoneNumber.Text = "";
                }
                else
                {
                    txtPhoneNumber.Text = reader[5].ToString();
                }
                if (reader[6].ToString().Equals("NULL"))
                {

                    txtEmailAddress.Text = "";
                }
                else
                {
                    txtEmailAddress.Text = reader[6].ToString();
                }

                reader.Close();

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
        private void BtnChange_Click(object sender, EventArgs e)
        {
            if (txtPass1.Text == "" || txtPass2.Text == " ")
            {
                MessageBox.Show("FIELDS CANNOT BE EMPTY !");
            }
            else if (txtPass1.Text.Equals(txtPass2.Text) == false)
            {
                MessageBox.Show("PASSWORD DOES NOT MATCH !");

            }
            else
            {
                conn.ConnectionString = connString;
                cmd = conn.CreateCommand();
                try
                {
                    String query = "UPDATE Members SET Password='" + txtPass1.Text + "' WHERE USERID=" + LoginInfo.id + ";";
                    cmd.CommandText = query;
                    conn.Open();
                    cmd.ExecuteNonQuery();

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
                    refreshAccountMember();
                }
            }
        }

        private void ViewAccountMember_Load(object sender, EventArgs e)
        {
            refreshAccountMember();
        }
    }
}