using NUnit.Framework;

namespace Calc142.Tests.OneArgument
{
      [TestFixture]
    public class SinTests
    {
          [TestCase(0, 0)]
          [TestCase(1, 0.84147)]
          [TestCase(4, -0.75680)]
          public void SinusTest(double firstValue, double expected)
          {
              IOneArgCalc calculator = new Sin();
              double result = calculator.Calculate(firstValue);
              Assert.AreEqual(expected, result, 0.00001);
          }
    }
}