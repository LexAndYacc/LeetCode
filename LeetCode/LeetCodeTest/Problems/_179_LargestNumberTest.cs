using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _179_LargestNumberTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            int[] nums = { 10, 2 };
            _179_LargestNumber largestNumber = new _179_LargestNumber();
            string result = largestNumber.LargestNumber(nums);

            Assert.AreEqual("210", result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] nums = { 3, 30, 34, 5, 9 };
            _179_LargestNumber largestNumber = new _179_LargestNumber();
            string result = largestNumber.LargestNumber(nums);

            Assert.AreEqual("9534330", result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int[] nums = { 1 };
            _179_LargestNumber largestNumber = new _179_LargestNumber();
            string result = largestNumber.LargestNumber(nums);

            Assert.AreEqual("1", result);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int[] nums = { 10 };
            _179_LargestNumber largestNumber = new _179_LargestNumber();
            string result = largestNumber.LargestNumber(nums);

            Assert.AreEqual("10", result);
        }
        [TestMethod]
        public void TestMethod5()
        {
            int[] nums = { 34323, 3432 };
            _179_LargestNumber largestNumber = new _179_LargestNumber();
            string result = largestNumber.LargestNumber(nums);

            Assert.AreEqual("343234323", result);
        }

    }
}
