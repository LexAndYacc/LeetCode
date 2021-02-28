using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _22_GenerateParenthesesTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            int n = 3;
            _22_GenerateParentheses generateParentheses = new _22_GenerateParentheses();
            IList<string> result = generateParentheses.GenerateParenthesis(n);

            IList<string> expected = new List<string>()
            {
                "((()))","(()())","(())()","()(())","()()()"
            };

            Assert.AreEqual(expected.Count, result.Count);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int n = 1;
            _22_GenerateParentheses generateParentheses = new _22_GenerateParentheses();
            IList<string> result = generateParentheses.GenerateParenthesis(n);

            IList<string> expected = new List<string>()
            {
                "()"
            };

            Assert.AreEqual(expected.Count, result.Count);
        }
    }
}
