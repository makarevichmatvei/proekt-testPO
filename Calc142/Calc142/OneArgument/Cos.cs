using System;

namespace Calc142
{
    public class Cos : IOneArgCalc
    {
        public double Calculate(double firstArg)
        {
            return Math.Cos(firstArg);
        }  
    }
}