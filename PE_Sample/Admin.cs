using RepositoryLayer.DAOs;
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
    public partial class Admin : Form
    {
        private CafeDAO cafeDAO;
        private MemberDAO memberDAO;
        private BillDAO billDAO;
        public Admin()
        {
            InitializeComponent();
            cafeDAO = new CafeDAO(); // Initialize the PetDAO instance
            UpdateTotalPetsLabel();
            memberDAO = new MemberDAO(); // Initialize the MemberDAO instance
            UpdateTotalMembersLabel();
            billDAO = new BillDAO();
            UpdateTotalBill();
        }

        private void UpdateTotalPetsLabel()
        {
            int totalNumberOfPets = cafeDAO.GetTotalNumberOfCafes();
            TotalPet.Text = totalNumberOfPets.ToString();
        }
        private void UpdateTotalMembersLabel()
        {
            int totalNumberOfMembers = memberDAO.GetTotalNumberOfMembers();
            int totalMembersMinusOne = totalNumberOfMembers - 1;
            totalMember.Text = totalMembersMinusOne.ToString();
        }
        private void UpdateTotalBill()
        {
            int totalNumberOfBills = int.Parse(billDAO.GetTotalRevenue().ToString());
            totalRevenue.Text = totalNumberOfBills.ToString();
        }
        private void TotalPet_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMemberHome_Click(object sender, EventArgs e)
        {

            Home home = new Home();
            home.ShowDialog();
        }

        private void totalRevenue_Click(object sender, EventArgs e)
        {

        }
    }
}
