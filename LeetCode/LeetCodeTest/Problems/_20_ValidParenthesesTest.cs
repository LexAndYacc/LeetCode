using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCode.Problems._19_RemoveNthNodeFromEndOfList;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _20_ValidParenthesesTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            string s = "()";
            _20_ValidParentheses validParentheses = new _20_ValidParentheses();
            bool result = validParentheses.IsValid(s);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string s = "()[]{}";
            _20_ValidParentheses validParentheses = new _20_ValidParentheses();
            bool result = validParentheses.IsValid(s);

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            string s = "(]";
            _20_ValidParentheses validParentheses = new _20_ValidParentheses();
            bool result = validParentheses.IsValid(s);

            Assert.IsFalse(result);
        }
        [TestMethod]
        public void TestMethod4()
        {
            string s = "([)]";
            _20_ValidParentheses validParentheses = new _20_ValidParentheses();
            bool result = validParentheses.IsValid(s);

            Assert.IsFalse(result);
        }
        [TestMethod]
        public void TestMethod5()
        {
            string s = "{[]}";
            _20_ValidParentheses validParentheses = new _20_ValidParentheses();
            bool result = validParentheses.IsValid(s);

            Assert.IsTrue(result);
        }
    }
}
