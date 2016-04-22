using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calc142
{
    public class Exp: IOneArgCalc

{
    public double Calculate(double firstArg)
    {
        return Math.Exp(firstArg);
    }
}
    
}
