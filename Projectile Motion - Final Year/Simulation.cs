using System.Drawing;

namespace Projectile_Motion___Final_Year
{
    class Simulation
    {
        public double U, Angle, InitialHeight, Ux, Uy, Time, Height, 
            Displacement, TimeToMaxHeight,
            acceleration = -9.81, Vy;

        private int xOffset = 5;

        public PointF[] Coordinates;// points for drawing curve 

        public Simulation(double u, double angle, double initialHeight)
        {
            U = u;
            Angle = angle;
            InitialHeight = initialHeight;
        }
        
        public Simulation()
        {
        }

        public string ShowFormulas()
        {
            return "--> We Need To Resolve Vertical And Horizonatal Component Sepreately.\n" +
                "1. Ux = U * Cos(θ)\n" +
                "2. Uy = U * Sin(θ)\n" +
                "\n--> Vertical Velocity At Max Height Is 0m/s\n" +
                "3. Time To Reach Max Height = (Vy - Uy) / Acceleration(-9.81)\n" +
                "4. Max Height = [ (Vy^2 - Uy^2) / 2 * Acceleration ] + Initial Height(If Object Had Initial Height) \n" +
                "\n--> If Object Had Initial Height Than We Need To Find The Velocity Before Hitting The Ground \n" +
                "   Else We Can Just Double the Time To Max Height Because Air resistance Is Not Present\n" +
                "5. Vy = √(Uy^2 + 2 * Acceleration * Max Height)\n" +
                "6. Time = [ (Vy - Uy) / Acceleration ] + Time To Reach Max Height\n" +
                "7. Displacement = Ux * Time";
        }//returns the formulas used

        public void CalculateValues()
        {
            Ux = Trigonometry.CaculateAdjacent(Angle, U); 
            Uy = Trigonometry.CaculateOpposite(Angle, U);
            TimeToMaxHeight = SUVAT.CaculateTime(0, Uy, acceleration);
            Height = SUVAT.CaculateDisplacement(0, Uy) + InitialHeight;

            if(InitialHeight > 0)
            {
                Vy = SUVAT.CaculateFinalVelocity(0, acceleration, -Height);
                Time = TimeToMaxHeight + SUVAT.CaculateTime(-Vy, 0, acceleration);
            }
            else
            {
                Time = TimeToMaxHeight * 2;
            }

            Displacement = Time * Ux;
        }//Calculate values about the motion

        public void CalculateCordinates()
        {
            Coordinates = new PointF[3];

            Coordinates[0].X = ((Angle == 90 || U == 0) && InitialHeight != 0) ? xOffset : 0;
            Coordinates[0].Y = (float)InitialHeight;

            Coordinates[1].X = ((Angle == 90 || U == 0) && InitialHeight != 0) ? xOffset : (float)(Ux * TimeToMaxHeight);
            Coordinates[1].Y = (float)(Height);

            Coordinates[2].X = ((Angle == 90 || U == 0) && InitialHeight != 0) ? xOffset : (float)Displacement;
            Coordinates[2].Y = 0;
        } // calculate the corrdinates and save it points list
    }
}
