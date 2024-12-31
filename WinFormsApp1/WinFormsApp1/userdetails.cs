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
    public partial class userdetails : Form
    {
        public userdetails()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projects\BookShop\BookStore\BookStore\BookStoreDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");


        private void button1_Click(object sender, EventArgs e)
        {
            adminDashboard ad = new adminDashboard();
            ad.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            update up = new update();
            up.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            delete del = new delete();
            del.ShowDialog();
            this.Close();
        }

        private void userdetails_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }
        private void LoadUsers()
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM [User]";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
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
    }
}
