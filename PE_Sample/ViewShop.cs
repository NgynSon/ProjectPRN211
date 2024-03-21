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
    public partial class ViewShop : Form
    {
        public ViewShop()
        {
            InitializeComponent();

            CafeDAO cafe = new CafeDAO();
            var pets = cafe.GetAllCafes();
            viewPetInShop.DataSource = pets;
            if (viewPetInShop.Columns["Bills"] != null)
            {
                viewPetInShop.Columns["Bills"].Visible = false;
            }
            if (viewPetInShop.Columns["Cate"] != null)
            {
                viewPetInShop.Columns["Cate"].Visible = false;
            }

            MemberDAO memberDAO = new MemberDAO();
            List<Member> members = memberDAO.GetAllMembers();
            viewMemberInShop.DataSource = members;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
