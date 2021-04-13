using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCode.Problems._783_MinimumDistanceBetweenBstNodes;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _783_MinimumDistanceBetweenBstNodesTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            TreeNode root = new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(6));
            _783_MinimumDistanceBetweenBstNodes minimumDistanceBetweenBstNodes = new _783_MinimumDistanceBetweenBstNodes();
            int result = minimumDistanceBetweenBstNodes.MinDiffInBST(root);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            TreeNode root = new TreeNode(1, new TreeNode(0), new TreeNode(48, new TreeNode(12), new TreeNode(49)));
            _783_MinimumDistanceBetweenBstNodes minimumDistanceBetweenBstNodes = new _783_MinimumDistanceBetweenBstNodes();
            int result = minimumDistanceBetweenBstNodes.MinDiffInBST(root);

            Assert.AreEqual(1, result);
        }
    }
}
