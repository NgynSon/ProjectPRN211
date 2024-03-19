﻿using RepositoryLayer.DAOs;
using RepositoryLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class MangerCate : Form
    {
        public MangerCate()
        {
            InitializeComponent();

            CategoryDAO categoryDAO = new CategoryDAO();
            List<Category> categories = categoryDAO.GetAllCategories();

            cateDataGridView.DataSource = categories;
            if (cateDataGridView.Columns["Cafes"] != null)
            {
                cateDataGridView.Columns["Cafes"].Visible = false;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ViewCate(object sender, DataGridViewCellEventArgs e)
        {
            var currentRow = e.RowIndex;
            CategoryDAO category = new CategoryDAO();
            var catee = category.GetAllCategories();
            var cates = catee[currentRow];
            categoriesInput.Text = cates.CateId.ToString();
            categoriesNameInput.Text = cates.CateName;
        }

        private void btnAddCate_Click(object sender, EventArgs e)
        {
            var cateName = categoriesNameInput.Text;
            CategoryDAO category = new CategoryDAO();
            if (!category.IsCateNameUnique(cateName))
            {
                MessageBox.Show("Category name already exists. Please choose a different name.");
                return;
            }
            Category category1 = new Category()
            {
                CateName = cateName,
            };

            bool results = category.Update(category1);

            if (results)
            {
                MessageBox.Show("Add Susscessfully!");
                Close();
            }
            else
            {
                MessageBox.Show("Add failed!");
            }
        }

        private void btnEditCate_Click(object sender, EventArgs e)
        {
            var id = int.Parse(categoriesInput.Text);
            var name = categoriesNameInput.Text;
            CategoryDAO category = new CategoryDAO();
            Category category1 = new Category()
            {
                CateId = id,
                CateName = name,
            };
            bool results = category.Update(category1);
            if (results)
            {
                MessageBox.Show("Update Susscessfully!");
            }
            else
            {
                MessageBox.Show("Update failed!");
            }
        }

        private void btnDelateCate_Click(object sender, EventArgs e)
        {
            var id = categoriesInput.Text;
            var name = categoriesNameInput.Text;
            CategoryDAO category = new CategoryDAO();
            Category category1 = new Category()
            {
                CateId = int.Parse(id),
                CateName = name,
            };
            DialogResult result = MessageBox.Show("Are you sure you want to delete this category?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var deleteResult = category.Remove(category1);
                if (deleteResult)
                {
                    MessageBox.Show("Pet deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to delete Pet!");
                }
            }
        }

        private void refeshCate_Click(object sender, EventArgs e)
        {
            categoriesInput.Text = string.Empty;
            categoriesNameInput.Text = string.Empty;
            CategoryDAO category = new CategoryDAO();
            List<Category> categories = category.GetAllCategories();
            cateDataGridView.DataSource = categories;
        }

        private void btnCateHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.ShowDialog();
            Close();
        }
    }
}