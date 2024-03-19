namespace PresentationLayer
{
    partial class MangerCate
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
            btnCateHome = new Button();
            exit = new Label();
            label1 = new Label();
            panel2 = new Panel();
            cateDataGridView = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            categoriesNameInput = new TextBox();
            categoriesInput = new TextBox();
            btnDelateCate = new Button();
            btnEditCate = new Button();
            btnAddCate = new Button();
            refeshCate = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cateDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnCateHome);
            panel1.Controls.Add(exit);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(985, 71);
            panel1.TabIndex = 3;
            // 
            // btnCateHome
            // 
            btnCateHome.BackColor = Color.Black;
            btnCateHome.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCateHome.ForeColor = Color.White;
            btnCateHome.Location = new Point(0, 36);
            btnCateHome.Name = "btnCateHome";
            btnCateHome.Size = new Size(75, 35);
            btnCateHome.TabIndex = 60;
            btnCateHome.Text = "Home";
            btnCateHome.UseVisualStyleBackColor = false;
            btnCateHome.Click += btnCateHome_Click;
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
            label1.Location = new Point(330, 9);
            label1.Name = "label1";
            label1.Size = new Size(432, 39);
            label1.TabIndex = 0;
            label1.Text = "Manager Cafe Categories";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 519);
            panel2.Name = "panel2";
            panel2.Size = new Size(985, 61);
            panel2.TabIndex = 51;
            // 
            // cateDataGridView
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Crimson;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            cateDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            cateDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cateDataGridView.GridColor = Color.Crimson;
            cateDataGridView.Location = new Point(28, 122);
            cateDataGridView.Name = "cateDataGridView";
            cateDataGridView.ReadOnly = true;
            cateDataGridView.RowTemplate.Height = 25;
            cateDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cateDataGridView.Size = new Size(543, 300);
            cateDataGridView.TabIndex = 50;
            cateDataGridView.CellClick += ViewCate;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(623, 142);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 52;
            label2.Text = "CategoryID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(602, 215);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 53;
            label3.Text = "CategoryName";
            // 
            // categoriesNameInput
            // 
            categoriesNameInput.Location = new Point(699, 207);
            categoriesNameInput.Name = "categoriesNameInput";
            categoriesNameInput.Size = new Size(176, 23);
            categoriesNameInput.TabIndex = 54;
            // 
            // categoriesInput
            // 
            categoriesInput.Location = new Point(699, 139);
            categoriesInput.Name = "categoriesInput";
            categoriesInput.ReadOnly = true;
            categoriesInput.Size = new Size(176, 23);
            categoriesInput.TabIndex = 55;
            // 
            // btnDelateCate
            // 
            btnDelateCate.BackColor = Color.Black;
            btnDelateCate.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelateCate.ForeColor = Color.White;
            btnDelateCate.Location = new Point(601, 431);
            btnDelateCate.Name = "btnDelateCate";
            btnDelateCate.Size = new Size(75, 35);
            btnDelateCate.TabIndex = 56;
            btnDelateCate.Text = "Delete";
            btnDelateCate.UseVisualStyleBackColor = false;
            btnDelateCate.Click += btnDelateCate_Click;
            // 
            // btnEditCate
            // 
            btnEditCate.BackColor = Color.Black;
            btnEditCate.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditCate.ForeColor = Color.White;
            btnEditCate.Location = new Point(699, 431);
            btnEditCate.Name = "btnEditCate";
            btnEditCate.Size = new Size(75, 35);
            btnEditCate.TabIndex = 57;
            btnEditCate.Text = "Edit";
            btnEditCate.UseVisualStyleBackColor = false;
            btnEditCate.Click += btnEditCate_Click;
            // 
            // btnAddCate
            // 
            btnAddCate.BackColor = Color.Black;
            btnAddCate.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddCate.ForeColor = Color.White;
            btnAddCate.Location = new Point(802, 431);
            btnAddCate.Name = "btnAddCate";
            btnAddCate.Size = new Size(75, 35);
            btnAddCate.TabIndex = 58;
            btnAddCate.Text = "Add";
            btnAddCate.UseVisualStyleBackColor = false;
            btnAddCate.Click += btnAddCate_Click;
            // 
            // refeshCate
            // 
            refeshCate.BackColor = Color.Black;
            refeshCate.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            refeshCate.ForeColor = Color.White;
            refeshCate.Location = new Point(240, 431);
            refeshCate.Name = "refeshCate";
            refeshCate.Size = new Size(75, 35);
            refeshCate.TabIndex = 59;
            refeshCate.Text = "Refesh";
            refeshCate.UseVisualStyleBackColor = false;
            refeshCate.Click += refeshCate_Click;
            // 
            // MangerCate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 580);
            Controls.Add(refeshCate);
            Controls.Add(btnAddCate);
            Controls.Add(btnEditCate);
            Controls.Add(btnDelateCate);
            Controls.Add(categoriesInput);
            Controls.Add(categoriesNameInput);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cateDataGridView);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MangerCate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MangerCate";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cateDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label exit;
        private Label label1;
        private Panel panel2;
        private DataGridView cateDataGridView;
        private Label label2;
        private Label label3;
        private TextBox categoriesNameInput;
        private TextBox categoriesInput;
        private Button btnDelateCate;
        private Button btnEditCate;
        private Button btnAddCate;
        private Button refeshCate;
        private Button btnCateHome;
    }
}