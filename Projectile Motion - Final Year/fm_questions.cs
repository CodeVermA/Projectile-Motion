using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projectile_Motion___Final_Year
{
    public partial class fm_questions : Form
    {
        ListOfQuestions questions;
        Question1 question1;
        Question2 question2;
        Question3 question3;
        Question4 question4;
        Question5 question5;
        TextBox[] txtbxForAnswers;

        public fm_questions()
        {
            questions = new ListOfQuestions();
            InitializeComponent();
            this.SizeChanged += new EventHandler(fm_questions_Resize);
        }

        private void fm_questions_Resize(object sender, EventArgs e)
        {
            setupUI();
        }

        private void setupQuestionUI()
        {
            lbl_questionNumber.Location = new Point(this.Width / 12, this.Height / 5);
            lbl_introduction.Location = new Point(lbl_questionNumber.Location.X, lbl_questionNumber.Location.Y + lbl_questionNumber.Height + 5);
            lbl_questions.Location = new Point(lbl_introduction.Location.X, lbl_introduction.Location.Y + lbl_introduction.Height + 5);

            lbl_initialVelocity.Location = new Point(lbl_introduction.Location.X + lbl_introduction.Width + 30, lbl_questionNumber.Location.Y + 5);
            lbl_InitialHeight.Location = new Point(lbl_initialVelocity.Location.X, lbl_initialVelocity.Location.Y + lbl_initialVelocity.Height + 5);
            lbl_Angle.Location = new Point(lbl_InitialHeight.Location.X, lbl_InitialHeight.Location.Y + lbl_InitialHeight.Height + 5);

            //Textboxes
            int offset = lbl_questions.Location.X + 30;
            foreach (TextBox textbox in txtbxForAnswers)
            {
                textbox.Location = new Point(offset, lbl_questions.Location.Y + lbl_questions.Height + 30);
                offset += textbox.Width + 5;
            }
        }

        private void setupUI()
        {
            //Labels
            lbl_instruction.Location = new Point(this.Width / 2 - lbl_instruction.Width / 2, bt_exit.Location.Y);
            lbl_Marks.Location = new Point(lbl_instruction.Location.X + lbl_instruction.Width + 5, lbl_instruction.Location.Y);

            setupQuestionUI();

            //Buttons
            bt_SubmitAnswers.Location = new Point(this.Width / 2 - bt_SubmitAnswers.Width - 2, (int)(this.Height * 0.8));
            bt_changeNumbers.Location = new Point(this.Width / 2 + 2, (int)(this.Height * 0.8));
            bt_previousQuestion.Location = new Point(10, this.Height - 100);
            bt_nextQuestion.Location = new Point(this.Width - bt_nextQuestion.Width - 25, this.Height - 100);
        }

        public static void Create()
        {
            fm_questions fm_Questions = new fm_questions();
            fm_Questions.Show();
        }
        private void addQuestions()
        {
            //Ques1
            question1 = new Question1();
            questions.Add(question1);

            //Ques2
            question2  = new Question2();
            questions.Add(question2);

            //Ques3
            question3 = new Question3();
            questions.Add(question3);

            //Ques4
            question4 = new Question4();
            questions.Add(question4);

            //Ques5
            question5 = new Question5();
            questions.Add(question5);

            questions.Reset();
            writeQuesInfo();
        }// add question to link list

        private void bt_exit_Click(object sender, EventArgs e)
        {
            fm_menu.Create();
            this.Close();
        }

        private void updateMarksLabel()
        {
            lbl_introduction.Text = $"Marks: {Global.User.MarksGot} / {Global.User.TotoalMarks}";
        }// update marks

        private void fm_learnTopic_Load(object sender, EventArgs e)
        {
            txtbxForAnswers = new TextBox[3] { txtbx_AnsPart1, txtbx_AnsPart2, txtbx_AnsPart3 };

            updateMarksLabel();
            addQuestions();
            provideAnsTextboxes();

            //checking whether to show the marks or not
            lbl_Marks.Text = $"Marks: {Global.User.MarksGot}/{Global.User.TotoalMarks}";

            setupUI();
        }

        private void bt_nextQuestion_Click(object sender, EventArgs e)
        {
            questions.Next();
            provideAnsTextboxes();
            writeQuesInfo();
            setupQuestionUI();
        }//go to next question and provide needed textboxes

        private void bt_previousQuestion_Click(object sender, EventArgs e)
        {
            questions.Previous();
            writeQuesInfo();
            provideAnsTextboxes();
            setupQuestionUI();
        }//go to previous question and provide needed textboxes

        private void bt_changeNumbers_Click(object sender, EventArgs e)
        {
            questions.Current.ThisQuestion.Update();
            writeQuesInfo();
        }//change the values in the question

        private void writeQuesInfo()
        {
            lbl_introduction.Text = questions.Current.ThisQuestion.Introduction;
            lbl_questionNumber.Text = $"Ques: {questions.Current.ThisQuestion.ID.ToString()}";
            lbl_questions.Text = "";

            string letters = "abc"; 

            for(int x = 0; x < questions.Current.ThisQuestion.Questions.Length; x++)
            {
                lbl_questions.Text += $"{letters[x]}> {questions.Current.ThisQuestion.Questions[x]} ({questions.Current.ThisQuestion.Marks[x]})\n";
            }

            lbl_Angle.Text = (questions.Current.ThisQuestion.Angle > 0) ? $"Angle: {questions.Current.ThisQuestion.Angle}" : $"Angle: X";
            lbl_InitialHeight.Text = $"Initial Height: {questions.Current.ThisQuestion.InitialHeight}";
            lbl_initialVelocity.Text = $"Initial Velocity(U): {questions.Current.ThisQuestion.U}";
        }// Shows the question

        private bool validateAnswers()
        {
            double i;
            for (int x = 0; x < questions.Current.ThisQuestion.Questions.Length; x++)
            {
                if (double.TryParse(txtbxForAnswers[x].Text.Trim(), out i) == false)
                {
                    return false;
                }
               
            }
            return true;
        }

        private void bt_SubmitAnswers_Click(object sender, EventArgs e)
        {
            if (validateAnswers())
            {
                markAnswers();
                lbl_Marks.Text = $"MARKS: {Global.User.MarksGot}/{Global.User.TotoalMarks}";
            }
            else if (!validateAnswers())
            {
                MessageBox.Show("Enter Integers");
            }
            else
            {
                MessageBox.Show("You have already answered this question");
            }
            
        }

        private void markAnswers()// mark answers and shows what they got wrong
        {
            bool allCorrect = true;
            double[] userAnswers = new double[questions.Current.ThisQuestion.Questions.Length];

            for (int x = 0; x < questions.Current.ThisQuestion.Questions.Length; x++)
            {
                if (txtbxForAnswers[x].Text.Trim() != "")
                {
                    double ans = Convert.ToDouble(txtbxForAnswers[x].Text);
                    userAnswers[x] = Math.Round(ans, 2);
                }
                else
                {
                    userAnswers[x] = 0;
                }

            }
            string letters = "abc";
            int[] marksEarned = questions.Current.ThisQuestion.CheckAnswers(userAnswers);
            string msg = "You Got Part ";

            for (int x = 0; x < marksEarned.Length; x++)
            {
                if (marksEarned[x] == 0)
                {
                    msg += (allCorrect) ? $"{letters[x]} " : $", {letters[x]} ";
                    allCorrect = false;
                }
            }
            
            if (allCorrect)
            {
                MessageBox.Show("All Correct (^-^)");
                questions.Current.ThisQuestion.Update();
                writeQuesInfo();
            }
            else
            {
                MessageBox.Show(msg + "Wrong");
            }
            addMarks(marksEarned);
        }
        private void addMarks(int[] marksEarned)// add marks earned to user profile
        {
            int marksGot = 0;
            int totalMarks = 0;

            foreach (int mark in marksEarned)
            {
                marksGot += mark;
            }
            foreach (int mark in questions.Current.ThisQuestion.Marks)
            {
                totalMarks += mark;
            }
            Global.User.TotoalMarks += totalMarks;
            Global.User.MarksGot += marksGot;

            if (Global.User.LoggedIn)
            {
                Global.User.UpdatePoints();
                Global.User.AddReport(marksGot, "Questions", DateTime.Now);
            }
            
        }
        private void provideAnsTextboxes()
        {
            // hide all answer textboxes
            txtbxForAnswers[0].Hide();
            txtbxForAnswers[1].Hide();
            txtbxForAnswers[2].Hide();

            for (int x = 0; x < questions.Current.ThisQuestion.Questions.Length; x++)
            {
                txtbxForAnswers[x].Text = "";
                txtbxForAnswers[x].Show();
            }
        }// load answer textboxes depending on how many needed to answer the question

    }
}
