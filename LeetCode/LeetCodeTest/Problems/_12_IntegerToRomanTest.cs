using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _12_IntegerToRomanTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            _12_IntegerToRoman integerToRoman = new _12_IntegerToRoman();
            string result = integerToRoman.IntToRoman(3);

            Assert.AreEqual("III", result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            _12_IntegerToRoman integerToRoman = new _12_IntegerToRoman();
            string result = integerToRoman.IntToRoman(4);

            Assert.AreEqual("IV", result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            _12_IntegerToRoman integerToRoman = new _12_IntegerToRoman();
            string result = integerToRoman.IntToRoman(9);

            Assert.AreEqual("IX", result);
        }
        [TestMethod]
        public void TestMethod4()
        {
            _12_IntegerToRoman integerToRoman = new _12_IntegerToRoman();
            string result = integerToRoman.IntToRoman(58);

            Assert.AreEqual("LVIII", result);
        }
        [TestMethod]
        public void TestMethod5()
        {
            _12_IntegerToRoman integerToRoman = new _12_IntegerToRoman();
            string result = integerToRoman.IntToRoman(1994);

            Assert.AreEqual("MCMXCIV", result);
        }
    }
}
