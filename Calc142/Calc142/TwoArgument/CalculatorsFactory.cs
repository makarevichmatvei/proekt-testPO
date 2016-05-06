using System;

namespace Calc142
{
    public static class CalculatorsFactory 
    {
        public static ITwoArgCalc CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "plus":
                    return new Plus();

                case "minus":
                    return new Minus();
                   
                case "multiply":
                   return new Multiply();
                  
                case "divide":
                 return new Divide();

                case "Power":
                 return new Power();

                case "Percent":
                 return new Percent();

                case "Logorifm":
                 return new Logorifm();
                

                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}