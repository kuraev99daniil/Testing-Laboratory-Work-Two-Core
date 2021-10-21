using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Globalization;
using System.IO;

namespace Laboratory_Work_Two_Core
{
    class Program
    {
        static void Main(string[] args)
        {
			if (!File.Exists("File.csv"))
			{
				File.Create("File.csv");
			}
			StreamWriter sw = new StreamWriter("File.csv");
			Console.Write("Нужная функция(sin,cos,log,ln,sqrt,expression:");
			string func = Console.ReadLine();
			Console.WriteLine("Введите стартовое значение");
			double start = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Введите шаг функции");
			double step = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Введите конечное значение");
			double end = Convert.ToDouble(Console.ReadLine());
			using var csv = new CsvWriter(sw, new CsvConfiguration(CultureInfo.InvariantCulture) { Delimiter = ";" });
			for (double i = start; i < end; i += step)
			{
				double result = 0;
				if (func == "sin")
				{ 
					result = MathFunctions.Sin(i);
				}
				if (func == "cos")
				{ 
					result = MathFunctions.Cos(i); 
				}
				if (func == "ln")
				{ 
					result = MathFunctions.Ln(i);
				}
				if (func == "sqrt")
				{ 
					result = MathFunctions.Sqrt(i);
				}
				if (func == "exp")
				{ 
					result = FunctionSystem.Calculate(i);
				}

				csv.WriteRecord(new { X = func + $"({i})", Result = result });

				csv.NextRecord();
			}

			Console.WriteLine($"Результаты вычисления функции {func} сохранены в File.csv");

			Console.ReadKey();
        }
    }
}
