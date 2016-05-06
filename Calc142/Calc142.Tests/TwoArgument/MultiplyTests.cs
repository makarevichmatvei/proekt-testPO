using NUnit.Framework;

namespace Calc142.Tests.TwoArgument
{
      [TestFixture]

    public class MultiplyTests
    {
        [TestCase(2,3,6)]
        [TestCase(100, 5, 500)]
        [TestCase(4, 7, 28)]
        public void UmnoghenieTest(double firstValue, double secondValue, double expected)
        {
            ITwoArgCalc calculator = new Multiply();
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);
        }
    }
}