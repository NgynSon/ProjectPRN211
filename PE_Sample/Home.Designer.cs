namespace PresentationLayer
{
    partial class Home
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
            exit = new Label();
            label1 = new Label();
            btnLinkMember = new Button();
            btnLinkPet = new Button();
            btnLinkCate = new Button();
            adminRene = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(exit);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(985, 100);
            panel1.TabIndex = 3;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.BackColor = SystemColors.ActiveCaptionText;
            exit.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            exit.ForeColor = Color.White;
            exit.Location = new Point(969, 0);
            exit.Name = "exit";
            exit.Size = new Size(16, 20);
            exit.TabIndex = 1;
            exit.Text = "x";
            exit.Click += exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(424, 30);
            label1.Name = "label1";
            label1.Size = new Size(111, 39);
            label1.TabIndex = 0;
            label1.Text = "Home";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnLinkMember
            // 
            btnLinkMember.BackColor = Color.Black;
            btnLinkMember.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnLinkMember.ForeColor = Color.White;
            btnLinkMember.Location = new Point(61, 268);
            btnLinkMember.Name = "btnLinkMember";
            btnLinkMember.Size = new Size(129, 68);
            btnLinkMember.TabIndex = 4;
            btnLinkMember.Text = "ManagerMember";
            btnLinkMember.UseVisualStyleBackColor = false;
            btnLinkMember.Click += btnLinkMember_Click;
            // 
            // btnLinkPet
            // 
            btnLinkPet.BackColor = Color.Black;
            btnLinkPet.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnLinkPet.ForeColor = Color.White;
            btnLinkPet.Location = new Point(317, 268);
            btnLinkPet.Name = "btnLinkPet";
            btnLinkPet.Size = new Size(148, 68);
            btnLinkPet.TabIndex = 5;
            btnLinkPet.Text = "Manager Cafe";
            btnLinkPet.UseVisualStyleBackColor = false;
            btnLinkPet.Click += btnLinkPet_Click;
            // 
            // btnLinkCate
            // 
            btnLinkCate.BackColor = Color.Black;
            btnLinkCate.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnLinkCate.ForeColor = Color.White;
            btnLinkCate.Location = new Point(556, 268);
            btnLinkCate.Name = "btnLinkCate";
            btnLinkCate.Size = new Size(131, 68);
            btnLinkCate.TabIndex = 6;
            btnLinkCate.Text = "Manager Categories";
            btnLinkCate.UseVisualStyleBackColor = false;
            btnLinkCate.Click += btnLinkCate_Click;
            // 
            // adminRene
            // 
            adminRene.BackColor = Color.Black;
            adminRene.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            adminRene.ForeColor = Color.White;
            adminRene.Location = new Point(763, 268);
            adminRene.Name = "adminRene";
            adminRene.Size = new Size(148, 68);
            adminRene.TabIndex = 7;
            adminRene.Text = "Admin Revenue";
            adminRene.UseVisualStyleBackColor = false;
            adminRene.Click += adminRene_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(985, 580);
            Controls.Add(adminRene);
            Controls.Add(btnLinkCate);
            Controls.Add(btnLinkPet);
            Controls.Add(btnLinkMember);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label exit;
        private Label label1;
        private Button btnLinkMember;
        private Button btnLinkPet;
        private Button btnLinkCate;
        private Button adminRene;
    }
}