using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _115_DistinctSubsequencesTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            _115_DistinctSubsequences distinctSubsequences = new _115_DistinctSubsequences();
            int result = distinctSubsequences.NumDistinct("rabbbit", "rabbit");

            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            _115_DistinctSubsequences distinctSubsequences = new _115_DistinctSubsequences();
            int result = distinctSubsequences.NumDistinct("babgbag", "bag");

            Assert.AreEqual(5, result);
        }
    }
}
