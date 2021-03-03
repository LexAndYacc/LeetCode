using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _338_CountingBitsTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            int num = 2;
            _338_CountingBits countingBits = new _338_CountingBits();
            int[] result = countingBits.CountBits(num);

            int[] expected = { 0, 1, 1 };

            for(int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            int num = 5;
            _338_CountingBits countingBits = new _338_CountingBits();
            int[] result = countingBits.CountBits(num);

            int[] expected = { 0, 1, 1, 2, 1, 2 };

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
    }
}
