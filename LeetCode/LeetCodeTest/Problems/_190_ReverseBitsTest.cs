using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _190_ReverseBitsTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            uint n = 0b00000010100101000001111010011100;

            _190_ReverseBits reverseBits = new _190_ReverseBits();
            uint result = reverseBits.reverseBits(n);

            Assert.AreEqual((uint)0b00111001011110000010100101000000, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            uint n = 0b11111111111111111111111111111101;

            _190_ReverseBits reverseBits = new _190_ReverseBits();
            uint result = reverseBits.reverseBits(n);

            Assert.AreEqual((uint)0b10111111111111111111111111111111, result);
        }

    }
}
