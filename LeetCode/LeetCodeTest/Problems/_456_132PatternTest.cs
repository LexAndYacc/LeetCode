using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _456_132PatternTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            int[] nums = { 1, 2, 3, 4 };
            _456_132Pattern pattern = new _456_132Pattern();
            bool result = pattern.Find132pattern(nums);

            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] nums = { 3, 1, 4, 2 };
            _456_132Pattern pattern = new _456_132Pattern();
            bool result = pattern.Find132pattern(nums);

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int[] nums = { -1, 3, 2, 0 };
            _456_132Pattern pattern = new _456_132Pattern();
            bool result = pattern.Find132pattern(nums);

            Assert.AreEqual(true, result);
        }
    }
}
