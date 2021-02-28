using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _18_4SumTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            int[] nums = { 1, 0, -1, 0, -2, 2 };
            int target = 0;
            _18_4Sum _4Sum = new _18_4Sum();
            IList<IList<int>> result = _4Sum.FourSum(nums,target);

            IList<IList<int>> expected = (IList<IList<int>>)new List<IList<int>>()
            {
                new List<int>(){ -1,  0, 0, 1},
                new List<int>(){ -2, -1, 1, 2 },
                new List<int>(){ -2, 0, 0, 2 }
            };
            Assert.AreEqual(expected.Count, result.Count);
        }


        [TestMethod]
        public void TestMethod2()
        {
            int[] nums = { 0, 0, 0, 0 };
            int target = 1;
            _18_4Sum _4Sum = new _18_4Sum();
            IList<IList<int>> result = _4Sum.FourSum(nums, target);

            IList<IList<int>> expected = (IList<IList<int>>)new List<IList<int>>()
            {
            };
            Assert.AreEqual(expected.Count, result.Count);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int[] nums = { 1,-2,-5,-4,-3,3,3,5 };
            int target = -11;
            _18_4Sum _4Sum = new _18_4Sum();
            IList<IList<int>> result = _4Sum.FourSum(nums, target);

            IList<IList<int>> expected = (IList<IList<int>>)new List<IList<int>>()
            {
                new List<int>(){ -5,-4,-3,1 }
            };
            Assert.AreEqual(expected.Count, result.Count);
        }

    }
}
