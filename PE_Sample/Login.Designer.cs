namespace PresentationLayer
{
    partial class Login
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
            btnLogin = new Button();
            showPassword = new CheckBox();
            passLogin = new TextBox();
            emailLogin = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(showPassword);
            panel1.Controls.Add(passLogin);
            panel1.Controls.Add(emailLogin);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(105, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(308, 304);
            panel1.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(73, 200);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(188, 49);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // showPassword
            // 
            showPassword.AutoSize = true;
            showPassword.BackColor = Color.White;
            showPassword.Location = new Point(99, 127);
            showPassword.Name = "showPassword";
            showPassword.Size = new Size(108, 19);
            showPassword.TabIndex = 9;
            showPassword.Text = "Show password";
            showPassword.UseVisualStyleBackColor = false;
            showPassword.CheckedChanged += showPassword_CheckedChanged;
            // 
            // passLogin
            // 
            passLogin.Location = new Point(99, 98);
            passLogin.Name = "passLogin";
            passLogin.Size = new Size(146, 23);
            passLogin.TabIndex = 8;
            // 
            // emailLogin
            // 
            emailLogin.Location = new Point(99, 58);
            emailLogin.Name = "emailLogin";
            emailLogin.Size = new Size(146, 23);
            emailLogin.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(29, 101);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 6;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(34, 61);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 5;
            label3.Text = "Account";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(178, 29);
            label1.Name = "label1";
            label1.Size = new Size(163, 30);
            label1.TabIndex = 4;
            label1.Text = "Login CafeShop";
            label1.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(523, 0);
            label5.MaximumSize = new Size(20, 20);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 11;
            label5.Text = "x";
            label5.Click += label5_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(536, 549);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Button btnLogin;
        private CheckBox showPassword;
        private TextBox passLogin;
        private TextBox emailLogin;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label5;
    }
}