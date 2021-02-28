using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _11_ContainerWithMostWaterTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

            _11_ContainerWithMostWater containerWithMostWater = new _11_ContainerWithMostWater();
            int result = containerWithMostWater.MaxArea(height);

            Assert.AreEqual(49, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] height = { 1,1 };

            _11_ContainerWithMostWater containerWithMostWater = new _11_ContainerWithMostWater();
            int result = containerWithMostWater.MaxArea(height);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] height = { 4, 3, 2, 1, 4 };

            _11_ContainerWithMostWater containerWithMostWater = new _11_ContainerWithMostWater();
            int result = containerWithMostWater.MaxArea(height);

            Assert.AreEqual(16, result);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int[] height = { 1, 2, 1 };

            _11_ContainerWithMostWater containerWithMostWater = new _11_ContainerWithMostWater();
            int result = containerWithMostWater.MaxArea(height);

            Assert.AreEqual(2, result);
        }
    }
}
