using System;
using System.IO;
using System.Text;

namespace Laboratory_Work_Two_Core
{
    class Program
    {
		private delegate double Action(double x);

		static void Main(string[] args)
        {

			var paramsDefault = new Params(-10, 10, 0.01);
			CalculateValues(x => MathFunctions.Sin(x), "sin", paramsDefault);
			CalculateValues(x => MathFunctions.Cos(x), "cos", paramsDefault);
			CalculateValues(x => MathFunctions.Exp(x), "exp", paramsDefault);
			CalculateValues(x => PowerSeries.GetArctg(x), "power", new Params(-1, 1, 0.001));

			var positiveParams = new Params(0, 10, 0.01);
			CalculateValues(x => MathFunctions.Ln(x), "ln", positiveParams);
			CalculateValues(x => MathFunctions.Sqrt(x), "sqrt", positiveParams);

			Console.WriteLine("Выполнено!");
			Console.ReadKey();
        }

		private static void CalculateValues(Action action, string name, Params @params)
        {
			string path = $"{name}.csv";
			using (FileStream fs = File.Create(path))
            {
				fs.Close();
            }

            using StreamWriter sw = new StreamWriter(path, false, Encoding.Default);
            for (double x = @params.Start; x < @params.End; x += @params.Step)
            {
                sw.WriteLine($"{x};{action(x)}");
            }
        }

    }
}
