using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factorizor3.BLL;
using NUnit.Framework;

namespace Factorizor3.Tests
{
    [TestFixture]
    public class FactorFinderTests
    {
        [TestCase(7, new int[] { 1, 7 })]   //  user input of 7, expected output array of 1,7
        [TestCase(12, new int[] { 1, 2, 3, 4, 6, 12 })]
        [TestCase(15, new int[] { 1, 3, 5, 15 })]
        [TestCase(16, new int[] { 1, 2, 4, 8, 16 })]

        public void FactFinderTest(int test, int[] expected)  //  define test method testing # and expected output from all test cases here
        {
            int[] actual = FactorFinder.FactFinder(test);  // method call with test user input

            Assert.AreEqual(expected, actual);
        }
    }
}