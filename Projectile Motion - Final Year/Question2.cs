using System;

namespace Projectile_Motion___Final_Year
{
    class Question2 : Question
    {
        //Object is launched from a height of Hm with initial velocity of U m/s at an angle of theta.

        public Question2()
        {
            //adds information about the question
            Introduction = @"Object is launched from a height of Hm with initial velocity of U m/s at an angle of theta. Find: ";
            Questions = new string[3] { "Max height object reaches", "Max displacement of the object", "Final vertical velocity of object." };
            Marks = new int[3] { 1, 2, 3 };
            ID = 2;
            SetValues(true, true,true);
            Answers = Solve();
        }

        public override void Update()
        {
            SetValues(true, true, true);
            Answers = Solve();
        }//update the values

        protected override double[] Solve()
        {
            double[] answer = new double[3];
            double uX, uY, time, displacement, vY,height;

            uX = Trigonometry.CaculateAdjacent(Angle, U);
            uY = Trigonometry.CaculateOpposite(Angle, U);

            //Part A
            time = Solution.GetTimeToMaxHeight(uY);
            height = Solution.GetMaxHeight(uY, time, InitialHeight);
            answer[0] = Math.Round(height,2);

            //Part B
            time = Solution.GetTime(uY, InitialHeight);
            displacement = uX * time;
            answer[1] = Math.Round(displacement,2);

            //Part C
            vY = Solution.GetVerticalV(uY,InitialHeight);
            answer[2] = Math.Round(vY,2);

            return answer;
        }//set new Values of Initial Velocity, Initial Height and angle
    }
}
