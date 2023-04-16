using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projectile_Motion___Final_Year
{
    public partial class fm_MainForm : Form
    {
        public fm_MainForm()
        {
            InitializeComponent();
            this.SizeChanged += new EventHandler(fm_MainForm_Resize); // Creating New Event Handler
        }

        private void bt_Register_Click(object sender, EventArgs e)
        {
            fm_registerUser.Create();// Create fm_Register Form
            this.Enabled = false;// Disable this form
        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            string username = txtbx_username.Text.Trim(),
                password = txtbx_password.Text.Trim();

            if (Global.User.Login(username, password)) //Check Username and Password
            {
                fm_menu.Create(); // Creates fm_Mneu Form
                this.Enabled = false;
                this.Hide();
            }
            else
            {
                MessageBox.Show("INCORRECT USERNAME OR PASSWORD");
            }

            // Empty textboxes
            txtbx_password.Text = "";
            txtbx_username.Text = "";
        }

        private void bt_Guest_Click(object sender, EventArgs e)
        {
            fm_menu.Create();// Create a fm_Menu Form
            this.Enabled = false;
            this.Hide();
        }

        private void setupUI()
        {
            // Labels
            lbl_username.Location = new Point(this.Width / 2 - (int)(lbl_username.Width * 1.5), this.Height / 2 - lbl_username.Height - 5);
            lbl_password.Location = new Point(this.Width / 2 - (int)(lbl_password.Width * 1.5), this.Height / 2);
            lbl_SoftwareName.Location = new Point(this.Width / 2 - lbl_SoftwareName.Width / 2, 50);

            //Text Boxes
            txtbx_username.Location = new Point(lbl_username.Location.X + txtbx_username.Width - 20, lbl_username.Location.Y);
            txtbx_password.Location = new Point(lbl_password.Location.X + txtbx_password.Width - 20, lbl_password.Location.Y);

            //Buttons
            bt_Login.Location = new Point(lbl_password.Location.X + lbl_password.Width - 30, lbl_password.Location.Y + lbl_password.Height + 10);
            bt_Register.Location = new Point(bt_Login.Location.X - bt_Register.Width / 2, bt_Login.Location.Y + bt_Login.Height + 10);
            bt_Guest.Location = new Point(bt_Register.Location.X + bt_Register.Width + 5, bt_Register.Location.Y);

            //CheckBox
            chkbx_Password.Location = new Point(txtbx_password.Location.X + txtbx_password.Width / 2, txtbx_password.Location.Y + txtbx_password.Height + 5);
        }

        private void fm_MainForm_Resize(object sender, EventArgs e)
        {
                setupUI();
             
        }// Checking For Maximizing/Minimizing Form

        private void fm_MainForm_Load(object sender, EventArgs e)
        {
            setupUI(); // Moves the UI Objects to Centre of the screen
        }

        private void chkbx_Password_CheckedChanged(object sender, EventArgs e)
        {
            if(chkbx_Password.Checked)
            {
                txtbx_password.PasswordChar = '\0'; //changing characters back to normal
            }
            else
            {
                txtbx_password.PasswordChar = '*';// changing all character to *
            }
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
