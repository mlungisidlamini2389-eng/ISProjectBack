using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPTIMA_Academic_Support_System_OASS_
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();

            cmbRole.SelectedIndex = 0;
            cmbRole.Focus();
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbRole.SelectedItem == null)
            {
                return;
            }

            string selectedRole = cmbRole.SelectedItem.ToString();

            if (selectedRole == "Administrator")
            {
                lblUsername.Text = "Admin Number ";
            }
            else
            {
                lblUsername.Text = "Student Number";
            }

            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (cmbRole.SelectedItem == null)
            {
                MessageBox.Show(
                    "Please select how you want to sign in.",
                    "Role Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                if (cmbRole.SelectedItem.ToString() == "Administrator")
                {
                    MessageBox.Show(
                        "Please enter your admin number.",
                        "Admin Number Required",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Please enter your student number.",
                        "Student Number Required",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }

                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show(
                    "Please enter your password.",
                    "Password Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtPassword.Focus();
                return;
            }

            // fetching from our Database and Authenticate

            string role = cmbRole.SelectedItem.ToString();

            if (role == "Student")
            {
                // Check student login details here.
                Student_Dashboard student_dashboard = new Student_Dashboard();

                this.Hide();

                student_dashboard.ShowDialog();

                this.Show();
            }
            else if (role == "Tutor")
            {
                // Check tutor login details here.
            }
            else if (role == "Administrator")
            {
                // Check administrator details here.
              
            }
        }

        private void linkCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Create_Account create_Account = new Create_Account();

            this.Hide();

            create_Account.ShowDialog();

            this.Show();
        }
    
    }
    
}
