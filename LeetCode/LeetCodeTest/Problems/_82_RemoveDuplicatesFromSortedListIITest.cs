using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCode.Problems._82_RemoveDuplicatesFromSortedListII;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _82_RemoveDuplicatesFromSortedListIITest
    {

        [TestMethod]
        public void TestMethod1()
        {
            ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3, new ListNode(4, new ListNode(4, new ListNode(5)))))));
            _82_RemoveDuplicatesFromSortedListII removeDuplicatesFromSortedListII = new _82_RemoveDuplicatesFromSortedListII();
            ListNode result = removeDuplicatesFromSortedListII.DeleteDuplicates(head);

            ListNode expected = new ListNode(1, new ListNode(2, new ListNode(5)));

            while (expected != null)
            {
                Assert.AreEqual(expected.val, result.val);

                expected = expected.next;
                result = result.next;
            }
        }
        [TestMethod]
        public void TestMethod2()
        {
            ListNode head = new ListNode(1, new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3)))));
            _82_RemoveDuplicatesFromSortedListII removeDuplicatesFromSortedListII = new _82_RemoveDuplicatesFromSortedListII();
            ListNode result = removeDuplicatesFromSortedListII.DeleteDuplicates(head);

            ListNode expected = new ListNode(2, new ListNode(3));

            while (expected != null)
            {
                Assert.AreEqual(expected.val, result.val);

                expected = expected.next;
                result = result.next;
            }
        }


        [TestMethod]
        public void TestMethod3()
        {
            ListNode head = new ListNode(1, new ListNode(1));
            _82_RemoveDuplicatesFromSortedListII removeDuplicatesFromSortedListII = new _82_RemoveDuplicatesFromSortedListII();
            ListNode result = removeDuplicatesFromSortedListII.DeleteDuplicates(head);

            ListNode expected = null;

            while (expected != null)
            {
                Assert.AreEqual(expected.val, result.val);

                expected = expected.next;
                result = result.next;
            }
        }
    }
}
