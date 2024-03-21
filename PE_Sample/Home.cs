using RepositoryLayer.DAOs;
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
    public partial class Home : Form
    {
        private int userRole;

        public Home(int role)
        {
            InitializeComponent();
            this.userRole = role;
            if (userRole == 1)
            {
                adminRene.Visible = true;
                btnLinkMember.Visible = true;
            }
            else
            {
                adminRene.Visible = false;
                btnLinkMember.Visible = false;
            }

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLinkMember_Click(object sender, EventArgs e)
        {

            ManagerMember managerMember = new ManagerMember(userRole);
            managerMember.ShowDialog();
            this.Close();

        }

        private void btnLinkCafe_Click(object sender, EventArgs e)
        {
            ManagerCafe managerPet = new ManagerCafe(userRole);
            managerPet.ShowDialog();
            this.Close();
        }

        private void btnLinkCate_Click(object sender, EventArgs e)
        {
            MangerCate managerCate = new MangerCate(userRole);
            managerCate.ShowDialog();
            this.Close();
        }


        private void adminRene_Click(object sender, EventArgs e)
        {

            Admin admin = new Admin(userRole);
            admin.ShowDialog();
            this.Close();


        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            /*Login login = new Login();
            login.ShowDialog();
            this.Close();*/
            Application.Restart();
        }
    }
}
