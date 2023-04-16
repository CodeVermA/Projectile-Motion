using System;

namespace Projectile_Motion___Final_Year
{
    class Question1 : Question
    {
        public Question1()
        {
            //adds information about the question
            Introduction = @"Initial Velocity of an object is U m/s. angle = theta. find:";
            Questions = new string[2] { "Max displacement of the Object", "Objects final vertical velocity." };
            Marks = new int[2] { 2, 3 };
            ID = 1;
            SetValues(false, true, true);
            Answers = Solve();
        }

        protected override double[] Solve()// solve the question and save answers
        {
            double[] answer = new double[2];
            double uX, uY, time, displacement, vY;

            uX = Trigonometry.CaculateAdjacent(Angle, U);
            uY = Trigonometry.CaculateOpposite(Angle, U);

            //Part A
            time = Solution.GetTimeToMaxHeight(uY) * 2;
            displacement = uX * time;
            answer[0] = Math.Round(displacement,2);

            //Part B
            vY = Solution.GetVerticalV(uY, 0);            
            answer[1] = Math.Round(vY,2);

            return answer;
        }

        public override void Update()//set new Values of Initial Velocity, Initial Height and angle 
        {
            SetValues(false, true, true);
            Answers = Solve();
        }
    }
}
