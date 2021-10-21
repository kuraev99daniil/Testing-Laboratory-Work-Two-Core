using System;

namespace Laboratory_Work_Two_Core
{
    public static class PowerSeries
    {
        public static double GetArctg(double x, int n = 0, double precision = 0.001)
        {
            double t = MathFunctions.Power(-1, n) * MathFunctions.Power(x, 2 * n + 1) / (uint)(2 * n + 1);
            
            if (MathFunctions.Abs(t) < precision)
            {
                return t;
            }

            return t + GetArctg(x, n + 1, precision);
        }
    }
}
