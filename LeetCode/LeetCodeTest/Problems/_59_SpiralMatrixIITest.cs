using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _59_SpiralMatrixIITest
    {

        [TestMethod]
        public void TestMethod1()
        {
            _59_SpiralMatrixII spiralMatrixII = new _59_SpiralMatrixII();
            int[][] result = spiralMatrixII.GenerateMatrix(3);
            int[][] expected = new int[][]
            {
               new int[] { 1,2,3 },
               new int[] { 8,9,4 },
               new int[] { 7,6,5 }
            };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Assert.AreEqual(expected[i][j], result[i][j]);
                }
            }
        }
        [TestMethod]
        public void TestMethod2()
        {
            _59_SpiralMatrixII spiralMatrixII = new _59_SpiralMatrixII();
            int[][] result = spiralMatrixII.GenerateMatrix(1);
            int[][] expected = new int[][]
            {
               new int[] { 1 }
            };

            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Assert.AreEqual(expected[i][j], result[i][j]);
                }
            }
        }

    }
}
