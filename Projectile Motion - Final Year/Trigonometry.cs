using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectile_Motion___Final_Year
{
    static class Trigonometry
    {
        static public double CaculateAdjacent(double theta, double hypo)
        {
            double minValue = Math.Cos(0.5 * Math.PI);
            double cos0 = Math.Cos(theta / 180 * Math.PI) - minValue;

            return hypo * cos0;
        }
        static public double CaculateOpposite(double theta, double hypo)
        {
            return hypo * Math.Sin(theta / 180 * Math.PI);
        }
    }
}
