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
        public ManagerCafe()
        {
            InitializeComponent();

            CategoryDAO categoryDAO = new CategoryDAO();
            var lists = categoryDAO.GetCategoryId();
            cateComboBox.DataSource = lists;

            CafeDAO cafeDAO = new CafeDAO();
            List<Cafe> pets = cafeDAO.GetAllCafes();

            cafeDataGridView.DataSource = pets;
            if (cafeDataGridView.Columns["Bills"] != null)
            {
                cafeDataGridView.Columns["Bills"].Visible = false;
            }
            if (cafeDataGridView.Columns["Cate"] != null)
            {
                cafeDataGridView.Columns["Cate"].Visible = false;
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
                MessageBox.Show("Pet name already exists. Please choose a different name.");
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
            List<Cafe> pets = cafeDAO.GetAllCafes();
            cafeDataGridView.DataSource = pets;

        }
        private void ViewPetData(object sender, DataGridViewCellEventArgs e)
        {
            var currentRow = e.RowIndex;
            CafeDAO cafeDAO = new CafeDAO();
            var cafees = cafeDAO.GetAllCafes();
            var cafe = cafees[currentRow];
            idCafeBox.Text = cafe.CaId.ToString();
            nameCafeBox.Text = cafe.CafeName;
            cafeDateImport.Value = (DateTime)cafe.ImportDate;
            cateComboBox.Text = cafe.CateId.ToString();
            cafePriceBox.Text = cafe.Price.ToString();
            quantityInput.Text = cafe.Quantity.ToString();
            cafeDecription.Text = cafe.Description;

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

            DialogResult result = MessageBox.Show("Are you sure you want to delete this Pet?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var deleteResult = petDAO.Remove(cafe);
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

        private void btnCafeHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.ShowDialog();
            Close();
        }

        private void cafeLinkCate_Click(object sender, EventArgs e)
        {
            MangerCate mangerCate = new MangerCate();
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
            cateComboBox.Text = cafe.Cate.ToString();
            quantityInput.Text = cafe.Quantity.ToString();
            cafePriceBox.Text = cafe.Quantity.ToString();
            cafeDecription.Text = cafe.Description.ToString();

        }
    }
}
