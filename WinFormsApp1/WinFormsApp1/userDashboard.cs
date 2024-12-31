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
    public partial class userDashboard : Form
    {
        public userDashboard()
        {
            InitializeComponent();
            this.Load += new EventHandler(userDashboard_Load); 
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projects\BookShop\BookStore\BookStore\BookStoreDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
        private void userDashboard_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }
        private void LoadBooks()
        {
            string query = "SELECT TOP 2 Bookname, Bookcover FROM Books";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable booksTable = new DataTable();
                adapter.Fill(booksTable);

                // Loop through each book and display in the dashboard
                int yOffset = 100; // Initial Y position for the first row of books
                foreach (DataRow row in booksTable.Rows)
                {
                    // Create and configure PictureBox for book cover
                    PictureBox bookPicture = new PictureBox
                    {
                        Location = new Point(300, yOffset),
                        Width = 100,
                        Height = 150,
                        SizeMode = PictureBoxSizeMode.Zoom
                    };

                    // Load the book cover image from file path or URL
                    string coverImagePath = row["Bookcover"].ToString();
                    if (!string.IsNullOrEmpty(coverImagePath))
                    {
                        try
                        {
                            bookPicture.Image = Image.FromFile(coverImagePath);
                        }
                        catch (Exception ex)
                        {
                            // Handle exception if image loading fails
                            MessageBox.Show($"Error loading image: {ex.Message}");
                        }
                    }

                    // Create and configure Label for book title
                    Label bookLabel = new Label
                    {
                        Text = row["Bookname"].ToString(),
                        Location = new Point(300, yOffset + 160), // Position below the book cover
                        Width = 200,
                        Font = new Font("Arial", 12, FontStyle.Bold)
                    };

                    // Add the controls to the form
                    this.Controls.Add(bookPicture);
                    this.Controls.Add(bookLabel);

                    // Update Y position for the next book
                    yOffset += 200; // Adjust space between books as needed
                }
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
