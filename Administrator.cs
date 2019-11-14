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
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private SqlConnection conn = new SqlConnection();
        private string connString = "Server=Laptop-TBE3GK6p\\SQLEXPRESS01; " +
                            "Database=Library; User=kaur4542; Password=JKhrt956";
        private SqlCommand cmd;
        private void Form1_Load(object sender, EventArgs e)
        {
            
           
        }
       
        private void LblAuthor_Click(object sender, EventArgs e)
        {

        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnManageUsers_Click(object sender, EventArgs e)
        {
            ManageUsers manageUsers = new ManageUsers();
            manageUsers.Show();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            String i_isbn = txtIsbn.Text;
            String title = txtBookName.Text;
            String author = txtAuthor.Text;
            String publisher = txtPublisher.Text;
            String category = txtCategory.Text;
            String copies = txtCopies.Text;
            conn.ConnectionString = connString;
            cmd = conn.CreateCommand();
            try
            {
                if (!isEmpty(i_isbn) && !isEmpty(title) && !isEmpty(author) && !isEmpty(publisher) && !isEmpty(category) && !isEmpty(copies))
                {
                    if (isValidText(title) && isValidText(author) && isValidText(publisher) && isValidText(category) && isValidNumber(i_isbn) && isValidNumber(copies))
                    {
                        int isbn = Convert.ToInt32(i_isbn);
                        int copiesAvailable = Convert.ToInt32(copies);
                        String query = "INSERT INTO Books VALUES(" + isbn + ",'" + title + "','" + author + "','" + category + "','" + publisher + "'," + copies + ");";
                        cmd.CommandText = query;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("BOOK ADDED !");

                    }
                }
            }
            catch (EmptyFieldException ef)
            {
                MessageBox.Show("Empty Fields");


            }
            catch (ValidTextException ef)
            {
                MessageBox.Show("NOT A VALID TEXT");
            }
            catch (FormatException ef)
            {
                MessageBox.Show("Not a proper number");
            }
            catch (SqlException ef)
            {
                MessageBox.Show("SQL COULD NOT ESTABLISH CONNECTION");
            }
            finally
            {

                cmd.Dispose();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                LoadTable();
            }
            ClearField();
        }

        public void ClearField()
        {
            txtIsbn.Clear();
            txtAuthor.Clear();
            txtBookName.Clear();
            txtCategory.Clear();
            txtCopies.Clear();
            txtPublisher.Clear();


        }
        public void LoadTable()
        {
            conn.ConnectionString = connString;
            cmd = conn.CreateCommand();
            try
            {
                String query = "SELECT * FROM Books";
                cmd.CommandText = query;
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dr.Close();
                cmbSelectBook.DataSource = dt;
                cmbSelectBook.DisplayMember = "Title";
                cmbSelectBook.ValueMember = "ISBN_No";
                dataGridView1.DataSource = dt;
            }
            catch (Exception ef)
            {
                MessageBox.Show("Sql Connection cannot established !", DateTime.Now.ToLongDateString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        public bool isEmpty(String text)
        {
            if (String.IsNullOrEmpty(text))
                throw new EmptyFieldException();
            else
                return false;
        }
        public bool isValidText(String text)
        {
            if (Regex.IsMatch(text, "^[a-zA-Z][a-zA-Z]*$"))
            {
                return true;
            }
            else
            {
                throw new ValidTextException();
            }
        }

        public bool isValidNumber(String text)
        {
            if (Regex.IsMatch(text, "[0-9]+"))
            {
                return true;
            }
            else
            {
                throw new FormatException();
            }
        }

        

       

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            String i_isbn = txtIsbn.Text;
            String title = txtBookName.Text;
            String author = txtAuthor.Text;
            String publisher = txtPublisher.Text;
            String category = txtCategory.Text;
            String copies = txtCopies.Text;
            int userSelect = Convert.ToInt32(cmbSelectBook.SelectedValue);
            conn.ConnectionString = connString;
            cmd = conn.CreateCommand();
            try
            {
                if (!isEmpty(i_isbn) && !isEmpty(title) && !isEmpty(author) && !isEmpty(publisher) && !isEmpty(category) && !isEmpty(copies))
                {
                    if (isValidText(title) && isValidText(author) && isValidText(publisher) && isValidText(category) && isValidNumber(i_isbn) && isValidNumber(copies))
                    {
                        int isbn = Convert.ToInt32(i_isbn);
                        int copiesAvailable = Convert.ToInt32(copies);
                        String query = "UPDATE Books SET ISBN_No=" + isbn + ", Title='" + title + "',Author='" + author + "',Category='" + category + "',Publisher='" + publisher + "',Copies_Available=" + copiesAvailable + " WHERE ISBN_No=" + userSelect + ";";
                        conn.Open();
                        cmd.CommandText = query;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("BOOK Edited !");

                    }
                }
            }
            catch (EmptyFieldException ef)
            {
                MessageBox.Show("Empty Fields");


            }
            catch (ValidTextException ef)
            {
                MessageBox.Show("NOT A VALID TEXT");
            }
            catch (FormatException ef)
            {
                MessageBox.Show("Not a proper number");
            }
            catch (SqlException ef)
            {
                MessageBox.Show("SQL COULD NOT ESTABLISH CONNECTION");
            }
            finally
            {

                cmd.Dispose();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                LoadTable();
            }
            ClearField();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int userSelect = Convert.ToInt32(cmbSelectBook.SelectedValue);
            conn.ConnectionString = connString;
            cmd = conn.CreateCommand();
            try
            {


                String query = "DELETE FROM  Books WHERE ISBN_No=" + userSelect + ";";
                conn.Open();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("BOOK Deleted !");


            }
            catch (EmptyFieldException ef)
            {
                MessageBox.Show("Empty Fields");


            }
            catch (ValidTextException ef)
            {
                MessageBox.Show("NOT A VALID TEXT");
            }
            catch (FormatException ef)
            {
                MessageBox.Show("Not a proper number");
            }
            catch (SqlException ef)
            {
                MessageBox.Show("SQL COULD NOT ESTABLISH CONNECTION");
            }
            finally
            {

                cmd.Dispose();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                LoadTable();
            }
            ClearField();
        }
    }
}

namespace Homepage
{
    class ValidTextException : Exception
    {
        public ValidTextException() : base()
        {

        }
        public ValidTextException(String message) : base(message)
        {

        }
    }
}

namespace Homepage
{
    class EmptyFieldException : Exception
    {
        public EmptyFieldException() : base()
        {

        }
        public EmptyFieldException(String message) : base(message)
        {

        }
    }
}

