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
            string username = txtname.Text.Trim();
            string password = txtpassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            User user = loginController.Authenticate(username, password);

            if (user != null)
            {
                MessageBox.Show($"Welcome {user.UserName}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Hide this form and show the main form
                this.Hide();
                Mainform MainForm = new Mainform(); // or pass user info if needed
                MainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
