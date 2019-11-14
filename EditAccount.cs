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
    public partial class EditAccount : Form
    {
        public EditAccount()
        {
            InitializeComponent();
        }

        private SqlConnection conn = new SqlConnection();
        private string connString = "Server=Laptop-TBE3GK6p\\SQLEXPRESS01; " +
                            "Database=Library; User=kaur4542; Password=JKhrt956";
        private SqlCommand cmd;
        private void EditAccount_Load(object sender, EventArgs e)
        {

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            if (txtEmail.Text == " " || txtPhone.Text == "")
            {
                MessageBox.Show("Fields Cannot be empty !");
            }
            else
            {
                conn.ConnectionString = connString;
                cmd = conn.CreateCommand();
                try
                {
                    String query = "UPDATE Members SET phoneNumber='" + txtPhone.Text + "', emailAddress='" + txtEmail.Text + "' WHERE USERID=" + LoginInfo.id;
                    cmd.CommandText = query;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("PHONE NUMBER AND EMAIL ADDRESS UPDATED !");
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
                    this.Close();
                }
            }
        }
    }
}