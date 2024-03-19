namespace PresentationLayer
{
    partial class ManagerMember
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnMemberHome = new Button();
            label6 = new Label();
            label1 = new Label();
            memberDataGridView = new DataGridView();
            searchInput = new TextBox();
            btnSearch = new Button();
            btnRefesh = new Button();
            panel2 = new Panel();
            memberIdInput = new TextBox();
            memberInput = new TextBox();
            emailInput = new TextBox();
            passwordInput = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            label = new Label();
            positionInput = new TextBox();
            label5 = new Label();
            label7 = new Label();
            dateInput = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            maleRadio = new RadioButton();
            femaleRadio = new RadioButton();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            roleIdInput = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)memberDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roleIdInput).BeginInit();
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
            panel1.TabIndex = 1;
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
            label6.Location = new Point(968, 0);
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
            label1.Location = new Point(310, 26);
            label1.Name = "label1";
            label1.Size = new Size(317, 39);
            label1.TabIndex = 0;
            label1.Text = "Manager Members";
            // 
            // memberDataGridView
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Crimson;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            memberDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            memberDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            memberDataGridView.GridColor = Color.Crimson;
            memberDataGridView.Location = new Point(393, 151);
            memberDataGridView.Name = "memberDataGridView";
            memberDataGridView.ReadOnly = true;
            memberDataGridView.RowTemplate.Height = 25;
            memberDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            memberDataGridView.Size = new Size(555, 320);
            memberDataGridView.TabIndex = 14;
            memberDataGridView.CellClick += viewMember;
            memberDataGridView.CellContentClick += memberDataGridView_CellContentClick;
            // 
            // searchInput
            // 
            searchInput.Location = new Point(393, 111);
            searchInput.Name = "searchInput";
            searchInput.Size = new Size(460, 23);
            searchInput.TabIndex = 16;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Black;
            btnSearch.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(873, 106);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 28);
            btnSearch.TabIndex = 17;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRefesh
            // 
            btnRefesh.BackColor = Color.Black;
            btnRefesh.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefesh.ForeColor = Color.White;
            btnRefesh.Location = new Point(393, 491);
            btnRefesh.Name = "btnRefesh";
            btnRefesh.Size = new Size(68, 28);
            btnRefesh.TabIndex = 20;
            btnRefesh.Text = "Refesh";
            btnRefesh.UseVisualStyleBackColor = false;
            btnRefesh.Click += btnRefesh_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 546);
            panel2.Name = "panel2";
            panel2.Size = new Size(985, 34);
            panel2.TabIndex = 21;
            // 
            // memberIdInput
            // 
            memberIdInput.Location = new Point(145, 127);
            memberIdInput.Name = "memberIdInput";
            memberIdInput.ReadOnly = true;
            memberIdInput.Size = new Size(74, 23);
            memberIdInput.TabIndex = 22;
            // 
            // memberInput
            // 
            memberInput.Location = new Point(12, 186);
            memberInput.Name = "memberInput";
            memberInput.Size = new Size(147, 23);
            memberInput.TabIndex = 23;
            // 
            // emailInput
            // 
            emailInput.Location = new Point(10, 242);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(147, 23);
            emailInput.TabIndex = 24;
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(228, 186);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(140, 23);
            passwordInput.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 168);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 27;
            label2.Text = "MemberName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(228, 168);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 28;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 224);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 29;
            label3.Text = "Email";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(76, 135);
            label.Name = "label";
            label.Size = new Size(63, 15);
            label.TabIndex = 30;
            label.Text = "MemberID";
            // 
            // positionInput
            // 
            positionInput.Location = new Point(226, 242);
            positionInput.Name = "positionInput";
            positionInput.Size = new Size(140, 23);
            positionInput.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(226, 224);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 32;
            label5.Text = "Position";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 278);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 33;
            label7.Text = "Date";
            // 
            // dateInput
            // 
            dateInput.Location = new Point(10, 296);
            dateInput.Name = "dateInput";
            dateInput.Size = new Size(158, 23);
            dateInput.TabIndex = 34;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(226, 281);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 35;
            label8.Text = "Role";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 376);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 36;
            label9.Text = "Gender";
            // 
            // maleRadio
            // 
            maleRadio.AutoSize = true;
            maleRadio.Location = new Point(76, 374);
            maleRadio.Name = "maleRadio";
            maleRadio.Size = new Size(51, 19);
            maleRadio.TabIndex = 37;
            maleRadio.TabStop = true;
            maleRadio.Text = "Male";
            maleRadio.UseVisualStyleBackColor = true;
            // 
            // femaleRadio
            // 
            femaleRadio.AutoSize = true;
            femaleRadio.Location = new Point(168, 374);
            femaleRadio.Name = "femaleRadio";
            femaleRadio.Size = new Size(63, 19);
            femaleRadio.TabIndex = 38;
            femaleRadio.TabStop = true;
            femaleRadio.Text = "Female";
            femaleRadio.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Black;
            btnAdd.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(21, 436);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 35);
            btnAdd.TabIndex = 39;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Black;
            btnUpdate.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(156, 436);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 35);
            btnUpdate.TabIndex = 40;
            btnUpdate.Text = "Edit";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Black;
            btnDelete.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(283, 436);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(74, 35);
            btnDelete.TabIndex = 41;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // roleIdInput
            // 
            roleIdInput.Location = new Point(228, 299);
            roleIdInput.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            roleIdInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            roleIdInput.Name = "roleIdInput";
            roleIdInput.Size = new Size(138, 23);
            roleIdInput.TabIndex = 42;
            roleIdInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ManagerMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 580);
            Controls.Add(roleIdInput);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(femaleRadio);
            Controls.Add(maleRadio);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(dateInput);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(positionInput);
            Controls.Add(label);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(passwordInput);
            Controls.Add(emailInput);
            Controls.Add(memberInput);
            Controls.Add(memberIdInput);
            Controls.Add(panel2);
            Controls.Add(btnRefesh);
            Controls.Add(btnSearch);
            Controls.Add(searchInput);
            Controls.Add(memberDataGridView);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManagerMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManagerMember";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)memberDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)roleIdInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label1;
        private DataGridView memberDataGridView;
        private TextBox searchInput;
        private Button btnSearch;
        private Button btnRefesh;
        private Panel panel2;
        private TextBox memberIdInput;
        private TextBox memberInput;
        private TextBox emailInput;
        private TextBox passwordInput;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label;
        private TextBox positionInput;
        private Label label5;
        private Label label7;
        private DateTimePicker dateInput;
        private Label label8;
        private Label label9;
        private RadioButton maleRadio;
        private RadioButton femaleRadio;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private NumericUpDown roleIdInput;
        private Button btnMemberHome;
    }
}