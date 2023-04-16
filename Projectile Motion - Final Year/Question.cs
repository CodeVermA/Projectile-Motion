using System;

namespace Projectile_Motion___Final_Year
{
    class Question
    {
        private Database database;
        public string Introduction { get; protected set; }
        public string[] Questions { get; protected set; }
        public int[] Marks { get; protected set; }
        public int ID{get; protected set;}
        public int U { get; protected set; }
        public int InitialHeight {get; protected set;}
        public int Angle{get; protected set;}
        public double[] Answers { get; protected set; }
        protected Solution solution;

        public Question()
        {
            solution = new Solution();
            database = new Database();
        }

        protected virtual double[] Solve()
        {
            return new double[2];
        } //set new Values of Initial Velocity, Initial Height and angle

        public void Export(string path, System.Windows.Forms.DataGridViewSelectedRowCollection rows)
        {
            System.IO.FileStream stream = new System.IO.FileStream(path, System.IO.FileMode.Create, System.IO.FileAccess.Write); //creating and limiting the access of the file
            System.IO.StreamWriter writer = new System.IO.StreamWriter(stream);// giving the the file to writer

            int x = 1;
            foreach (System.Windows.Forms.DataGridViewRow row in rows)// to make the written questions easire to understand
            {
                writer.WriteLine($"{x}. {row.Cells[0].Value}");
                string[] ques = row.Cells[1].Value.ToString().Trim().Split('\n');
                string[] marks = row.Cells[2].Value.ToString().Trim().Split('\n');

                for(int y = 0; y < ques.Length; y++)
                {
                    writer.WriteLine($"\t{ques[y]}   {marks[y]}");
                }
                writer.WriteLine();
                x++;
            }
            writer.Close();
        }
        protected void SetValues(bool isThrownFromHeight, bool angleNeeded, bool hasInitialVelocity)
        {
            U = (hasInitialVelocity) ? Global.Random.Next(2, 30) : 0;
            Angle = (angleNeeded) ? Global.Random.Next(5, 89) : 0; 
            InitialHeight = (isThrownFromHeight) ? Global.Random.Next(2,15) : 0;
        }// randomly sets new vaues

        public System.Data.DataTable Load(int userId)
        {
            System.Data.DataTable myQuestions = database.Get_Questions(Global.User.ID);
            return myQuestions;
        } // load all the questions where userID matches

        public void Save(string introduction, string[] question, int[] marks)
        {
            int introId = database.InsertInto_QuestionIntro(Global.User.ID, introduction);// add the Question Intro to table 

            for (int x = 0; x < question.Length; x++)
            {
                database.Insert_Question(introId, marks[x], question[x]);// adds each question to table
            }
        }

        public virtual void Update()
        {
        }

        public void Delete(int introductionID)
        {
            database.Delete_Question(introductionID);
        }// deletes all the question and introductions where id matches

        public int[] CheckAnswers(double[] userAnswers)
        {
            int[] marksEarned = new int[Answers.Length];

            for(int x = 0; x < Answers.Length; x++)
            {
                if(Math.Abs(userAnswers[x]) == Math.Abs(Answers[x]))
                {
                    marksEarned[x] = Marks[x];
                }
                else
                {
                    marksEarned[x] = 0;
                }
            }

            return marksEarned;
        }
    }
}
