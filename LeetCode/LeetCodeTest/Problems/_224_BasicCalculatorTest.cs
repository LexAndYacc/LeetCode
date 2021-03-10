using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCode.Problems._232_ImplementQueueUsingStacks;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _224_BasicCalculatorTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            string s = "1 + 1";
            _224_BasicCalculator basicCalculator = new _224_BasicCalculator();
            int result = basicCalculator.Calculate(s);

            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string s = "2-1 + 2";
            _224_BasicCalculator basicCalculator = new _224_BasicCalculator();
            int result = basicCalculator.Calculate(s);

            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            string s = "(1+(4+5+2)-3)+(6+8)";
            _224_BasicCalculator basicCalculator = new _224_BasicCalculator();
            int result = basicCalculator.Calculate(s);

            Assert.AreEqual(23, result);
        }
        [TestMethod]
        public void TestMethod4()
        {
            string s = "-(3+(4+5))";
            _224_BasicCalculator basicCalculator = new _224_BasicCalculator();
            int result = basicCalculator.Calculate(s);

            Assert.AreEqual(-12, result);
        }

    }
}
