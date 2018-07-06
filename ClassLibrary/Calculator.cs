using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// TODO: Решарпер поставил, если поставил, то можешь видеть что этот наймспыс не используется, поэтому он подсвечен серопрозрачным,
// TODO: используй постоянно Ctrl+Alt+F чтобы отформатировать код

namespace ClassLibrary // TODO: По хорошему бы надо заводить свой крассивый наймспейс
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
