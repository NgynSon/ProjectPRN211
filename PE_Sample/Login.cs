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

namespace PresentationLayer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            passLogin.UseSystemPasswordChar = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = emailLogin.Text;
            string password = passLogin.Text;

            MemberDAO dao = new MemberDAO();
            Member mem = dao.Login(email, password);


            if (mem == null)
            {
                MessageBox.Show("Your account password is not correct, please re-enter");
            }
            else if (mem.Role == 1)
            {
                this.Hide();
                Admin admin = new Admin((int)mem.Role);
                admin.ShowDialog();
                admin.Show();

            }
            else if (mem.Role == 2)
            {
                this.Hide();
                Home home = new Home((int)mem.Role);              
                home.ShowDialog();

            }
            else
            {
                this.Hide();
            }
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            passLogin.UseSystemPasswordChar = !showPassword.Checked;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
