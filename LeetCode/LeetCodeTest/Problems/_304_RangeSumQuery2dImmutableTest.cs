using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCode.Problems._304_RangeSumQuery2dImmutable;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _304_RangeSumQuery2dImmutableTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            int[][] matrix =  {
                new int[] {3, 0, 1, 4, 2},
                new int[] {5, 6, 3, 2, 1},
                new int[] {1, 2, 0, 1, 5},
                new int[] {4, 1, 0, 1, 7},
                new int[] {1, 0, 3, 0, 5}
            };
            NumMatrix obj = new NumMatrix(matrix);
            Assert.AreEqual(8, obj.SumRegion(2, 1, 4, 3));
            Assert.AreEqual(11, obj.SumRegion(1, 1, 2, 2));
            Assert.AreEqual(12, obj.SumRegion(1, 2, 2, 4));
        }

    }
}
