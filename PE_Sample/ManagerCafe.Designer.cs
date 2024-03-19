namespace PresentationLayer
{
    partial class ManagerCafe
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnCafeHome = new Button();
            exit = new Label();
            label1 = new Label();
            label = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label8 = new Label();
            label9 = new Label();
            quantityInput = new NumericUpDown();
            btnAddPet = new Button();
            btnEditPet = new Button();
            btnRemovePet = new Button();
            panel2 = new Panel();
            searchCafeInput = new TextBox();
            btnSearchCafe = new Button();
            btnRefeshPet = new Button();
            cafePriceBox = new NumericUpDown();
            cafeDateImport = new DateTimePicker();
            nameCafeBox = new TextBox();
            idCafeBox = new TextBox();
            cafeDecription = new RichTextBox();
            cateComboBox = new ComboBox();
            cafeLinkCate = new Button();
            cafeDataGridView = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)quantityInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cafePriceBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cafeDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnCafeHome);
            panel1.Controls.Add(exit);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(985, 100);
            panel1.TabIndex = 2;
            // 
            // btnCafeHome
            // 
            btnCafeHome.BackColor = Color.Black;
            btnCafeHome.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCafeHome.ForeColor = Color.White;
            btnCafeHome.Location = new Point(0, 65);
            btnCafeHome.Name = "btnCafeHome";
            btnCafeHome.Size = new Size(75, 35);
            btnCafeHome.TabIndex = 61;
            btnCafeHome.Text = "Home";
            btnCafeHome.UseVisualStyleBackColor = false;
            btnCafeHome.Click += btnCafeHome_Click;
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
            label1.Location = new Point(397, 31);
            label1.Name = "label1";
            label1.Size = new Size(251, 39);
            label1.TabIndex = 0;
            label1.Text = "Manager Cafe";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(44, 124);
            label.Name = "label";
            label.Size = new Size(32, 15);
            label.TabIndex = 31;
            label.Text = "CaID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 149);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 32;
            label2.Text = "CafeName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 236);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 33;
            label3.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(162, 149);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 34;
            label4.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(163, 236);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 35;
            label5.Text = "Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 205);
            label8.Name = "label8";
            label8.Size = new Size(70, 15);
            label8.TabIndex = 37;
            label8.Text = "Import Date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 299);
            label9.Name = "label9";
            label9.Size = new Size(67, 15);
            label9.TabIndex = 38;
            label9.Text = "Description";
            // 
            // quantityInput
            // 
            quantityInput.Increment = new decimal(new int[] { 0, 0, 0, 0 });
            quantityInput.Location = new Point(12, 254);
            quantityInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            quantityInput.Name = "quantityInput";
            quantityInput.Size = new Size(120, 23);
            quantityInput.TabIndex = 45;
            quantityInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddPet
            // 
            btnAddPet.BackColor = Color.Black;
            btnAddPet.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddPet.ForeColor = Color.White;
            btnAddPet.Location = new Point(2, 476);
            btnAddPet.Name = "btnAddPet";
            btnAddPet.Size = new Size(75, 35);
            btnAddPet.TabIndex = 46;
            btnAddPet.Text = "Add";
            btnAddPet.UseVisualStyleBackColor = false;
            btnAddPet.Click += btnAddPet_Click;
            // 
            // btnEditPet
            // 
            btnEditPet.BackColor = Color.Black;
            btnEditPet.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditPet.ForeColor = Color.White;
            btnEditPet.Location = new Point(105, 476);
            btnEditPet.Name = "btnEditPet";
            btnEditPet.Size = new Size(75, 35);
            btnEditPet.TabIndex = 47;
            btnEditPet.Text = "Edit";
            btnEditPet.UseVisualStyleBackColor = false;
            btnEditPet.Click += btnEditPet_Click;
            // 
            // btnRemovePet
            // 
            btnRemovePet.BackColor = Color.Black;
            btnRemovePet.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemovePet.ForeColor = Color.White;
            btnRemovePet.Location = new Point(208, 476);
            btnRemovePet.Name = "btnRemovePet";
            btnRemovePet.Size = new Size(75, 35);
            btnRemovePet.TabIndex = 48;
            btnRemovePet.Text = "Delete";
            btnRemovePet.UseVisualStyleBackColor = false;
            btnRemovePet.Click += btnRemovePet_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 546);
            panel2.Name = "panel2";
            panel2.Size = new Size(985, 34);
            panel2.TabIndex = 50;
            // 
            // searchCafeInput
            // 
            searchCafeInput.Location = new Point(342, 124);
            searchCafeInput.Name = "searchCafeInput";
            searchCafeInput.Size = new Size(460, 23);
            searchCafeInput.TabIndex = 17;
            // 
            // btnSearchCafe
            // 
            btnSearchCafe.BackColor = Color.Black;
            btnSearchCafe.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchCafe.ForeColor = Color.White;
            btnSearchCafe.Location = new Point(832, 124);
            btnSearchCafe.Name = "btnSearchCafe";
            btnSearchCafe.Size = new Size(75, 28);
            btnSearchCafe.TabIndex = 51;
            btnSearchCafe.Text = "Search";
            btnSearchCafe.UseVisualStyleBackColor = false;
            btnSearchCafe.Click += btnSearchCafe_Click;
            // 
            // btnRefeshPet
            // 
            btnRefeshPet.BackColor = Color.Black;
            btnRefeshPet.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefeshPet.ForeColor = Color.White;
            btnRefeshPet.Location = new Point(315, 479);
            btnRefeshPet.Name = "btnRefeshPet";
            btnRefeshPet.Size = new Size(68, 28);
            btnRefeshPet.TabIndex = 52;
            btnRefeshPet.Text = "Refesh";
            btnRefeshPet.UseVisualStyleBackColor = false;
            btnRefeshPet.Click += btnRefeshPet_Click;
            // 
            // cafePriceBox
            // 
            cafePriceBox.Increment = new decimal(new int[] { 0, 0, 0, 0 });
            cafePriceBox.Location = new Point(162, 254);
            cafePriceBox.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            cafePriceBox.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            cafePriceBox.Name = "cafePriceBox";
            cafePriceBox.Size = new Size(120, 23);
            cafePriceBox.TabIndex = 53;
            cafePriceBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cafeDateImport
            // 
            cafeDateImport.Location = new Point(110, 205);
            cafeDateImport.Name = "cafeDateImport";
            cafeDateImport.Size = new Size(172, 23);
            cafeDateImport.TabIndex = 54;
            // 
            // nameCafeBox
            // 
            nameCafeBox.Location = new Point(12, 170);
            nameCafeBox.Name = "nameCafeBox";
            nameCafeBox.Size = new Size(120, 23);
            nameCafeBox.TabIndex = 55;
            // 
            // idCafeBox
            // 
            idCafeBox.Location = new Point(88, 116);
            idCafeBox.Name = "idCafeBox";
            idCafeBox.ReadOnly = true;
            idCafeBox.Size = new Size(59, 23);
            idCafeBox.TabIndex = 56;
            // 
            // cafeDecription
            // 
            cafeDecription.Location = new Point(12, 317);
            cafeDecription.Name = "cafeDecription";
            cafeDecription.Size = new Size(270, 153);
            cafeDecription.TabIndex = 57;
            cafeDecription.Text = "";
            // 
            // cateComboBox
            // 
            cateComboBox.FormattingEnabled = true;
            cateComboBox.Location = new Point(162, 167);
            cateComboBox.Name = "cateComboBox";
            cateComboBox.Size = new Size(121, 23);
            cateComboBox.TabIndex = 58;
            // 
            // cafeLinkCate
            // 
            cafeLinkCate.BackColor = Color.Black;
            cafeLinkCate.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cafeLinkCate.ForeColor = Color.White;
            cafeLinkCate.Location = new Point(832, 479);
            cafeLinkCate.Name = "cafeLinkCate";
            cafeLinkCate.Size = new Size(129, 28);
            cafeLinkCate.TabIndex = 59;
            cafeLinkCate.Text = "ManagerCate";
            cafeLinkCate.UseVisualStyleBackColor = false;
            cafeLinkCate.Click += cafeLinkCate_Click;
            // 
            // cafeDataGridView
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Crimson;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            cafeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            cafeDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cafeDataGridView.GridColor = Color.Black;
            cafeDataGridView.Location = new Point(315, 167);
            cafeDataGridView.Name = "cafeDataGridView";
            cafeDataGridView.ReadOnly = true;
            cafeDataGridView.RowTemplate.Height = 25;
            cafeDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cafeDataGridView.Size = new Size(646, 306);
            cafeDataGridView.TabIndex = 60;
            cafeDataGridView.CellClick += cafeDataGridView_CellClick;
            // 
            // ManagerCafe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 580);
            Controls.Add(cafeDataGridView);
            Controls.Add(cafeLinkCate);
            Controls.Add(cateComboBox);
            Controls.Add(cafeDecription);
            Controls.Add(idCafeBox);
            Controls.Add(nameCafeBox);
            Controls.Add(cafeDateImport);
            Controls.Add(cafePriceBox);
            Controls.Add(btnRefeshPet);
            Controls.Add(btnSearchCafe);
            Controls.Add(searchCafeInput);
            Controls.Add(panel2);
            Controls.Add(btnRemovePet);
            Controls.Add(btnEditPet);
            Controls.Add(btnAddPet);
            Controls.Add(quantityInput);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManagerCafe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManagerPet";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)quantityInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)cafePriceBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cafeDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label exit;
        private Label label1;
        private Label label;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private RichTextBox richTextBox1;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown quantityInput;
        private Button btnAddPet;
        private Button btnEditPet;
        private Button btnRemovePet;
        private Panel panel2;
        private TextBox searchCafeInput;
        private Button btnSearchCafe;
        private Button btnRefeshPet;
        private NumericUpDown cafePriceBox;
        private DateTimePicker cafeDateImport;
        private TextBox nameCafeBox;
        private TextBox idCafeBox;
        private RichTextBox cafeDecription;
        private ComboBox cateComboBox;
        private Button cafeLinkCate;
        private Button btnCafeHome;
        private DataGridView cafeDataGridView;
    }
}