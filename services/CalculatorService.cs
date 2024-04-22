using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GBAtistationOopCalculator.model;

namespace GBAtistationOopCalculator.services
{
	internal class CalculatorService : ICalculatorService
	{
		ICalculator calculator = new Calculator();

		public bool TryCalculate(string str, out double result)
		{
			str = str.Replace(" ", "");
			result = 0;
			var splitStr = str.Split(['+', '*', '/']);
			if (splitStr.Length != 2 || !Double.TryParse(splitStr[0], out double a) || !Double.TryParse(splitStr[1], out double b))
			{
				Console.WriteLine("Неверный ввод!");
				return false;
			}

			string sign = str.Replace(splitStr[0], "").Replace(splitStr[1], "");
			switch (sign)
			{
				case "+": result = calculator.Sum(a, b); return true;
				case "*": result = calculator.Multiply(a, b); return true;
				case "/":
					if (b == 0) { Console.WriteLine("Деление на ноль невозможно!"); return false; }
					else result = calculator.Divide(a, b); return true;
			};
			return false;
		}
	}
}
