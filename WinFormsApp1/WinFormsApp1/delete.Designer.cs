namespace WinFormsApp1
{
    partial class delete
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            button6 = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 73, 122);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 690);
            panel1.TabIndex = 0;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(100, 151, 177);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(66, 496);
            button5.Name = "button5";
            button5.Size = new Size(193, 37);
            button5.TabIndex = 9;
            button5.Text = "Logout";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(100, 151, 177);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(66, 410);
            button4.Name = "button4";
            button4.Size = new Size(193, 37);
            button4.TabIndex = 8;
            button4.Text = "Users";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(100, 151, 177);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(66, 331);
            button3.Name = "button3";
            button3.Size = new Size(193, 37);
            button3.TabIndex = 7;
            button3.Text = "Available Books";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(100, 151, 177);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(66, 248);
            button2.Name = "button2";
            button2.Size = new Size(193, 37);
            button2.TabIndex = 6;
            button2.Text = "Delete Book";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(100, 151, 177);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(66, 158);
            button1.Name = "button1";
            button1.Size = new Size(193, 37);
            button1.TabIndex = 5;
            button1.Text = "Add Book";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(23, 73, 122);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(320, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(827, 126);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(609, 65);
            label2.Name = "label2";
            label2.Size = new Size(171, 28);
            label2.TabIndex = 3;
            label2.Text = "Admin Dashboard";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(122, 47);
            label1.Name = "label1";
            label1.Size = new Size(415, 51);
            label1.TabIndex = 2;
            label1.Text = "Online Book Library";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(528, 196);
            label3.Name = "label3";
            label3.Size = new Size(449, 32);
            label3.TabIndex = 2;
            label3.Text = "Enter the detail of the book to Delete";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(398, 325);
            label4.Name = "label4";
            label4.Size = new Size(119, 26);
            label4.TabIndex = 3;
            label4.Text = "Book Title";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(637, 320);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 31);
            textBox1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(398, 413);
            label5.Name = "label5";
            label5.Size = new Size(144, 26);
            label5.TabIndex = 5;
            label5.Text = "Book Author";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(637, 413);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(202, 31);
            textBox2.TabIndex = 6;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(100, 151, 177);
            button6.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(657, 552);
            button6.Name = "button6";
            button6.Size = new Size(182, 48);
            button6.TabIndex = 7;
            button6.Text = "Delete";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1144, 695);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // delete
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 695);
            Controls.Add(button6);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "delete";
            Text = "delete";
            Load += delete_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private TextBox textBox2;
        private Button button6;
        private PictureBox pictureBox1;
    }
}