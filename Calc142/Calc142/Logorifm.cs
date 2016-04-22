using System;

namespace Calc142
{
    public class Logorifm: IOneArgCalc

{
    public double Calculate(double firstArg)
    {
        return Math.Log(firstArg);
    } 
    }
}