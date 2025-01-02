using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class delete : Form
    {
        public delete()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projects\BookShop\BookStore\BookStore\BookStoreDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");

        private void delete_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text;
            string author = textBox2.Text;

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author))
            {
                MessageBox.Show("Please enter a title and author to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                con.Open();
                string query = "DELETE FROM Books WHERE Bookname = @Bookname AND Bookauthor = @Bookauthor";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Bookname", title);
                cmd.Parameters.AddWithValue("@Bookauthor", author);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Book deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Optionally, clear the input fields after a successful delete
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    MessageBox.Show("No book found with the given title and author.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            adminDashboard form = new adminDashboard();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
     
            //this.Close();
            //update up = new update();
            //up.Show();
            this.Close();
            update up = new update();
            up.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //userdetails us = new userdetails();
            //us.ShowDialog();
            //this.Close();
            this.Close();
            userdetails us = new userdetails();
            us.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

