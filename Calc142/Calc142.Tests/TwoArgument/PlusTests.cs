using System.Linq.Expressions;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Calc142.Tests.TwoArgument
{
    [TestFixture]
    public class PlusTests
    {
        [TestCase(2,3,5)]
        [TestCase(100, 500, 600)]
        [TestCase(50, 2, 52)]
        [TestCase(4, 3, 7)]
        public void AddTest(double firstValue, double secondValue, double expected)
        {
            ITwoArgCalc calculator = new Plus();
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);
        }

    }
}