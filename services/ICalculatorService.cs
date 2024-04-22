using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBAtistationOopCalculator.services
{
	internal interface ICalculatorService
	{
		public bool TryCalculate(string str, out double result);
	}
}
