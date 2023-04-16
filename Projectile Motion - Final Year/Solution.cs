namespace Projectile_Motion___Final_Year
{
    class Solution
    {
        const double acceleration = -9.81;
    
        public static double GetDisplacement(double horizontalU, double time)
        {
            double s = 0;
            s = horizontalU * time;
            return s;
        }//returns the distance travelled by the object
        public static double GetMaxHeight(double verticalU, double time, double initialHeight)
        {
            double height = 0;
            height = SUVAT.CaculateDisplacement(verticalU, 0, time);
            return height + initialHeight;

        } //return the highest high reaches by the th eobject
        public static double GetTime(double verticalU, double initialHeight)
        {
            double time = 0, extraTime = 0, v;

            time = SUVAT.CaculateTime(0, verticalU, acceleration) *2;
            v = SUVAT.CaculateFinalVelocity(-verticalU, acceleration, -initialHeight);
            extraTime = SUVAT.CaculateTime(v, verticalU, -acceleration);

            return time + extraTime;
        }// return the total time of travel
        public static double GetTimeToMaxHeight(double verticalU)// time taken to reach highest height
        {
            return SUVAT.CaculateTime(0, verticalU, acceleration);
        }
        public static double GetVerticalV(double verticalU, double initialHeight)
        {
            double verticalV = 0;

            if(initialHeight > 0)
            {
                verticalV = SUVAT.CaculateFinalVelocity(-verticalU, acceleration, -initialHeight);
            }
            else
            {
                verticalV = -verticalU;
            }

            return verticalV;
        }//return the vertical velocity of the object at the end
    }
}
