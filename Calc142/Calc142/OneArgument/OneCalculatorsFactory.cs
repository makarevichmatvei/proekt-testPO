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

                case "Log10":
                    return new Log10();

                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}