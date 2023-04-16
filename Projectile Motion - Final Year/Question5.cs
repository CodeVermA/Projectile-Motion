using System;

namespace Projectile_Motion___Final_Year
{
    class Question5 : Question
    {
        public Question5()
        {
            //add the information about the question
            Introduction = @"A cannon Ball is fired from a height of Hm at angle of theta at a speed of x m/s. Find: ";
            Questions = new string[2] { "Time it takes to reach the ground. ", "Max Displacement." };
            Marks = new int[2] { 3, 2 };
            ID = 5;
            SetValues(true, true,true);
            Answers = Solve();
        }

        public override void Update()//set new Values of Initial Velocity, Initial Height and angle
        {
            SetValues(true, true,true);
            Answers = Solve();
        }

        protected override double[] Solve()//solve the questions
        {
            double[] answer = new double[2];
            double uY, uX, time, displacement;

            uY = Trigonometry.CaculateOpposite(Angle, U);

            //Part A
            uY = Trigonometry.CaculateOpposite(Angle, U);
            uX = Trigonometry.CaculateAdjacent(Angle, U);

            time = Solution.GetTime(uY, InitialHeight);
            answer[0] = Math.Round(time,2);

            //Part B
            displacement = uX * time;
            answer[1] = Math.Round(displacement,2);


            return answer;
        }
    }
}
