using BloodBankManagementSystem.BLL;
using BloodBankManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //Create the Object of BLL and DAL
        loginBLL l = new loginBLL();
        loginDAL dal = new loginDAL();

        //Create a Static String method to save the username
        public static string loggedInUser;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Show a confirmation dialog for stopping the system
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Check the user's choice
            if (result == DialogResult.Yes)
            {
                // Stop the program and exit the application
                Application.Exit();
            }
            // If 'No', do nothing (simply return to the current form)
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Get the username and password from the login form
            l.username = txtUsername.Text;
            l.password = txtPassword.Text;

            // Check the login credentials
            bool isSuccess = dal.loginCheck(l);

            // If login is successful
            if (isSuccess == true)
            {
                // Show a message box indicating proceeding
                MessageBox.Show("Successfully logged in!", "Access granted!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Save the username in loggedInUser Static Method
                loggedInUser = l.username;

                // Display the home form
                frmHome home = new frmHome();
                home.Show();
                this.Hide(); // Close the login form
            }
            else
            {
                // Login failed
                // Display the error message
                MessageBox.Show("Please check your login details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordChar_CheckedChanged(object sender, EventArgs e)
        {
            if (PasswordChar.Checked)
            {
                txtPassword.PasswordChar = '\0'; // Show password
            }
            else
            {
                txtPassword.PasswordChar = '*'; // Hide password
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
