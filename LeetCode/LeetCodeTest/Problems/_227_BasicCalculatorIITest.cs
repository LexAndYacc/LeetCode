using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCode.Problems._232_ImplementQueueUsingStacks;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _227_BasicCalculatorIITest
    {

        [TestMethod]
        public void TestMethod1()
        {
            string s = "3+2*2";
            _227_BasicCalculatorII basicCalculatorII = new _227_BasicCalculatorII();
            int result = basicCalculatorII.Calculate(s);

            Assert.AreEqual(7, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string s = "3/2";
            _227_BasicCalculatorII basicCalculatorII = new _227_BasicCalculatorII();
            int result = basicCalculatorII.Calculate(s);

            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            string s = " 3+5 / 2";
            _227_BasicCalculatorII basicCalculatorII = new _227_BasicCalculatorII();
            int result = basicCalculatorII.Calculate(s);

            Assert.AreEqual(5, result);
        }

    }
}
