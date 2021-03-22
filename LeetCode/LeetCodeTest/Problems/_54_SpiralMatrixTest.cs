using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _54_SpiralMatrixTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            int[][] matrix = new int[][]
            {
               new int[] { 1,2,3 },
               new int[] {4,5,6 },
               new int[] {7,8,9 }
            };

            _54_SpiralMatrix spiralMatrix = new _54_SpiralMatrix();
            IList<int> result = spiralMatrix.SpiralOrder(matrix);

            int[] expected = { 1, 2, 3, 6, 9, 8, 7, 4, 5 };

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[][] matrix = new int[][]
            {
               new int[] { 1,2,3,4 },
               new int[] {5,6,7,8 },
               new int[] {9,10,11,12 }
            };

            _54_SpiralMatrix spiralMatrix = new _54_SpiralMatrix();
            IList<int> result = spiralMatrix.SpiralOrder(matrix);

            int[] expected = { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 };

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[][] matrix = new int[][]
            {
               new int[] { 1 }
            };

            _54_SpiralMatrix spiralMatrix = new _54_SpiralMatrix();
            IList<int> result = spiralMatrix.SpiralOrder(matrix);

            int[] expected = { 1 };

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
        [TestMethod]
        public void TestMethod4()
        {
            int[][] matrix = new int[][]
            {
               new int[] { 3 },
               new int[] { 2 }
            };

            _54_SpiralMatrix spiralMatrix = new _54_SpiralMatrix();
            IList<int> result = spiralMatrix.SpiralOrder(matrix);

            int[] expected = { 3,2 };

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
    }
}
