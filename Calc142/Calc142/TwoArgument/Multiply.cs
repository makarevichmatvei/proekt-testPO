namespace Calc142
{
    public class Multiply : ITwoArgCalc
    {
        public double Calculate(double firstArg, double secondArg)
        {
            return firstArg * secondArg;
        }
    }
}