namespace WinFormsApp1
{
    partial class userDashboard
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
            button1 = new Button();
            panel2 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            panel3 = new Panel();
            button2 = new Button();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(23, 73, 122);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(271, 728);
            panel1.TabIndex = 0;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(100, 151, 177);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(42, 341);
            button5.Name = "button5";
            button5.Size = new Size(177, 43);
            button5.TabIndex = 4;
            button5.Text = "Logout";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(100, 151, 177);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(42, 240);
            button4.Name = "button4";
            button4.Size = new Size(177, 43);
            button4.TabIndex = 3;
            button4.Text = "Books";
            button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(100, 151, 177);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(42, 133);
            button1.Name = "button1";
            button1.Size = new Size(177, 43);
            button1.TabIndex = 0;
            button1.Text = "Cart";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(23, 73, 122);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(5, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1067, 98);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(337, 24);
            label1.Name = "label1";
            label1.Size = new Size(415, 51);
            label1.TabIndex = 0;
            label1.Text = "Online Book Library";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(189, 20);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search yout Favourite Book";
            textBox1.Size = new Size(289, 31);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.AutoScroll = true;
            panel3.BackColor = Color.White;
            panel3.Location = new Point(272, 161);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 569);
            panel3.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(100, 151, 177);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(540, 20);
            button2.Name = "button2";
            button2.Size = new Size(87, 33);
            button2.TabIndex = 0;
            button2.Text = "search";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(button2);
            panel5.Controls.Add(textBox1);
            panel5.Location = new Point(279, 102);
            panel5.Name = "panel5";
            panel5.Size = new Size(790, 62);
            panel5.TabIndex = 3;
            // 
            // userDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1072, 733);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "userDashboard";
            Text = "userDashboard";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Button button5;
        private Button button4;
        private Panel panel3;
        private Button button2;
        private Panel panel5;
    }
}