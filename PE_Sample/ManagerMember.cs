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
    public partial class ManagerMember : Form
    {
        private int userRole;
        public ManagerMember(int role)
        {
            InitializeComponent();
            this.userRole = role;
            MemberDAO memberDAO = new MemberDAO();
            List<Member> members = memberDAO.GetAllMembers();

            maleRadio.Checked = true;

            memberDataGridView.DataSource = members;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = searchInput.Text;

            MemberDAO memberDAO = new MemberDAO();

            List<Member> member = memberDAO.GetMembersBySearch(searchValue);

            memberDataGridView.DataSource = member;
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            memberIdInput.Text = string.Empty;
            memberInput.Text = string.Empty;
            emailInput.Text = string.Empty;
            passwordInput.Text = string.Empty;
            positionInput.Text = string.Empty;
            roleIdInput.Text = string.Empty;
            dateInput.Value = DateTime.Now;

            maleRadio.Checked = true;
            femaleRadio.Checked = false;
            MemberDAO memberDAO = new MemberDAO();
            List<Member> members = memberDAO.GetAllMembers();
            memberDataGridView.DataSource = members;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string MemberName = memberInput.Text;
            string Position = positionInput.Text;
            string Email = emailInput.Text;
            var Gender = maleRadio.Checked ? "Male" : "Female";
            string Password = passwordInput.Text;
            var date = dateInput.Value;
            int Role = int.Parse(roleIdInput.Text);
            MemberDAO memberDAO = new MemberDAO();
            if (!memberDAO.IsMemberNameUnique(MemberName))
            {
                MessageBox.Show("MemberName already exists. Please choose a different name.");
                return;
            }
            Member member = new Member()
            {
                MemberName = MemberName,
                Position = Position,
                Email = Email,
                Gender = Gender,
                Date = date,
                Password = Password,
                Role = Role,
            };


            bool result = memberDAO.Add(member);
            if (result)
            {
                MessageBox.Show("Add Susscessfully!");
            }
            else
            {
                MessageBox.Show("Add failed!");
            }
        }

        private void viewMember(object sender, DataGridViewCellEventArgs e)
        {
            var currentRow = e.RowIndex;
            MemberDAO memberDAO = new MemberDAO();
            var memmberS = memberDAO.GetAllMembers();
            var member = memmberS[currentRow];
            memberIdInput.Text = member.MemberId.ToString();
            memberInput.Text = member.MemberName;
            dateInput.Value = (DateTime)member.Date;
            emailInput.Text = member.Email;
            positionInput.Text = member.Position;
            passwordInput.Text = member.Password;
            roleIdInput.Text = member.Role.ToString();

            maleRadio.Checked = member.Gender == "Male";
            femaleRadio.Checked = member.Gender == "Female";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var id = memberIdInput.Text;
            string MemberName = memberInput.Text;
            string Position = positionInput.Text;
            string Email = emailInput.Text;
            var Gender = maleRadio.Checked ? "Male" : "Female";
            string Password = passwordInput.Text;
            var date = dateInput.Value;
            int Role = int.Parse(roleIdInput.Text);

            Member member = new Member()
            {
                MemberId = int.Parse(id),
                MemberName = MemberName,
                Position = Position,
                Email = Email,
                Gender = Gender,
                Date = date,
                Password = Password,
                Role = Role,
            };

            MemberDAO member1 = new MemberDAO();
            var results = member1.Update(member);
            if (results)
            {
                MessageBox.Show("Update Susscessfully!");
            }
            else
            {
                MessageBox.Show("Update failed!");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = memberIdInput.Text;
            string MemberName = memberInput.Text;
            string Position = positionInput.Text;
            string Email = emailInput.Text;
            var Gender = maleRadio.Checked ? "Male" : "Female";
            string Password = passwordInput.Text;
            var date = dateInput.Value;
            int Role = int.Parse(roleIdInput.Text);

            Member member = new Member()
            {
                MemberId = int.Parse(id),
                MemberName = MemberName,
                Position = Position,
                Email = Email,
                Gender = Gender,
                Date = date,
                Password = Password,
                Role = Role,
            };

            MemberDAO memberDAO = new MemberDAO();

            // Check if the user confirms the deletion (optional)
            DialogResult result = MessageBox.Show("Are you sure you want to delete this member?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Perform the delete operation
                var deleteResult = memberDAO.Remove(member);
                if (deleteResult)
                {
                    MessageBox.Show("Member deleted successfully!");
                    // Perform any other actions after successful deletion
                }
                else
                {
                    MessageBox.Show("Failed to delete member!");
                }
            }
        }

        private void btnMemberHome_Click(object sender, EventArgs e)
        {
            Home home = new Home(userRole);
            home.ShowDialog();
            this.Close();
        }

        private void memberDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
