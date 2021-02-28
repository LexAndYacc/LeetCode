using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _15_3SumTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            int[] nums = { -1, 0, 1, 2, -1, -4 };
            _15_3Sum _3Sum = new _15_3Sum();
            IList<IList<int>> result = _3Sum.ThreeSum(nums);

            IList<IList<int>> expected = (IList<IList<int>>)new List<IList<int>>()
            {
                new List<int>(){ -1, -1, 2 },
                new List<int>(){ -1, 0, 1 }
            };
            Assert.AreEqual(expected.Count, result.Count);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] nums = { };
            _15_3Sum _3Sum = new _15_3Sum();
            IList<IList<int>> result = _3Sum.ThreeSum(nums);

            IList<IList<int>> expected = (IList<IList<int>>)new List<IList<int>>()
            {
            };
            Assert.AreEqual(expected.Count, result.Count);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] nums = { 0 };
            _15_3Sum _3Sum = new _15_3Sum();
            IList<IList<int>> result = _3Sum.ThreeSum(nums);

            IList<IList<int>> expected = (IList<IList<int>>)new List<IList<int>>()
            {
            };
            Assert.AreEqual(expected.Count, result.Count);
        }


        [TestMethod]
        public void TestMethod4()
        {
            int[] nums = { -2, 0, 1, 1, 2 };
            _15_3Sum _3Sum = new _15_3Sum();
            IList<IList<int>> result = _3Sum.ThreeSum(nums);

            IList<IList<int>> expected = (IList<IList<int>>)new List<IList<int>>()
            {
                new List<int>(){ -2,0,2 },
                new List<int>(){ -2, 1, 1 }
            };
            Assert.AreEqual(expected.Count, result.Count);
        }
    }
}
