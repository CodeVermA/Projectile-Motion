using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Projectile_Motion___Final_Year
{
    public partial class fm_registerUser : Form
    {
        private bool passMatched = false, usernameShown;

        public fm_registerUser()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(fm_registerUser_Close);
        }

        public void fm_registerUser_Close(object sender, EventArgs e)
        {
            Global.EnableForm(new fm_MainForm().Name);
        }// Activates the main form when this form closes

        public static void Create()
        {
            fm_registerUser fm_RegisterUser = new fm_registerUser();
            fm_RegisterUser.Show();
        } // Create New Form

        private void txtbx_lastName_TextChanged(object sender, EventArgs e)
        {
            showUsername();
        }

        private void txtbx_firstName_TextChanged(object sender, EventArgs e)
        {
            showUsername();
        }

        private void bt_registerUser_Click(object sender, EventArgs e)
        {
            if (passMatched && usernameShown)
            {
                string userFirstName = txtbx_firstName.Text.Trim(), userLastName = txtbx_lastName.Text.Trim(),
                    username = lbl_showUsername.Text.Trim(), userPassword = txtbx_password.Text.Trim();

                bool userAdded = Global.User.Add(userFirstName, userLastName, username, userPassword);// check whether user added
                if (userAdded)
                {
                    MessageBox.Show("USER ADDED");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("USER ALREADY EXSISTS");
                }
            }
            else
            {
                MessageBox.Show("FILL ALL THE FEILDS CORRECTLY");
            }
        }

        private string generateUsername(string name, int length)
        {
            var random = new Random();
            var randomString = new string(Enumerable.Repeat(name, length)
                                                    .Select(s => s[random.Next(s.Length)]).ToArray());
            return randomString;
        }// Return a string of given length form the given string 

        private void showUsername()
        {
            if (txtbx_firstName.Text.Trim().Length > 0 && txtbx_lastName.Text.Trim().Length > 0)
            {
                lbl_showUsername.Text = generateUsername(txtbx_lastName.Text.Trim() + txtbx_firstName.Text.Trim(), 4);
                usernameShown = true;
            }
            else
            {
                lbl_showUsername.Text = null;
                usernameShown = false;
            }
        } // Create and show username

        private void comparePassword()
        {
            if (txtbx_password.Text.Trim().Length != 0 && txtbx_re_enterPass.Text.Trim().Length != 0)
            {
                passMatched = txtbx_password.Text.Trim() == txtbx_re_enterPass.Text.Trim() ? true : false;
                if (!passMatched)
                {
                    lbl_passMatch.Text = "PASSWORD DOES NOT MATCH";
                }
                else
                {
                    lbl_passMatch.Text = null;
                }
            }

        } // Compare Password And Re-enter Password Textboxe's Text

        private void txtbx_password_TextChanged(object sender, EventArgs e)
        {
            comparePassword();
        }

        private void bt_exitRegister_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void txtbx_re_enterPass_TextChanged(object sender, EventArgs e)
        {
            comparePassword();
        }
    }
}
