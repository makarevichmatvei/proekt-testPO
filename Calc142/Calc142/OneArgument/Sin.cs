using System;

namespace Calc142
{
    public class Sin: IOneArgCalc

{
    public double Calculate(double firstArg)
    {
        return Math.Sin(firstArg);
    }
}
}