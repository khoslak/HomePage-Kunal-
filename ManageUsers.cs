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
using System.Text.RegularExpressions;

namespace Homepage
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        private SqlConnection conn = new SqlConnection();
        private string conString = "Server=Laptop-TBE3GK6p\\SQLEXPRESS01; " +
                            "Database=Library; User=kaur4542; Password=JKhrt956";
        private SqlCommand cmd;


        private void RefreshOnFormLoad()
        {



            conn.ConnectionString = conString;

            cmd = conn.CreateCommand();

            try
            {
                string query = "Select * from Members;";

                //ComamndText is specifying the SQL query to Comamnd Object
                cmd.CommandText = query;

                //To execute the Query first need to Open the connection
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                //DataTable acts as the bridge between DataReader and DataGridView
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView2.DataSource = dt;


                cmbUserID.DisplayMember = "UserName";
                cmbUserID.ValueMember = "UserID";
                cmbUserID.DataSource = dt;

                //Close the Data Reader Object
                reader.Close();



            }
            catch (Exception ex)
            {
                string message = ex.Message.ToString();
                string caption = "Error!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private string ValidateandGenerateInsert(string type)
        {
            string q = "";
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string booklimit = txtLimits.Text;
            string a = null;
            string b = null;
            string c = null;



            if ((username == "") || (password == "") || (booklimit == ""))
            {
                MessageBox.Show("Fill Out the Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                if (type.Contains("Insert"))
                {
                    q = "Insert into Members Values('" + username + "','" + password + "','" + booklimit + "','" + a + "','" + b + "','" + c + "');";
                    MessageBox.Show("Insert sucessful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Never", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            return q;
        }


        private string ValidateandGenerateUpdate(string type)
        {
            string q = "";

            string username1 = txtUsername.Text;
            string password1 = txtPassword.Text;
            string booklimit1 = txtLimits.Text;
            string aa = null;
            int bb = 0;
            string cc = null;


            int uID = Convert.ToInt32(cmbUserID.SelectedValue);



            if ((username1 == "") || (password1 == "") || (booklimit1 == ""))
            {
                MessageBox.Show("Fill Out the Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {

                if (type.Contains("Update"))
                {
                    q = "Update Members Set UserName='" + username1 + "', Password='" + password1 + "', BookLimit='" + booklimit1 + "', ImageLoc='" + aa + "', phoneNumber='" + bb + "', emailAddress='" + cc + "' where UserID= " + uID;
                    MessageBox.Show("Update Sucessful ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Never", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            return q;
        }





        private void InsertandUpdateConn(string query)
        {
            try
            {
                conn.ConnectionString = conString;
                cmd = conn.CreateCommand();


                cmd.CommandText = query;
                conn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                string message = ex.Message.ToString();
                string caption = "Error!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string query = ValidateandGenerateInsert("Insert");
            InsertandUpdateConn(query);
            RefreshOnFormLoad();

        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            RefreshOnFormLoad();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            string query = ValidateandGenerateUpdate("Update");
            InsertandUpdateConn(query);
            RefreshOnFormLoad();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = conString;

            cmd = conn.CreateCommand();

            try
            {
                string query = "Select * from Members;";

                //ComamndText is specifying the SQL query to Comamnd Object
                cmd.CommandText = query;

                //To execute the Query first need to Open the connection
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                //DataTable acts as the bridge between DataReader and DataGridView
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;


                cmbMember.DisplayMember = "UserName";
                cmbMember.ValueMember = "UserID";
                cmbMember.DataSource = dt;

                //Close the Data Reader Object
                reader.Close();



            }
            catch (Exception ex)
            {
                string message = ex.Message.ToString();
                string caption = "Error!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Button1_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = conString;
            cmd = conn.CreateCommand();

            int uID = Convert.ToInt32(cmbMember.SelectedValue);

            string bookissued = "Select Status from Members_Book where Member_Book_ID = " + uID;
            cmd.CommandText = bookissued;

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Close();





            try
            {

                if (bookissued == "Issued")
                {
                    string message = "Sorry Cannot Delete Account Please Return book";
                    string caption = "Error!";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    string query2 = "Delete from Members_Book where UserID = " + uID;
                    cmd.CommandText = query2;
                    cmd.ExecuteNonQuery();
                    string query = "Delete from Members where UserID = " + uID;
                    cmd.CommandText = query;
                    string message = "Account Deleted";
                    string caption = "Info!";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // conn.Open();
                    //Execute the query
                    cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message.ToString();
                string caption = "Error!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
                RefreshOnFormLoad();
            }
        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
