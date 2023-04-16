using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projectile_Motion___Final_Year
{
    public partial class fm_questions : Form
    {
        private struct Answer
        {
            public int ansID;
            public double[] answers;
        }

        User user;
        ListOfQuestions questions;
        Solution solution;
        Answer[] answer;
        Trignomatory trignomatory;

        public fm_questions(User usr)
        {
            user = usr;
            solution = new Solution();
            questions = new ListOfQuestions();
            trignomatory = new Trignomatory();
            InitializeComponent();
        }

        private void solveQues1()
        {
            double u, angle, uX, uY, time, displacement, vY;
            u = questions.Current.ThisQuestion.U;
            angle = questions.Current.ThisQuestion.Angle;
            uX = trignomatory.cos.caculateAdjacent(angle, u);
            uY = trignomatory.sin.caculateOpposite(angle, u);

            time = solution.GetTimeToMaxHeight(uY) * 2;
            displacement = uX * time;

            vY = solution.GetVerticalV(uY, 0);

            answer[0].ansID = 1;
            answer[0].answers = new double[2] { displacement, vY };

        }
        private void solveQues2()
        {
            double u, angle, uX, uY, time, displacement, vY;
            u = questions.Current.ThisQuestion.U;
            angle = questions.Current.ThisQuestion.Angle;
            uX = trignomatory.cos.caculateAdjacent(angle, u);
            uY = trignomatory.sin.caculateOpposite(angle, u);

            time = solution.GetTimeToMaxHeight(uY) * 2;
            answer[1].ansID = 2;
d        }
        private void solveQues3()
        {
            answer[2].ansID = 3;

        }
        private void solveQues4()
        {
            answer[3].ansID = 4;

        }
        private void solveQues5()
        {
            answer[4].ansID = 5;

        }



        private void addQuestions()
        {
            string intro = @"Initial Velocity of an object is U m/s. angle = theta. find: ";
            string[] quessss = new string[2] { "Max displacement", "Its final velocity before it hits the ground." };
            Question temp = new Question(intro, quessss,new int[2] { 2, 3 }, 1, 15, 0, 46);
            questions.Add(temp);

            intro = @"Object is launched from a height of Hm with initial velocity of U m/s at an angle of theta. Find: ";
            quessss = new string[3] {"Max height","Max displacement", "Final velocity of object before it hits the ground." };
            temp = new Question(intro, quessss, new int[3] {1, 2, 3 }, 2, 15, 2, 46);
            questions.Add(temp);

            intro = @"Object is dropped form a height of Hm. Find: ";
            quessss = new string[2] { "Final velocity","Time its take to reach ground." };
            temp = new Question(intro, quessss, new int[2] { 1, 1 }, 3, 15, 2, 46);
            questions.Add(temp);

            intro = @"An object is launched vertically upwards with a velocity of xm/s. find:";
            quessss = new string[2] { "Its final velocity. ", "Time taken to reach the ground. " };
            temp = new Question(intro, quessss, new int[2] { 2,2}, 4, 15, 2, 46);
            questions.Add(temp);

            intro = @"	A cannon Ball is fired at angle of theta at a speed of x m/s. Find: ";
            quessss = new string[1] { "Time taken to reach ground." };
            temp = new Question(intro, quessss, new int[1] { 4 }, 5, 15, 2, 46);
            questions.Add(temp);

            questions.Reset();

            lbl_introduction.Text = questions.Current.ThisQuestion.Introduction;
            lbl_questionNumber.Text = questions.Current.ThisQuestion.ID.ToString();
            lbl_questions.Text = "";
            foreach (string ques in questions.Current.ThisQuestion.Questions)
            {
                lbl_questions.Text += $"{ques}\n";
            }
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            fm_menu menu = new fm_menu(user);
            menu.Show();
            this.Close();
        }
        private void updateMarksLabel()
        {
            lbl_introduction.Text = $"Marks: {user.marksGot} / {user.totoalMarks}";
        }
        private void fm_learnTopic_Load(object sender, EventArgs e)
        {
            updateMarksLabel();
            addQuestions();
            answer = new Answer[questions.Tail.ThisQuestion.ID];
        }

        private void bt_nextQuestion_Click(object sender, EventArgs e)
        {
            questions.Next();

            lbl_introduction.Text = questions.Current.ThisQuestion.Introduction;
            lbl_questionNumber.Text = questions.Current.ThisQuestion.ID.ToString();
            lbl_questions.Text = "";

            foreach (string ques in questions.Current.ThisQuestion.Questions)
            {
                lbl_questions.Text += $"{ques}\n";
            }
        }

        private void bt_previousQuestion_Click(object sender, EventArgs e)
        {
            questions.Previous();

            lbl_introduction.Text = questions.Current.ThisQuestion.Introduction;
            lbl_questionNumber.Text = questions.Current.ThisQuestion.ID.ToString();
            lbl_questions.Text = "";

            foreach (string ques in questions.Current.ThisQuestion.Questions)
            {
                lbl_questions.Text += $"{ques}\n";
            }

        }
    }
}
