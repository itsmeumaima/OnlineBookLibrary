using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projects\BookShop\BookStore\BookStore\BookStoreDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");

        private void login_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("User");
            comboBox1.SelectedIndex = 0; // Set default selection
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedUserType = comboBox1.SelectedItem.ToString();
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                con.Open();

                string query = selectedUserType == "Admin"
                    ? "SELECT COUNT(1) FROM Admin WHERE Username=@Username AND Password=@password"
                    : "SELECT COUNT(1) FROM [User] WHERE Username=@Username AND Password=@password";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@password", password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 1)
                {
                    MessageBox.Show($"Welcome, {username}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (selectedUserType == "Admin")
                    {
                        adminDashboard admin = new adminDashboard();
                        admin.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        userDashboard userdas=new userDashboard();
                        userdas.ShowDialog();
                        this.Close();
                    }
                    // Open the next form based on user type
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void label2_Click(object sender, EventArgs e)
        {
            // Event handler for label click (if needed)
        }
    }
}
