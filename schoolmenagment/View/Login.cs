using schoolmenagment.controller;
using schoolmenagment.models;
using schoolmenagment.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace schoolmenagment
{
    public partial class Login : Form
    {
        private Logincontroller loginController;
        public Login()
        {
            InitializeComponent();
            loginController = new Logincontroller();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get username and password from textboxes
            string username = txtname.Text.Trim();
            string password = txtpassword.Text.Trim();

            // Check if empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            // Authenticate user via controller
            User user = loginController.Authenticate(username, password);

            if (user != null)
            {
                finder.usertype = user.Role;

                // ✅ Debug
                MessageBox.Show($"Logged in Role: {finder.usertype}");

                // Hide login form and open main form with user info
                this.Hide();
                Mainform mainForm = new Mainform(user.Role); // Pass User object to Mainform
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
