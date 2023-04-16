using System;
using System.Windows.Forms;

namespace Projectile_Motion___Final_Year
{
    public partial class fm_userAccount : Form
    {
        private bool deleteData;// to differentiate between "delete account" and "delete data"
        public fm_userAccount()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(fm_userAccount_Closed);
        }

        public static void Create()
        {
            fm_userAccount userAccount = new fm_userAccount();
            userAccount.Show();
        }//create a copy of this form

        public void fm_userAccount_Closed(object sender, EventArgs e)
        {
            Global.EnableForm(new fm_menu().Name);
        }//Activates the Menu form 

        private void fm_userAccount_Load(object sender, EventArgs e)
        {
            lbl_username.Text += Global.User.Username;
            lbl_id.Text += Global.User.ID;
            hideUIObjects();
        }  // Write Information About User

        private void hideUIObjects()//hide all extra UI objects
        {
            txtbx_newPassword.Hide();
            txtbx_oldPassword.Hide();
            lbl_newPassword.Hide();
            lbl_oldPassword.Hide();
            bt_confirm.Hide();
            chkbx_Password.Hide();
        }
        private void showUIObjects()// show all extra UI objects
        {
            txtbx_newPassword.Show();
            txtbx_oldPassword.Show();
            lbl_newPassword.Show();
            lbl_oldPassword.Show();
            bt_confirm.Show();
            chkbx_Password.Show();
        }

        private void bt_changePassword_Click(object sender, EventArgs e)
        {
            deleteData = false;
            showUIObjects();
            lbl_oldPassword.Text = "OLD PASSWORD";
        }
        // changing to "old password" or "password" to differentiate between change password and delete account
        private void bt_deleteAcc_Click(object sender, EventArgs e)
        {
            deleteData = false;
            showUIObjects();
            lbl_oldPassword.Text = "PASSWORD";
            lbl_newPassword.Hide();
            txtbx_newPassword.Hide();
        }

        private void bt_confirm_Click(object sender, EventArgs e)
        {
            if(lbl_oldPassword.Text == "OLD PASSWORD")
            {
                if(txtbx_oldPassword.Text.Trim() == Global.User.Password && txtbx_newPassword.Text.Trim() != "")
                {
                    Global.User.ChangePassword(txtbx_newPassword.Text.Trim());

                    MessageBox.Show("PASSWORD CHANGED");
                    txtbx_newPassword.Text = "";
                    txtbx_oldPassword.Text = "";
                }
                else if(txtbx_newPassword.Text.Trim() == "")
                {
                    MessageBox.Show("ENTER NEW PASSWORD");
                    txtbx_newPassword.Text = "";
                    txtbx_oldPassword.Text = "";
                }
                else
                {
                    MessageBox.Show("WRONG PASSWORD");
                    txtbx_newPassword.Text = "";
                    txtbx_oldPassword.Text = "";
                }
            }
            else
            {
                if(txtbx_oldPassword.Text.Trim() == Global.User.Password && deleteData)
                {
                    Global.User.ClearData();
                    MessageBox.Show("Data Cleared");
                    deleteData = false;
                }else if(txtbx_oldPassword.Text.Trim() == Global.User.Password && !deleteData)
                {
                    Global.User.Delete();
                    Global.User.ClearData();
                    this.Close();
                    MessageBox.Show("ACCOUNT DELETD");
                    Global.EnableForm(new fm_MainForm().Name);
                    Global.OpenHiddenForm(new fm_MainForm().Name);
                }
                else
                {
                    MessageBox.Show("WRONG PASSWORD");
                    txtbx_oldPassword.Text = "";
                }
            }
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }// Closes this form
        private void bt_DeleteData_Click(object sender, EventArgs e)
        {
            showUIObjects();
            lbl_oldPassword.Text = "PASSWORD";
            lbl_newPassword.Hide();
            txtbx_newPassword.Hide();
            deleteData = true;
        }

        private void chkbx_Password_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbx_Password.Checked)
            {
                txtbx_oldPassword.PasswordChar = '\0';
            }
            else
            {
                txtbx_oldPassword.PasswordChar = '*';
            }
        }
    }
}
