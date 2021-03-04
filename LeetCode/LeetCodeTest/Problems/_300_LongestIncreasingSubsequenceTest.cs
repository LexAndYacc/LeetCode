using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCode.Problems._303_RangeSumQueryImmutable;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _300_LongestIncreasingSubsequenceTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            int[] nums = { 10, 9, 2, 5, 3, 7, 101, 18 };
            _300_LongestIncreasingSubsequence longestIncreasingSubsequence = new _300_LongestIncreasingSubsequence();
            int result = longestIncreasingSubsequence.LengthOfLIS(nums);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] nums = { 0, 1, 0, 3, 2, 3 };
            _300_LongestIncreasingSubsequence longestIncreasingSubsequence = new _300_LongestIncreasingSubsequence();
            int result = longestIncreasingSubsequence.LengthOfLIS(nums);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] nums = { 7, 7, 7, 7, 7, 7, 7 };
            _300_LongestIncreasingSubsequence longestIncreasingSubsequence = new _300_LongestIncreasingSubsequence();
            int result = longestIncreasingSubsequence.LengthOfLIS(nums);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] nums = {1,3,6,7,9,4,10,5,6 };
            _300_LongestIncreasingSubsequence longestIncreasingSubsequence = new _300_LongestIncreasingSubsequence();
            int result = longestIncreasingSubsequence.LengthOfLIS(nums);
            Assert.AreEqual(6, result);
        }
    }
}
