using System;

namespace Calc142
{
    public class Tangent: IOneArgCalc

{
    public double Calculate(double firstArg)
    {
        return Math.Tan(firstArg);
    } 
    }
}