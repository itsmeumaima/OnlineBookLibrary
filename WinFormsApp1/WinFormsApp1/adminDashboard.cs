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
    public partial class adminDashboard : Form
    {
        public adminDashboard()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projects\BookShop\BookStore\BookStore\BookStoreDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");


        private void adminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //this.Close();
            //Form1 form = new Form1();
            //form.ShowDialog();
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text;
            string author = textBox2.Text;
            int quantity = int.Parse(textBox3.Text);
            int price = int.Parse(textBox4.Text);
            string bookCoverLink = textBox5.Text;

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author) || quantity <= 0 || price <= 0 || string.IsNullOrWhiteSpace(bookCoverLink))
            {
                MessageBox.Show("Please fill in all fields with valid values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                con.Open();
                string query = "INSERT INTO Books (Bookname, Bookauthor, Quantity, Price, Bookcover) VALUES (@Bookname, @Bookauthor, @Quantity, @Price, @Bookcover)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Bookname", title);
                cmd.Parameters.AddWithValue("@Bookauthor", author);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Bookcover", bookCoverLink);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Optionally, clear the input fields after a successful insert
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                }
                else
                {
                    MessageBox.Show("Failed to add the book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button2_Click(object sender, EventArgs e)
        {
            //delete del = new delete();
            //del.ShowDialog();
            //this.Close();
            this.Close();
            delete del = new delete();
            del.Show();

        }

        private void adminDashboard_Load_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            update up = new update();
            up.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            userdetails us = new userdetails();
            us.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
