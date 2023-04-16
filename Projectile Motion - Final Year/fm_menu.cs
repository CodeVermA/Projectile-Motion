using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projectile_Motion___Final_Year
{
    public partial class fm_menu : Form
    {
        Button bt_questions;
        Button bt_topicIntro;

        public static void Create()
        {
            fm_menu fm_Menu = new fm_menu();
            fm_Menu.Show();
        }

        public fm_menu()
        {
            InitializeComponent();
            this.SizeChanged += new EventHandler(fm_Menu_Resize); // Creating a new event handler when form size changes
        }
     
        private void fm_Menu_Resize(object sender, EventArgs e)
        {
            if (bt_questions != null && bt_topicIntro != null)
            {
                // removing button functionality
                this.Controls.Remove(bt_topicIntro);
                this.Controls.Remove(bt_questions);
            }

            setupUI();
            
        } // Check for when form is resized

        private void setupUI()
        {
            // Buttons
            bt_MyQuestions.Location = new Point(this.Width / 2 - (int)(bt_MyQuestions.Width * 2.15), this.Height / 2 + 10);
            bt_openSimulation.Location = new Point(bt_MyQuestions.Location.X + bt_MyQuestions.Width + 5, bt_MyQuestions.Location.Y);
            bt_learnTopic.Location = new Point(bt_openSimulation.Location.X + bt_openSimulation.Width + 5, bt_openSimulation.Location.Y);
            bt_report.Location = new Point(bt_learnTopic.Location.X + bt_learnTopic.Width + 5, bt_learnTopic.Location.Y);

            // Labels
            lbl_earnedMarks.Location = new Point(this.Width / 2 - (int)(lbl_earnedMarks.Width * 1.5) , (int)(this.Height / 3) );
            lbl_Points.Location = new Point(lbl_earnedMarks.Location.X, lbl_earnedMarks.Location.Y + lbl_earnedMarks.Height + 10);
            lbl_percentage.Location = new Point(lbl_Points.Location.X, lbl_Points.Location.Y + lbl_Points.Height +10);

        }

        private void fm_menu_Load(object sender, EventArgs e)
        {
            if (Global.User.LoggedIn == false)
            {
                bt_showAccount.Hide();
            }
            writeInfo();
        }  // To check if its a user or a guest

        private void bt_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Global.OpenHiddenForm(new fm_MainForm().Name);
            Global.EnableForm(new fm_MainForm().Name);
            Global.User = new User();
        } // For Logout

        

        private void bt_showProfile_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            fm_userAccount.Create();
        } // To Show User Profile

        private void writeInfo()
        {
            lbl_Points.Text += Global.User.Points.ToString();
            lbl_earnedMarks.Text += $"{Global.User.MarksGot} / {Global.User.TotoalMarks} ";
            lbl_percentage.Text = $"PERCENTAGE: {Global.User.CalculateMarksPercentage()}%";
        } // Write Information into Labels

        private void bt_report_Click(object sender, EventArgs e)
        {
            if (Global.User.LoggedIn)
            {
                this.Close();
                fm_report.Create();
            }
            else
            {
                MessageBox.Show("Sign Up to see your report");
            }
        } // Show their Report

        private void bt_learnTopic_Click(object sender, EventArgs e)
        {
            setupButtons();
        } // Goes to setupButtons

        private void bt_questions_Click(object sender, EventArgs e)
        {
            fm_questions.Create();
            this.Close();
        } // Opens Question Form

        private void bt_topicIntro_Click(object sender, EventArgs e)
        {
            fm_topicIntro.Create();
            this.Close();
        } // Open Topic Introduction Form

        private void setupButtons()
        {
            bt_questions = new Button();
            bt_topicIntro = new Button();

            this.Controls.Add(bt_questions);
            this.Controls.Add(bt_topicIntro);

            bt_questions.Size = bt_learnTopic.Size;
            bt_topicIntro.Size = bt_learnTopic.Size;

            bt_topicIntro.Text = "Topic IntroDuction";
            bt_questions.Text = "Questions";

            bt_questions.Font = bt_learnTopic.Font;
            bt_topicIntro.Font = new Font(bt_learnTopic.Font.Name, 10, bt_learnTopic.Font.Style);

            bt_questions.Location = new Point(bt_learnTopic.Location.X - bt_questions.Width / 2, bt_learnTopic.Location.Y + 50);
            bt_topicIntro.Location = new Point(bt_learnTopic.Location.X + bt_topicIntro.Width / 2, bt_learnTopic.Location.Y + 50);

            bt_questions.Click += new EventHandler(bt_questions_Click);
            bt_topicIntro.Click += new EventHandler(bt_topicIntro_Click);

            bt_questions.Show();
            bt_topicIntro.Show();
        } // Setup Dynamic Buttons

        private void bt_openSimulation_Click(object sender, EventArgs e)
        {
            this.Close();

            fm_projectileMotion.Create();
        } // Opens Simulation Form

        private void bt_MyQuestions_Click(object sender, EventArgs e)
        {
            if (Global.User.LoggedIn)
            {
                fm_CreateQuestions.Create();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sign Up to use this feature");
            }
            
        } // Open My Question Form

       
    }
}
