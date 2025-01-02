using System;
using System.Data;
using System.Drawing;
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
            int userId = GlobalVariables.UserId;
            LoadBooks(null);
        }

        private void LoadBooks(string searchTerm)
        {
            string query = "SELECT Bookname, Bookcover FROM Books";
            if (!string.IsNullOrEmpty(searchTerm))
            {
                query += " WHERE Bookname LIKE @searchTerm";
            }

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable booksTable = new DataTable();
                adapter.Fill(booksTable);

                // Clear existing controls
                panel3.Controls.Clear();

                // Initial positions for the first row of books
                int initialX = 100; // X position for the first column
                int initialY = 50; // Y position for the first row
                int xOffset = 200; // Horizontal space between books
                int yOffset = 300; // Vertical space between rows

                int currentX = initialX;
                int currentY = initialY;
                int booksInRow = 0;

                foreach (DataRow row in booksTable.Rows)
                {
                    // Create and configure PictureBox for book cover
                    PictureBox bookPicture = new PictureBox
                    {
                        Location = new Point(currentX, currentY),
                        Width = 150,
                        Height = 200,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Tag = row["Bookname"].ToString() // Store book name in the Tag property
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

                    // Add Click event handler for the book cover image
                    bookPicture.Click += new EventHandler(BookPicture_Click);

                    // Create and configure Label for book title
                    Label bookLabel = new Label
                    {
                        Text = row["Bookname"].ToString(),
                        Location = new Point(currentX, currentY + 210), // Position below the book cover
                        Width = 150,
                        Height = 60,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        TextAlign = ContentAlignment.MiddleCenter
                    };

                    // Add the controls to the panel
                    panel3.Controls.Add(bookPicture);
                    panel3.Controls.Add(bookLabel);

                    // Update X position for the next book
                    booksInRow++;
                    if (booksInRow < 3)
                    {
                        currentX += xOffset; // Move to the next column
                    }
                    else
                    {
                        // Move to the next row
                        currentX = initialX;
                        currentY += yOffset;
                        booksInRow = 0;
                    }
                }
            }
        }
        private void AddToCart(int userId, int bookId, int quantity)
        {
            string insertQuery = "INSERT INTO Cart (UserId, BookId, Quantity) VALUES (@userId, @bookId, @quantity)";
            using (SqlCommand cmd = new SqlCommand(insertQuery, con))
            {
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@bookId", bookId);
                cmd.Parameters.AddWithValue("@quantity", quantity);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        private void BookPicture_Click(object sender, EventArgs e)
        {
            PictureBox bookPicture = sender as PictureBox;
            if (bookPicture != null)
            {
                // Get the book name from the clicked picture's tag
                string bookName = bookPicture.Tag.ToString();

                // Query the database for the selected book's details
                string query = "SELECT Id,Bookname, Bookcover, Bookauthor,Quantity, Price FROM Books WHERE Bookname = @bookName";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@bookName", bookName);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable bookDetails = new DataTable();
                    adapter.Fill(bookDetails);

                    if (bookDetails.Rows.Count > 0)
                    {
                        // Get the first row (since Bookname is unique)
                        DataRow row = bookDetails.Rows[0];

                        // Clear previous details in panel5 (if any)
                        panel5.Controls.Clear();
                        panel3.Controls.Clear();

                        // Display the book cover
                        PictureBox pic = new PictureBox
                        {
                            Location = new Point(176, 29),
                            Width = 378,
                            Height = 375,
                            SizeMode = PictureBoxSizeMode.Zoom,
                            Image = Image.FromFile(row["Bookcover"].ToString()) // Load the book cover image
                        };

                        // Display the book name
                        Label nameLabel = new Label
                        {
                            Text = "Book: " + row["Bookname"].ToString(),
                            Location = new Point(260, 420),
                            Width = 500,
                            Height = 30,
                            Font = new Font("Arial", 14, FontStyle.Bold),
                            TextAlign = ContentAlignment.MiddleLeft
                        };

                        // Display the author's name
                        Label authorLabel = new Label
                        {
                            Text = "Author: " + row["Bookauthor"].ToString(),
                            Location = new Point(260, 460),
                            Width = 300,
                            Height = 30,
                            Font = new Font("Arial", 12),
                            TextAlign = ContentAlignment.MiddleLeft
                        };

                        // Display the price
                        Label priceLabel = new Label
                        {
                            Text = "Price: $" + row["Price"].ToString(),
                            Location = new Point(260, 500),
                            Width = 300,
                            Height = 30,
                            Font = new Font("Arial", 12),
                            TextAlign = ContentAlignment.MiddleLeft
                        };

                        // Quantity selection control
                        Label quantityLabel = new Label
                        {
                            Text = "Quantity:",
                            Location = new Point(260, 540),
                            Width = 100,
                            Height = 30,
                            Font = new Font("Arial", 12),
                            TextAlign = ContentAlignment.MiddleLeft
                        };

                        NumericUpDown quantitySelector = new NumericUpDown
                        {
                            Location = new Point(360, 540),
                            Width = 60,
                            Minimum = 1,
                            Maximum = 100,
                            Value = 1
                        };

                        // Add to Cart button
                        Button addToCartButton = new Button
                        {
                            Text = "Add to Cart",
                            Location = new Point(280, 580),
                            Width = 150,
                            Height = 40,
                            Font = new Font("Arial", 12),
                            BackColor = System.Drawing.Color.FromArgb(100, 151, 177)
                        };

                        addToCartButton.Click += (sender, e) =>
                        {
                            int quantity = (int)quantitySelector.Value;
                            if (quantity > (Convert.ToInt64(row["Quantity"])))
                            {
                                MessageBox.Show($"Sorry,{quantity} items of '{bookName}' are not available in stock.");
                            }
                            else
                            {
                                //int userid = userId // Implement this method based on your authentication logic
                                int bookId = Convert.ToInt32(row["Id"]);
                                int userId = GlobalVariables.UserId;

                                AddToCart(userId, bookId, quantity);
                                MessageBox.Show($"{bookName} added to cart with quantity {quantity}.");
                            }
                            // Logic for adding the book to the cart goes here

                        };

                        // Add the controls to panel5
                        panel3.Controls.Add(pic);
                        panel3.Controls.Add(nameLabel);
                        panel3.Controls.Add(authorLabel);
                        panel3.Controls.Add(priceLabel);
                        panel3.Controls.Add(quantityLabel);
                        panel3.Controls.Add(quantitySelector);
                        panel3.Controls.Add(addToCartButton);
                    }
                    else
                    {
                        MessageBox.Show("Book details not found.");
                    }
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
            panel3.Controls.Clear();
            panel5.Controls.Clear();
            TextBox textBox1 = new TextBox()
            {
                Location=new Point(189, 20),
                Width= 289,
                Height=31,
                PlaceholderText= "Search yout Favourite Book"
            };
            Button button2 = new Button
            {
                Text="search",
                Location=new Point(540, 20),
                Width= 87,
                Height = 33,
                BackColor=Color.FromArgb(100, 151, 177)
            };
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(button2);
            LoadBooks(null);
            button2.Click += (sender, e) =>
            {
                string searchTerm = textBox1.Text;
                LoadBooks(searchTerm);
            };

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string searchTerm = textBox1.Text;
            LoadBooks(searchTerm);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            panel5.Controls.Clear();
            int userId = GlobalVariables.UserId;
            string query = "SELECT Books.Bookname, Books.Bookcover, Books.Bookauthor, Books.Price, Cart.Quantity, Cart.BookId " +
                           "FROM Cart " +
                           "INNER JOIN Books ON Cart.BookId = Books.Id " +
                           "WHERE Cart.UserId = @userId";

    using (SqlCommand cmd = new SqlCommand(query, con))
    {
        cmd.Parameters.AddWithValue("@userId", userId);

        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        DataTable cartTable = new DataTable();
        adapter.Fill(cartTable);

        // Initial positions for the first row of books
        int initialX = 50; // X position for the first column
        int initialY = 50; // Y position for the first row
        int xOffset = 250; // Horizontal space between books
        int yOffset = 300; // Vertical space between rows

        int currentX = initialX;
        int currentY = initialY;
        int booksInRow = 0;
        int count = 0;
        int totalPrice = 0;

        foreach (DataRow row in cartTable.Rows)
        {
            // Create and configure PictureBox for book cover
            PictureBox bookPicture = new PictureBox
            {
                Location = new Point(currentX, currentY),
                Width = 150,
                Height = 200,
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

            count += 1;
            totalPrice += Convert.ToInt16(row["Price"]);

            // Create and configure Label for book title
            Label bookLabel = new Label
            {
                Text = row["Bookname"].ToString(),
                Location = new Point(currentX, currentY + 210), // Position below the book cover
                Width = 250,
                Height = 60,
                Font = new Font("Arial", 12, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Display the author's name
            Label authorLabel = new Label
            {
                Text = "Author: " + row["Bookauthor"].ToString(),
                Location = new Point(currentX, currentY + 270), // Position below the book title
                Width = 250,
                Height = 30,
                Font = new Font("Arial", 10),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Display the price
            Label priceLabel = new Label
            {
                Text = "Price: $" + row["Price"].ToString(),
                Location = new Point(currentX, currentY + 300), // Position below the author name
                Width = 250,
                Height = 30,
                Font = new Font("Arial", 10),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Display the quantity
            Label quantityLabel = new Label
            {
                Text = "Quantity: " + row["Quantity"].ToString(),
                Location = new Point(currentX, currentY + 330), // Position below the price
                Width = 250,
                Height = 30,
                Font = new Font("Arial", 10),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Add the controls to the panel
            panel3.Controls.Add(bookPicture);
            panel3.Controls.Add(bookLabel);
            panel3.Controls.Add(authorLabel);
            panel3.Controls.Add(priceLabel);
            panel3.Controls.Add(quantityLabel);

            // Update X position for the next book
            booksInRow++;
            if (booksInRow < 3)
            {
                currentX += xOffset; // Move to the next column
            }
            else
            {
                // Move to the next row
                currentX = initialX;
                currentY += yOffset;
                booksInRow = 0;
            }
        }

        // Display checkout details
        int currX = initialX;
        int currY = currentY + yOffset + 100;

        Label l1 = new Label
        {
            Text = "Checkout Details.",
            Location = new Point(currX + 100, currY),
            Width = 200,
            Height = 50,
            Font = new Font("Arial", 14, FontStyle.Bold),
            TextAlign = ContentAlignment.MiddleCenter
        };
        currY += 60;

        Label l2 = new Label
        {
            Text = "Total number of Books: " + count,
            Location = new Point(currX, currY),
            Width = 500,
            Height = 50,
            Font = new Font("Arial", 14, FontStyle.Bold),
            TextAlign = ContentAlignment.MiddleCenter
        };
        currY += 60;

        Label l3 = new Label
        {
            Text = "Total Price: $" + totalPrice,
            Location = new Point(currX, currY),
            Width = 500,
            Height = 50,
            Font = new Font("Arial", 14, FontStyle.Bold),
            TextAlign = ContentAlignment.MiddleCenter
        };
        currY += 60;

        Button checkoutButton = new Button
        {
            Text = "Checkout",
            Location = new Point(currX + 150, currY),
            Width = 150,
            Height = 40,
            Font = new Font("Arial", 12),
            BackColor = Color.FromArgb(100, 151, 177)
        };

        checkoutButton.Click += (sender, e) =>
        {
            Checkout(userId, cartTable);
        };

        panel3.Controls.Add(l1);
        panel3.Controls.Add(l2);
        panel3.Controls.Add(l3);
        panel3.Controls.Add(checkoutButton);
    }
}

        private void Checkout(int userId, DataTable cartTable)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = con;
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();
                cmd.Transaction = transaction;

                try
                {
                    foreach (DataRow row in cartTable.Rows)
                    {
                        int bookId = Convert.ToInt32(row["BookId"]);
                        int quantity = Convert.ToInt32(row["Quantity"]);

                        // Insert into Orders table
                        cmd.CommandText = "INSERT INTO Orders (UserId, BookId, Quantity) VALUES (@userId, @bookId, @quantity)";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@bookId", bookId);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.ExecuteNonQuery();

                        // Update Books table
                        cmd.CommandText = "UPDATE Books SET Quantity = Quantity - @quantity WHERE Id = @bookId";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@bookId", bookId);
                        cmd.ExecuteNonQuery();

                        // Check if the quantity is 0 after the update
                        cmd.CommandText = "SELECT Quantity FROM Books WHERE Id = @bookId";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@bookId", bookId);
                        int updatedQuantity = (int)cmd.ExecuteScalar();

                        // If quantity is 0, delete the book
                        if (updatedQuantity == 0)
                        {
                            cmd.CommandText = "DELETE FROM Books WHERE Id = @bookId";
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@bookId", bookId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Clear Cart table
                    cmd.CommandText = "DELETE FROM Cart WHERE UserId = @userId";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Checkout successful! Your order has been placed.");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Checkout failed: {ex.Message}");
                }
                finally
                {
                    con.Close();
                }
            }
        }


    }
}
