using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _17_LetterCombinationsOfAPhoneNumberTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            string digits = "23";
            _17_LetterCombinationsOfAPhoneNumber letterCombinationsOfAPhoneNumber = new _17_LetterCombinationsOfAPhoneNumber();
            IList<string> result = letterCombinationsOfAPhoneNumber.LetterCombinations(digits);

            Assert.AreEqual(9, result.Count);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string digits = "";
            _17_LetterCombinationsOfAPhoneNumber letterCombinationsOfAPhoneNumber = new _17_LetterCombinationsOfAPhoneNumber();
            IList<string> result = letterCombinationsOfAPhoneNumber.LetterCombinations(digits);

            Assert.AreEqual(0, result.Count);
        }
        [TestMethod]
        public void TestMethod3()
        {
            string digits = "2";
            _17_LetterCombinationsOfAPhoneNumber letterCombinationsOfAPhoneNumber = new _17_LetterCombinationsOfAPhoneNumber();
            IList<string> result = letterCombinationsOfAPhoneNumber.LetterCombinations(digits);

            Assert.AreEqual(3, result.Count);
        }

    }
}
