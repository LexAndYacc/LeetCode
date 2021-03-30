using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCode.Problems._706_DesignHashmap;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _74_SearchA2dMatrixTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            int[][] matrix =
            {
                new int[]{1,3,5,7},
                new int[]{10,11,16,20},
                new int[]{23,30,34,60}
            };
            int target = 3;
            _74_SearchA2dMatrix searchA2DMatrix = new _74_SearchA2dMatrix();
            bool result = searchA2DMatrix.SearchMatrix(matrix, target);

            Assert.AreEqual(true, result);

        }
        [TestMethod]
        public void TestMethod2()
        {
            int[][] matrix =
            {
                new int[]{1,3,5,7},
                new int[]{10,11,16,20},
                new int[]{23,30,34,60}
            };
            int target = 13;
            _74_SearchA2dMatrix searchA2DMatrix = new _74_SearchA2dMatrix();
            bool result = searchA2DMatrix.SearchMatrix(matrix, target);

            Assert.AreEqual(false, result);

        }

        [TestMethod]
        public void TestMethod3()
        {
            int[][] matrix =
            {
                new int[]{1}
            };
            int target = 0;
            _74_SearchA2dMatrix searchA2DMatrix = new _74_SearchA2dMatrix();
            bool result = searchA2DMatrix.SearchMatrix(matrix, target);

            Assert.AreEqual(false, result);

        }
    }
}
