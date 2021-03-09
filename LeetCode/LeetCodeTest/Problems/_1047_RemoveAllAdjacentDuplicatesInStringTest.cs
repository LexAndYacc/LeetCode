using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _1047_RemoveAllAdjacentDuplicatesInStringTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            _1047_RemoveAllAdjacentDuplicatesInString removeAllAdjacentDuplicatesInString = new _1047_RemoveAllAdjacentDuplicatesInString();
            string result = removeAllAdjacentDuplicatesInString.RemoveDuplicates("abbaca");

            Assert.AreEqual("ca", result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            _1047_RemoveAllAdjacentDuplicatesInString removeAllAdjacentDuplicatesInString = new _1047_RemoveAllAdjacentDuplicatesInString();
            string result = removeAllAdjacentDuplicatesInString.RemoveDuplicates("aaaaaaaa");

            Assert.AreEqual("", result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            _1047_RemoveAllAdjacentDuplicatesInString removeAllAdjacentDuplicatesInString = new _1047_RemoveAllAdjacentDuplicatesInString();
            string result = removeAllAdjacentDuplicatesInString.RemoveDuplicates("bbaacaab");

            Assert.AreEqual("cb", result);
        }
    }
}
