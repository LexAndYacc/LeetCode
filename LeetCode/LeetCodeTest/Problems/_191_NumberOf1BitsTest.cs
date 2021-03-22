using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _191_NumberOf1BitsTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            uint n = 0b00000000000000000000000000001011;

            _191_NumberOf1Bits numberOf1Bits = new _191_NumberOf1Bits();
            int result = numberOf1Bits.HammingWeight(n);

            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            uint n = 0b00000000000000000000000010000000;

            _191_NumberOf1Bits numberOf1Bits = new _191_NumberOf1Bits();
            int result = numberOf1Bits.HammingWeight(n);

            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            uint n = 0b11111111111111111111111111111101;

            _191_NumberOf1Bits numberOf1Bits = new _191_NumberOf1Bits();
            int result = numberOf1Bits.HammingWeight(n);

            Assert.AreEqual(31, result);
        }


    }
}
