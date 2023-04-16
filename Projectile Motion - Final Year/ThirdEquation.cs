using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectile_Motion___Final_Year
{
    static class ThirdEquation
    {
        // v^2 = u^2 + 2as

        static public double CaculateFinalVelocity(double u, double a, double s)
        {
            double num = Math.Pow(u, 2) + 2 * a * s;
            return Math.Sqrt(num);
        }

        static public double CaculateInitialVelocity(double v, double a, double s)
        {
            double num = Math.Pow(v, 2) - 2 * a * s;
            return Math.Sqrt(num);
        }

        static public double CaculateDisplacement(double v, double a, double u)
        {
            double deltaVelocity = Math.Pow(v, 2) - Math.Pow(u, 2);
            return deltaVelocity / (2 * a);
        }
    }
}
