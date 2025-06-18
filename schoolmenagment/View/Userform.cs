using schoolmenagment.controller;
using schoolmenagment.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schoolmenagment.View
{
    public partial class Userform : Form

    {
        private Usercontroller usercontroller = new Usercontroller();
        private int selectedUserId = -1;
        public Userform()
        {
            InitializeComponent();
            LoadRoles();
            LoadUsers();
        }
        private void LoadRoles()
        {
            cmbrole.Items.Clear();
            cmbrole.Items.Add("Admin");
            cmbrole.Items.Add("Teacher");
            cmbrole.Items.Add("Student");
            cmbrole.SelectedIndex = 0; // default selection
        }
        private void LoadUsers()
        {
            dgvuser.DataSource = usercontroller.GetAllUsers();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvuser.Rows[e.RowIndex];
                selectedUserId = Convert.ToInt32(row.Cells["UserId"].Value);
                txtusername.Text = row.Cells["UserName"].Value.ToString();
                txtpassword.Text = row.Cells["Password"].Value.ToString();
                cmbrole.SelectedItem = row.Cells["Role"].Value.ToString();
            }
        }

        private void btnadduser_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                UserName = txtusername.Text,
                Password = txtpassword.Text,
                Role = cmbrole.SelectedItem.ToString()
            };

            usercontroller.AddUser(user);
            MessageBox.Show("User added successfully!");
            ClearForm();
            LoadUsers();
        }

        private void btnupdateuser_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a user to edit.");
                return;
            }

            User user = new User
            {
                UserId = selectedUserId,
                UserName = txtusername.Text,
                Password = txtpassword.Text,
                Role = cmbrole.SelectedItem.ToString()
            };

            usercontroller.UpdateUser(user);
            MessageBox.Show("User updated successfully!");
            ClearForm();
            LoadUsers();
        }

        private void btndeleteuser_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                usercontroller.DeleteUser(selectedUserId);
                MessageBox.Show("User deleted successfully!");
                ClearForm();
                LoadUsers();
            }
        }
        private void ClearForm()
        {
            txtusername.Clear();
            txtpassword.Clear();
            cmbrole.SelectedIndex = 0;
            selectedUserId = -1;
        }
    }

    
}
