using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBAtistationOopCalculator.model
{
    internal interface ICalculator
    {
        double Sum(double a, double b);
        double Multiply(double a, double b);
        double Divide(double a, double b);
    }
}
