using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCode.Problems._99_ReverseLinkedListII;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _90_SubsetsIITest
    {

        [TestMethod]
        public void TestMethod1()
        {
            int[] nums = { 1, 2, 2 };
            _90_SubsetsII subsetsII = new _90_SubsetsII();
            IList<IList<int>> result = subsetsII.SubsetsWithDup(nums);

            Assert.AreEqual(6, result.Count);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] nums = { 0 };
            _90_SubsetsII subsetsII = new _90_SubsetsII();
            IList<IList<int>> result = subsetsII.SubsetsWithDup(nums);

            Assert.AreEqual(2, result.Count);
        }
    }
}
