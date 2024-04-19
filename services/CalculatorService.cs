using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GBAtistationOopCalculator.model;

namespace GBAtistationOopCalculator.services
{
    internal class CalculatorService
	{
		ICalculator calculator = new Calculator();
		public bool TryCalculate(string str, out double result)
		{
			var splitStr = str.Replace(" ", "").Split(['+', '*', '/']);
			result = 0;
			if (splitStr.Length != 2)
			{
				Console.WriteLine("Wrong input!");
				return false;
			}

			if (Double.TryParse(splitStr[0], out double a) && Double.TryParse(splitStr[1], out double b) && b != 0)
			{
				string sign = str.Replace(" ", "").Replace(splitStr[0], "").Replace(splitStr[1], "");
				switch (sign)
				{
					case "+": result = calculator.Sum(a, b); return true; 
					case "*": result = calculator.Multiply(a, b); return true; 
					case "/": result = calculator.Divide(a, b); return true; 
				};
			}
			return false;
		}
	}
}
