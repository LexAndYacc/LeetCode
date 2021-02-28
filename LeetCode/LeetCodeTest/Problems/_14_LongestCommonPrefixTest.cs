using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _14_LongestCommonPrefixTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            string[] strs = { "flower", "flow", "flight" };
            _14_LongestCommonPrefix longestCommonPrefix = new _14_LongestCommonPrefix();
            string result = longestCommonPrefix.LongestCommonPrefix(strs);

            Assert.AreEqual("fl", result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string[] strs = { "dog", "racecar", "car" };
            _14_LongestCommonPrefix longestCommonPrefix = new _14_LongestCommonPrefix();
            string result = longestCommonPrefix.LongestCommonPrefix(strs);

            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string[] strs = { };
            _14_LongestCommonPrefix longestCommonPrefix = new _14_LongestCommonPrefix();
            string result = longestCommonPrefix.LongestCommonPrefix(strs);

            Assert.AreEqual("", result);
        }
    }
}
