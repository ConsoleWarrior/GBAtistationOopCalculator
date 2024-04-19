using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBAtistationOopCalculator.model
{
    internal class Calculator : ICalculator
    {
        public double Divide(double a, double b)
        {
            return a / b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Sum(double a, double b)
        {
            return a + b;
        }
    }
}
