namespace Calc142
{
    public class Minus : ITwoArgCalc
    {
        public double Calculate(double firstArg, double secondArg)
        {
            return firstArg - secondArg;
        }
    }
}