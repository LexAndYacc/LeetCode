using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _131_PalindromePartitioningTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            _131_PalindromePartitioning palindromePartitioning = new _131_PalindromePartitioning();
            IList<IList<string>> result = palindromePartitioning.Partition("aab");

            Assert.AreEqual(2, result.Count);
        }
        [TestMethod]
        public void TestMethod2()
        {
            _131_PalindromePartitioning palindromePartitioning = new _131_PalindromePartitioning();
            IList<IList<string>> result = palindromePartitioning.Partition("a");

            Assert.AreEqual(1, result.Count);
        }
        [TestMethod]
        public void TestMethod3()
        {
            _131_PalindromePartitioning palindromePartitioning = new _131_PalindromePartitioning();
            IList<IList<string>> result = palindromePartitioning.Partition("bb");

            Assert.AreEqual(2, result.Count);
        }

    }
}
