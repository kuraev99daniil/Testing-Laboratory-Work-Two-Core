using System;
using static Laboratory_Work_Two_Core.MathFunctions;

namespace Laboratory_Work_Two_Core
{
    public static class FunctionSystem
    {
        public static double Calculate(double x)
        {
            if (x <= 0)
            {
                return Power(((MathFunctions.Sec(x) - MathFunctions.Cot(x) + Cos(x)) * Tan(x)) + (MathFunctions.Csc(x) / (MathFunctions.Csc(x) / MathFunctions.Cot(x))), 2);
            }
            else
            {
                return ((Log(x, 3) - Log(x, 3) - Log(x, 5)) * Power(Log(x, 10), 2) * (Ln(x) * (Log(x, 3) / (Ln(x) + Log(x, 10))))) + Power(Log(x, 10), 2) + Log(x, 10);
            }
        }

        public static double CalculateByDefaultMethods(double x)
        {
            if (x <= 0)
            {
                return Math.Pow(((Sec(x) - Cot(x) + Math.Cos(x)) * Math.Tan(x)) + (Csc(x) / (Csc(x) / Cot(x))), 2);
            }
            else
            {
                return ((Math.Log(x, 3) - Math.Log(x, 3) - Math.Log(x, 5)) * Math.Pow(Math.Log(x, 10), 2) * (Math.Log(x) * (Math.Log(x, 3) / (Math.Log(x) + Math.Log(x, 10))))) + Math.Pow(Math.Log(x, 10), 2) + Math.Log(x, 10);
            }
        }

        private static double Sec(double x)
        {
            return 1 / Math.Cos(x);
        }

        private static double Cot(double x)
        {
            return Math.Cos(x) / Math.Sin(x);
        }

        private static double Csc(double x)
        {
            return 1 / Math.Sin(x);
        }
    }
}
