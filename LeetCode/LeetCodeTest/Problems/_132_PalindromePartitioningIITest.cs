using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _132_PalindromePartitioningIITest
    {

        [TestMethod]
        public void TestMethod1()
        {
            _132_PalindromePartitioningII palindromePartitioningII = new _132_PalindromePartitioningII();
            int result = palindromePartitioningII.MinCut("aab");

            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            _132_PalindromePartitioningII palindromePartitioningII = new _132_PalindromePartitioningII();
            int result = palindromePartitioningII.MinCut("a");

            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            _132_PalindromePartitioningII palindromePartitioningII = new _132_PalindromePartitioningII();
            int result = palindromePartitioningII.MinCut("ab");

            Assert.AreEqual(1, result);
        }


    }
}
