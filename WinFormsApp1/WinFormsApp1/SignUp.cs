using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projects\BookShop\BookStore\BookStore\BookStoreDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string gmail = textBox2.Text;
            string password = textBox3.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(gmail) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                con.Open();
                string query = "INSERT INTO [dbo].[User](Username, gmail, password) VALUES (@Username, @Gmail, @Password)";

                // Use Microsoft.Data.SqlClient.SqlCommand explicitly
                using (Microsoft.Data.SqlClient.SqlCommand cmd = new Microsoft.Data.SqlClient.SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Gmail", gmail);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Sign up successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Clear the text fields or navigate to another form
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Sign up failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ensure the connection is closed even if an exception occurs
                con.Close();
            }
        }
    }
}
