using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _16_3SumClosestTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            int[] nums = { -1, 2, 1, -4 };
            int target = 1;
            _16_3SumClosest _3SumClosest = new _16_3SumClosest();
            int result = _3SumClosest.ThreeSumClosest(nums, target);

            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] nums = { 1,1,-1,-1,3 };
            int target = 3;
            _16_3SumClosest _3SumClosest = new _16_3SumClosest();
            int result = _3SumClosest.ThreeSumClosest(nums, target);

            Assert.AreEqual(3, result);
        }

    }
}
