using System;

namespace Projectile_Motion___Final_Year
{
    class Question3 : Question
    {

        ///@"Object is dropped form a height of Hm. Find: "; quessss = new string[2] { "Final vertical velocity", "Time its take to reach ground." }
        public Question3()
        {
            //add the information about the question
            Introduction = @"Object is dropped form a height of Hm. Find: ";
            Questions = new string[2] { "Final vertical velocity", "Time its take to reach ground." };
            Marks = new int[2] { 1, 1 };
            ID = 3;
            SetValues(true, false, false);
            Answers = Solve();
        }

        public override void Update()
        {
            SetValues(true, false, false);
            Answers = Solve();
        }//set new Values of Initial Velocity, Initial Height and angle

        protected override double[] Solve()
        {
            double[] answer = new double[2];
            double uY, time, vY;

            uY = Trigonometry.CaculateOpposite(Angle, U);

            //Part A
            vY = Solution.GetVerticalV(0, InitialHeight);
            answer[0] = Math.Round(vY,2);

            //Part B
            time = Math.Sqrt((2 * -InitialHeight) / -9.81);
            answer[1] = Math.Round(time,2);

            return answer;
        }//solve the questions
    }
}
