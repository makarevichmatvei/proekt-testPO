using System;

namespace Calc142
{
    public class Logorifm: ITwoArgCalc

{
    public double Calculate(double firstArg, double secondArg)
    {
        return Math.Log(firstArg, secondArg);
    } 
    }
}