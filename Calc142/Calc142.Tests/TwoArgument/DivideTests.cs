using NUnit.Framework;

namespace Calc142.Tests.TwoArgument
{
      [TestFixture]
    public class DivideTests
    {
          [TestCase(6, 3, 2)]
          [TestCase(50, 25, 2)]
          [TestCase(48, 8, 6)]
          public void DelenieTest(double firstValue, double secondValue, double expected)
        {
            ITwoArgCalc calculator = new Divide();
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);
        }

    }
}