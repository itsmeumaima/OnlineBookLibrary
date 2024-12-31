//using Microsoft.Data.SqlClient;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projects\BookShop\BookStore\BookStore\BookStoreDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //this.Close();
                login log = new login();
                log.ShowDialog();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the SignUp form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                SignUp signup = new SignUp();
                signup.ShowDialog();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the SignUp form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
