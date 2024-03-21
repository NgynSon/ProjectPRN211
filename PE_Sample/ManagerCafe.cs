using RepositoryLayer.DAOs;
using RepositoryLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PresentationLayer
{
    public partial class ManagerCafe : Form
    {
        public int CaId { get; set; }
        private int userRole;
        public ManagerCafe(int role)
        {
            InitializeComponent();
            this.userRole = role;

            CategoryDAO categoryDAO = new CategoryDAO();
            List<Category> lists = categoryDAO.GetCategoryId();
            cateComboBox.DataSource = lists;
            cateComboBox.DisplayMember = "CateName";
            cateComboBox.ValueMember = "CateId";

            CafeDAO cafeDAO = new CafeDAO();
            var cafes = cafeDAO.GetAllCafes();

            cafeDataGridView.DataSource = cafes;
            if (cafeDataGridView.Columns["Bills"] != null)
            {
                cafeDataGridView.Columns["Bills"].Visible = false;
            }
            if (cafeDataGridView.Columns["Cate"] != null)
            {
                cafeDataGridView.Columns["Cate"].Visible = false;
            }
            if (userRole == 1)
            {
                btnAddPet.Visible = true;
                btnRemovePet.Visible = true;
            }
            else
            {
                btnAddPet.Visible = false;
                btnRemovePet.Visible = false;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddPet_Click(object sender, EventArgs e)
        {

            var cafeName = nameCafeBox.Text;
            int categoryId = int.Parse(cateComboBox.Text);
            var date = cafeDateImport.Value;
            var quantity = (int)quantityInput.Value;
            var price = (int)cafePriceBox.Value;
            string description = cafeDecription.Text;
            CafeDAO petDAO = new CafeDAO();
            if (!petDAO.IsCafeNameUnique(cafeName))
            {
                MessageBox.Show("Cafe name already exists. Please choose a different name.");
                return;
            }
            Cafe cafe = new Cafe()
            {
                CafeName = cafeName,
                CateId = categoryId,
                ImportDate = date,
                Quantity = quantity,
                Price = price,
                Description = description
            };
            CafeDAO pest = new CafeDAO();
            bool result = pest.Add(cafe);
            if (result)
            {
                MessageBox.Show("Add Susscessfully!");
                Close();
            }
            else
            {
                MessageBox.Show("Add failed!");
            }
        }

        private void btnRefeshPet_Click(object sender, EventArgs e)
        {
            idCafeBox.Text = string.Empty;
            nameCafeBox.Text = string.Empty;
            cateComboBox.Text = string.Empty;
            cafeDateImport.Value = DateTime.Now;
            quantityInput.Value = 1;
            cafePriceBox.Value = 1;
            cafeDecription.Text = string.Empty;
            CafeDAO cafeDAO = new CafeDAO();
            var cafes = cafeDAO.GetAllCafes();
            cafeDataGridView.DataSource = cafes;

        }


        private void btnEditPet_Click(object sender, EventArgs e)
        {
            var id = int.Parse(idCafeBox.Text);
            var cafeName = nameCafeBox.Text;
            int categoryId = int.Parse(cateComboBox.Text);
            var date = cafeDateImport.Value;
            var quantity = (int)quantityInput.Value;
            var price = (int)cafePriceBox.Value;
            string description = cafeDecription.Text;

            Cafe cafe = new Cafe()
            {
                CaId = id,
                CafeName = cafeName,
                CateId = categoryId,
                ImportDate = date,
                Quantity = quantity,
                Price = price,
                Description = description
            };
            CafeDAO pest = new CafeDAO();
            bool result = pest.Update(cafe);
            if (result)
            {
                MessageBox.Show("Update Susscessfully!");
                Close();
            }
            else
            {
                MessageBox.Show("Update failed!");
            }
        }

        private void btnRemovePet_Click(object sender, EventArgs e)
        {
            var id = int.Parse(idCafeBox.Text);
            var cafeName = nameCafeBox.Text;
            int categoryId = int.Parse(cateComboBox.Text);
            var date = cafeDateImport.Value;
            var quantity = (int)quantityInput.Value;
            var price = (int)cafePriceBox.Value;
            string description = cafeDecription.Text;

            Cafe cafe = new Cafe()
            {
                CaId = id,
                CafeName = cafeName,
                CateId = categoryId,
                ImportDate = date,
                Quantity = quantity,
                Price = price,
                Description = description
            };

            CafeDAO petDAO = new CafeDAO();

            DialogResult result = MessageBox.Show("Are you sure you want to delete this Cafe?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var deleteResult = petDAO.Remove(cafe);
                if (deleteResult)
                {
                    MessageBox.Show("Cafe deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to delete Cafe!");
                }
            }
        }

        private void btnCafeHome_Click(object sender, EventArgs e)
        {
            Home home = new Home(userRole);
            home.ShowDialog();
            Close();
        }

        private void cafeLinkCate_Click(object sender, EventArgs e)
        {
            MangerCate mangerCate = new MangerCate(userRole);
            mangerCate.ShowDialog();
        }

        private void btnSearchCafe_Click(object sender, EventArgs e)
        {
            string searchValue = searchCafeInput.Text;

            CafeDAO cafeDAO = new CafeDAO();

            List<Cafe> cafe = cafeDAO.GetCafesBySearch(searchValue);

            cafeDataGridView.DataSource = cafe;
        }

        private void cafeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var currentRow = e.RowIndex;
            CafeDAO cafeDao = new CafeDAO();
            var cafes = cafeDao.GetAllCafes();
            var cafe = cafes[currentRow];
            idCafeBox.Text = cafe.CaId.ToString();
            nameCafeBox.Text = cafe.CafeName;
            cafeDateImport.Value = (DateTime)cafe.ImportDate;
            cateComboBox.SelectedValue = cafe.CateId;
            quantityInput.Text = cafe.Quantity.ToString();
            cafePriceBox.Text = cafe.Quantity.ToString();
            cafeDecription.Text = cafe.Description.ToString();

        }
    }
}
