namespace WinFormsApp1
{
    partial class userdetails
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
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(23, 73, 122);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(314, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(827, 126);
            panel2.TabIndex = 2;
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 73, 122);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 693);
            panel1.TabIndex = 3;
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
            button2.Click += button2_Click;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(384, 205);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(733, 453);
            dataGridView1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(540, 158);
            label5.Name = "label5";
            label5.Size = new Size(344, 32);
            label5.TabIndex = 6;
            label5.Text = "All the Users in the Library";
            // 
            // userdetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 695);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "userdetails";
            Text = "userdetails";
            Load += userdetails_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label5;
    }
}