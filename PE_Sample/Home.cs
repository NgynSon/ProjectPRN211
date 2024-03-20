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
        public Home()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLinkMember_Click(object sender, EventArgs e)
        {

            ManagerMember managerMember = new ManagerMember();
            managerMember.ShowDialog();
            Close();

        }

        private void btnLinkCafe_Click(object sender, EventArgs e)
        {
            ManagerCafe managerPet = new ManagerCafe();
            managerPet.ShowDialog();
            Close();
        }

        private void btnLinkCate_Click(object sender, EventArgs e)
        {
            MangerCate managerCate = new MangerCate();
            managerCate.ShowDialog();
            Close();
        }

        private void adminRene_Click(object sender, EventArgs e)
        {
           /* MemberDAO member = new MemberDAO();
            adminRene.Visible = true;
            if (member.GetMemberById. == 1)
            {
                adminRene.Visible = true;
                Home home = new Home();
                home.ShowDialog();
                Close();
            }
            else
            {
                adminRene.Visible = false;
                
            }*/
        }


    }
}
