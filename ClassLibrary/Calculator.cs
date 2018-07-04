using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Calculator
    {

        public double Sum(double x, double y)
        {
            return (x + y);
        }
        public double Minus(double x, double y)
        {
            return (x - y);
        }
        public double Multiply(double x, double y)
        {
            return (x * y);
        }
        public double Division(double x, double y)
        {
            return (x / y);
        }

    }
}
