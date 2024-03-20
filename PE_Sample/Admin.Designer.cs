namespace PresentationLayer
{
    partial class Admin
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
            btnMemberHome = new Button();
            label6 = new Label();
            label1 = new Label();
            button1 = new Button();
            panel2 = new Panel();
            TotalPet = new Label();
            panel3 = new Panel();
            totalMember = new Label();
            button2 = new Button();
            panel4 = new Panel();
            totalRevenue = new Label();
            button3 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnMemberHome);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(985, 100);
            panel1.TabIndex = 2;
            // 
            // btnMemberHome
            // 
            btnMemberHome.BackColor = Color.Black;
            btnMemberHome.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMemberHome.ForeColor = Color.White;
            btnMemberHome.Location = new Point(0, 65);
            btnMemberHome.Name = "btnMemberHome";
            btnMemberHome.Size = new Size(75, 35);
            btnMemberHome.TabIndex = 61;
            btnMemberHome.Text = "Home";
            btnMemberHome.UseVisualStyleBackColor = false;
            btnMemberHome.Click += btnMemberHome_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaptionText;
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(969, 0);
            label6.Name = "label6";
            label6.Size = new Size(16, 20);
            label6.TabIndex = 1;
            label6.Text = "x";
            label6.Click += label6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(294, 37);
            label1.Name = "label1";
            label1.Size = new Size(330, 39);
            label1.TabIndex = 0;
            label1.Text = "Manager CafeShop";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(-4, -3);
            button1.Name = "button1";
            button1.Size = new Size(209, 41);
            button1.TabIndex = 62;
            button1.Text = "Total Cafe";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(TotalPet);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(86, 229);
            panel2.Name = "panel2";
            panel2.Size = new Size(196, 150);
            panel2.TabIndex = 66;
            // 
            // TotalPet
            // 
            TotalPet.AutoSize = true;
            TotalPet.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TotalPet.Location = new Point(50, 58);
            TotalPet.Name = "TotalPet";
            TotalPet.Padding = new Padding(18, 20, 18, 20);
            TotalPet.Size = new Size(95, 65);
            TotalPet.TabIndex = 63;
            TotalPet.Text = "Total";
            TotalPet.Click += TotalPet_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveBorder;
            panel3.Controls.Add(totalMember);
            panel3.Controls.Add(button2);
            panel3.Location = new Point(351, 232);
            panel3.Name = "panel3";
            panel3.Size = new Size(196, 150);
            panel3.TabIndex = 67;
            // 
            // totalMember
            // 
            totalMember.AutoSize = true;
            totalMember.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            totalMember.Location = new Point(49, 55);
            totalMember.Name = "totalMember";
            totalMember.Padding = new Padding(18, 20, 18, 20);
            totalMember.Size = new Size(95, 65);
            totalMember.TabIndex = 64;
            totalMember.Text = "Total";
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(-4, -3);
            button2.Name = "button2";
            button2.Size = new Size(209, 41);
            button2.TabIndex = 62;
            button2.Text = "Total Member";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveBorder;
            panel4.Controls.Add(totalRevenue);
            panel4.Controls.Add(button3);
            panel4.Location = new Point(618, 235);
            panel4.Name = "panel4";
            panel4.Size = new Size(196, 150);
            panel4.TabIndex = 68;
            // 
            // totalRevenue
            // 
            totalRevenue.AutoSize = true;
            totalRevenue.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            totalRevenue.Location = new Point(53, 52);
            totalRevenue.Name = "totalRevenue";
            totalRevenue.Padding = new Padding(18, 20, 18, 20);
            totalRevenue.Size = new Size(95, 65);
            totalRevenue.TabIndex = 64;
            totalRevenue.Text = "Total";
            totalRevenue.Click += totalRevenue_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(-4, -3);
            button3.Name = "button3";
            button3.Size = new Size(209, 41);
            button3.TabIndex = 62;
            button3.Text = "Total Revenue";
            button3.UseVisualStyleBackColor = false;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 580);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnMemberHome;
        private Label label6;
        private Label label1;
        private Button button1;
        private Panel panel2;
        private Label TotalPet;
        private Panel panel3;
        private Button button2;
        private Label totalMember;
        private Panel panel4;
        private Label totalRevenue;
        private Button button3;
    }
}