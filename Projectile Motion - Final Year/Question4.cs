using System;

namespace Projectile_Motion___Final_Year
{
    class Question4 : Question
    {
        //@"An object is launched vertically upwards with a velocity of xm/s. find:";quessss = new string[2] { "Its vertical final velocity. ", "Time taken to reach the ground. " };
    public Question4()
        {
            //add the information about the question
            Introduction = @"An object is launched vertically upwards from a height of Hm with a velocity of xm/s. find:";
            Questions = new string[2] { "Max Height. ", "Time taken to reach the ground. " };
            Marks = new int[2] { 2, 2 };
            ID = 4;
            SetValues(true, false, true);
            Answers = Solve();

        }

        public override void Update()//set new Values of Initial Velocity, Initial Height and angle
        {
            SetValues(true, false, true);
            Answers = Solve();
        }

        protected override double[] Solve()//solve the questions
        {
            double[] answer = new double[2];
            double time, height;

            //Part A
            height = Solution.GetMaxHeight(U, Solution.GetTimeToMaxHeight(U), InitialHeight);
            answer[0] = Math.Round(height,2);

            //Part B
            time = Solution.GetTime(U, InitialHeight);
            answer[1] = Math.Round(time,2);

            return answer;
        }
    }
}
