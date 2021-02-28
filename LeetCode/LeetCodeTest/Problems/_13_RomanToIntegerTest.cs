using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _13_RomanToIntegerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            _13_RomanToInteger romanToInteger = new _13_RomanToInteger();
            int result = romanToInteger.RomanToInt("III");

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            _13_RomanToInteger romanToInteger = new _13_RomanToInteger();
            int result = romanToInteger.RomanToInt("III");

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            _13_RomanToInteger romanToInteger = new _13_RomanToInteger();
            int result = romanToInteger.RomanToInt("IX");

            Assert.AreEqual(9, result);
        }
        [TestMethod]
        public void TestMethod4()
        {
            _13_RomanToInteger romanToInteger = new _13_RomanToInteger();
            int result = romanToInteger.RomanToInt("LVIII");

            Assert.AreEqual(58, result);
        }
        [TestMethod]
        public void TestMethod5()
        {
            _13_RomanToInteger romanToInteger = new _13_RomanToInteger();
            int result = romanToInteger.RomanToInt("MCMXCIV");

            Assert.AreEqual(1994, result);
        }
    }
}
