using Factorizor3.BLL;
using NUnit.Framework;

namespace Factorizor3.Tests
{
    [TestFixture]
    public class PerfectTests
    {
        [TestCase(6, true)]
        [TestCase(14, false)]
        [TestCase(28, true)]
        public void PrimeTest(int test, bool expected)
        {
            var actual = PerfectChecker.Perfect(FactorFinder.FactFinder(test), test);

            Assert.AreEqual(expected, actual);
        }
    }
}