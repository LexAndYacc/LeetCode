using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _354_RussianDollEnvelopesTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            int[][] envelopes = new int[][]
            {
               new int[] { 5,4 },
               new int[] {6,4 },
               new int[] {6,7 },
               new int[] {2,3 }
            };

            _354_RussianDollEnvelopes russianDollEnvelopes = new _354_RussianDollEnvelopes();
            int result = russianDollEnvelopes.MaxEnvelopes(envelopes);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[][] envelopes = new int[][]
            {
               new int[] { 4,5 },
               new int[] { 4,6 },
               new int[] { 6,7 },
               new int[] { 2,3 },
               new int[] { 1,1 }
            };

            _354_RussianDollEnvelopes russianDollEnvelopes = new _354_RussianDollEnvelopes();
            int result = russianDollEnvelopes.MaxEnvelopes(envelopes);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[][] envelopes = new int[][]
            {
               new int[] { 1,2 },
               new int[] { 2,3 },
               new int[] { 3,4 },
               new int[] { 3,5 },
               new int[] { 4,5 },
               new int[] { 5,5 },
               new int[] { 5,6 },
               new int[] { 6,7 },
               new int[] { 7,8 }
            };

            _354_RussianDollEnvelopes russianDollEnvelopes = new _354_RussianDollEnvelopes();
            int result = russianDollEnvelopes.MaxEnvelopes(envelopes);

            Assert.AreEqual(7, result);
        }
    }
}
