using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _896_MonotonicArrayTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            int[] A = { 1, 2, 2, 3 };
            _896_MonotonicArray monotonicArray = new _896_MonotonicArray();
            bool result = monotonicArray.IsMonotonic(A);

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] A = { 6, 5, 4, 4 };
            _896_MonotonicArray monotonicArray = new _896_MonotonicArray();
            bool result = monotonicArray.IsMonotonic(A);

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int[] A = { 1, 3, 2 };
            _896_MonotonicArray monotonicArray = new _896_MonotonicArray();
            bool result = monotonicArray.IsMonotonic(A);

            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int[] A = { 1, 2, 4, 5 };
            _896_MonotonicArray monotonicArray = new _896_MonotonicArray();
            bool result = monotonicArray.IsMonotonic(A);

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestMethod5()
        {
            int[] A = { 1, 1, 1 };
            _896_MonotonicArray monotonicArray = new _896_MonotonicArray();
            bool result = monotonicArray.IsMonotonic(A);

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestMethod6()
        {
            int[] A = { 1, 1, 2 };
            _896_MonotonicArray monotonicArray = new _896_MonotonicArray();
            bool result = monotonicArray.IsMonotonic(A);

            Assert.AreEqual(true, result);
        }
    }
}
