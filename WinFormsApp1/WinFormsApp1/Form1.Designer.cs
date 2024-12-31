namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(62, 123, 184);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(59, 424);
            button1.Name = "button1";
            button1.Size = new Size(144, 46);
            button1.TabIndex = 3;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(23, 73, 122);
            pictureBox1.Image = Properties.Resources.rb_23421;
            pictureBox1.Location = new Point(516, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(473, 580);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(62, 123, 184);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(248, 424);
            button2.Name = "button2";
            button2.Size = new Size(144, 46);
            button2.TabIndex = 5;
            button2.Text = "Sign up";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(62, 123, 184);
            label1.Location = new Point(59, 82);
            label1.Name = "label1";
            label1.Size = new Size(280, 55);
            label1.TabIndex = 6;
            label1.Text = "Online Book";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(62, 123, 184);
            label2.Location = new Point(74, 166);
            label2.Name = "label2";
            label2.Size = new Size(186, 55);
            label2.TabIndex = 7;
            label2.Text = "Library";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            label3.Location = new Point(74, 260);
            label3.Name = "label3";
            label3.Size = new Size(318, 28);
            label3.TabIndex = 8;
            label3.Text = "Explore our vast collection of books";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            label4.Location = new Point(74, 288);
            label4.Name = "label4";
            label4.Size = new Size(339, 28);
            label4.TabIndex = 9;
            label4.Text = "across all genres. Whether you're into";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            label5.Location = new Point(74, 316);
            label5.Name = "label5";
            label5.Size = new Size(349, 28);
            label5.TabIndex = 10;
            label5.Text = "romance, mystery, sci-fi, or non-fiction,";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            label6.Location = new Point(74, 344);
            label6.Name = "label6";
            label6.Size = new Size(297, 28);
            label6.TabIndex = 11;
            label6.Text = "we have something for everyone.";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(23, 73, 122);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(600, 23);
            button3.Name = "button3";
            button3.Size = new Size(282, 34);
            button3.TabIndex = 12;
            button3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(991, 577);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button3;
    }
}
