using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calc142
{
    public class Power : ITwoArgCalc
    {
        public double Calculate(double firstArg, double secondArg)
        {
            return Math.Pow(firstArg, secondArg);
        }
    }
}
