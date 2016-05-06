using System;

namespace Calc142
{
    public class Log10 : IOneArgCalc
    {
        public double Calculate(double firstArg)
        {
            return Math.Log10(firstArg);
        } 
    }
}