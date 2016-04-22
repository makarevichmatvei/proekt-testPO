using System;

namespace Calc142
{
    public static class OneCalculatorsFactory
    {
        public static IOneArgCalc CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Sin":
                    return new Sin();

                case "Cos":
                    return new Cos();

                case "Exp":
                    return new Exp();

                case "Sqrt":
                    return new Sqrt();

                case "Tangent":
                    return new Tangent();

               

                case "Logorifm":
                    return new Logorifm();

                case "NatLog":
                    return new NatLog();

                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}