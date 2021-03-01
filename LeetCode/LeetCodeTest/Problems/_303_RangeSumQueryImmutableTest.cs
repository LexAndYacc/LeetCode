using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCode.Problems._303_RangeSumQueryImmutable;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _303_RangeSumQueryImmutableTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            NumArray numArray = new NumArray(new int[] { -2, 0, 3, -5, 2, -1 });
            Assert.AreEqual(1, numArray.SumRange(0, 2));
            Assert.AreEqual(-1, numArray.SumRange(2, 5));
            Assert.AreEqual(-3, numArray.SumRange(0, 5));
        }

    }
}
