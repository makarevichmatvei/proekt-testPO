using System;

namespace Calc142
{
    public class Percent: ITwoArgCalc

{
    public double Calculate(double firstArg, double secondArg)
    {
        return (firstArg * secondArg) / 100;
    } 
    }
}