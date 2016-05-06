using System;

namespace Calc142
{
    public class Sqrt: IOneArgCalc

{
    public double Calculate(double firstArg)
    {
        return Math.Sqrt(firstArg);
    }
}
    
}      
