namespace Laboratory_Work_Two_Core
{
    public static class FunctionSystem
    {
        public static double Calculate(double x)
        {
            if (x <= 0)
            {
                return MathFunctions.Power(((MathFunctions.Sec(x) - MathFunctions.Cot(x) + MathFunctions.Cos(x)) * MathFunctions.Tan(x)) + (MathFunctions.Csc(x) / (MathFunctions.Csc(x) / MathFunctions.Cot(x))), 2);
            }
            else
            {
                return ((MathFunctions.Log(x, 3) - MathFunctions.Log(x, 3) - MathFunctions.Log(x, 5)) * MathFunctions.Power(MathFunctions.Log(x, 10), 2) * (MathFunctions.Ln(x) * (MathFunctions.Log(x, 3) / (MathFunctions.Ln(x) + MathFunctions.Log(x, 10))))) + MathFunctions.Power(MathFunctions.Log(x, 10), 2) + MathFunctions.Log(x, 10);
            }
        }
    }
}
