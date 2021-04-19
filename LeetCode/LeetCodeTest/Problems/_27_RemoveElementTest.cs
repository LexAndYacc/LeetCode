using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _27_RemoveElementTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            int[] nums = { 3, 2, 2, 3 };
            _27_RemoveElement removeElement = new _27_RemoveElement();
            int result = removeElement.RemoveElement(nums, 3);

            Assert.AreEqual(2, result);
        }


        [TestMethod]
        public void TestMethod2()
        {
            int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
            _27_RemoveElement removeElement = new _27_RemoveElement();
            int result = removeElement.RemoveElement(nums, 2);

            Assert.AreEqual(5, result);
        }


        [TestMethod]
        public void TestMethod3()
        {
            int[] nums = { 1, 1, 1, 1, 1 };
            _27_RemoveElement removeElement = new _27_RemoveElement();
            int result = removeElement.RemoveElement(nums, 1);

            Assert.AreEqual(0, result);
        }
    }
}
