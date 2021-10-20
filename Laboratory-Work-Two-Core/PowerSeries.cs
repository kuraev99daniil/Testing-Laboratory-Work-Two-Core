using System;

namespace Laboratory_Work_Two_Core
{
    public static class PowerSeries
    {
        public static double eps = 0.0000001;

        public static double GetArctg(double x)
        {
            double function = Math.PI / 2;
            double n = 1;
            double count = 0;

            double expression;
            do
            {
                count++;
                expression = MathFunctions.Power(-1, (int)count % 2) / (MathFunctions.Power(x, (int)n) * n);
                function += expression;
                n += 2;
            } while (MathFunctions.Abs(expression) > eps);

            return function;
        }
    }
}
