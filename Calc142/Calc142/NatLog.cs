using System;

namespace Calc142
{
    public class NatLog : IOneArgCalc
    {
        public double Calculate(double firstArg)
        {
            return Math.Log10(firstArg);
        } 
    }
}