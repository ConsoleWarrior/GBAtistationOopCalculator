using GBAtistationOopCalculator.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBAtistationOopCalculator
{
	internal class Controller
	{
		CalculatorService calculator = new CalculatorService();
		Logger story = new Logger();
		public void WorkWithUSer()
		{
			string str; double result;
			while (true)
			{
				Console.WriteLine("\n- Введите выражение в формате: a+b,a*b,a/b" +
				"\n- Для просмотра истории введите <l>\n- Для выхода введите <q>\n");
				str = Console.ReadLine();
				if (str == "q") return;
				if (str == "l")
				{
					story.PrintLog();
					continue;
				}
				else story.UpdateLog(str);
				if (calculator.TryCalculate(str, out result))
				{
					Console.Write($"= {result}");
					story.UpdateLog($"= {result}");
				}
			}
		}
	}
}
