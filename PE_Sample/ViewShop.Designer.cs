namespace PresentationLayer
{
    partial class ViewShop
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
            viewMemberInShop = new DataGridView();
            viewPetInShop = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewMemberInShop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewPetInShop).BeginInit();
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
            panel1.Size = new Size(1060, 65);
            panel1.TabIndex = 4;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.BackColor = SystemColors.ActiveCaptionText;
            exit.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            exit.ForeColor = Color.White;
            exit.Location = new Point(1044, 0);
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
            label1.Location = new Point(440, 9);
            label1.Name = "label1";
            label1.Size = new Size(184, 39);
            label1.TabIndex = 0;
            label1.Text = "View Shop";
            // 
            // viewMemberInShop
            // 
            viewMemberInShop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewMemberInShop.Location = new Point(12, 85);
            viewMemberInShop.Name = "viewMemberInShop";
            viewMemberInShop.RowTemplate.Height = 25;
            viewMemberInShop.Size = new Size(306, 150);
            viewMemberInShop.TabIndex = 5;
            // 
            // viewPetInShop
            // 
            viewPetInShop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewPetInShop.Location = new Point(343, 85);
            viewPetInShop.Name = "viewPetInShop";
            viewPetInShop.RowTemplate.Height = 25;
            viewPetInShop.Size = new Size(705, 361);
            viewPetInShop.TabIndex = 6;
            // 
            // ViewShop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 499);
            Controls.Add(viewPetInShop);
            Controls.Add(viewMemberInShop);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewShop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewShop";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)viewMemberInShop).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewPetInShop).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label exit;
        private Label label1;
        private DataGridView viewMemberInShop;
        private DataGridView viewPetInShop;
    }
}