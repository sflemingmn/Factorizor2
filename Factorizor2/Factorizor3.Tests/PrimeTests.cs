using Factorizor3.BLL;
using NUnit.Framework;

namespace Factorizor3.Tests
{
    [TestFixture]
    public class PrimeTests
    {
        [TestCase(7, true)]
        [TestCase(10, false)]
        [TestCase(19, true)]
        public void PrimeTest(int test, bool expected)
        {
            var actual = PrimeChecker.Prime(FactorFinder.FactFinder(test));

            Assert.AreEqual(expected, actual);
        }
    }
}