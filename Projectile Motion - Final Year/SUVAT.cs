using System;

namespace Projectile_Motion___Final_Year
{
    static class SUVAT
    {
        private static double acceleration = -9.81;

        static public double CaculateDisplacement(double u, double v, double t)//Calculate the distance travelled by the object by u, v, t
        {
            double averageVelocity = (u + v) / 2;
            return averageVelocity * t;
        }
        static public double CaculateDisplacement(double v, double u)//Calculate the distance travelled by the object by u, v, a
        {
            double deltaVelocity = Math.Pow(v, 2) - Math.Pow(u, 2);
            return deltaVelocity / (2 * acceleration);
        }

        static public double CaculateTime(double v, double u, double a)// caculate time taken by the object
        {
            return (v - u) / a;
        }

        static public double CaculateFinalVelocity(double u, double a, double s)// calculates final velocity of the object
        {
            double num = Math.Pow(u, 2) + 2 * a * s;
            return Math.Sqrt(num);
        }

        
    }
}
