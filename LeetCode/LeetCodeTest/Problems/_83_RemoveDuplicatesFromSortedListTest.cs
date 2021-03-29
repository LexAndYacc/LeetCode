using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCode.Problems._83_RemoveDuplicatesFromSortedList;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _83_RemoveDuplicatesFromSortedListTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            ListNode head = new ListNode(1, new ListNode(1, new ListNode(2)));
            _83_RemoveDuplicatesFromSortedList removeDuplicatesFromSortedList = new _83_RemoveDuplicatesFromSortedList();
            ListNode result = removeDuplicatesFromSortedList.DeleteDuplicates(head);

            ListNode expected = new ListNode(1, new ListNode(2));

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
            ListNode head = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3)))));
            _83_RemoveDuplicatesFromSortedList removeDuplicatesFromSortedList = new _83_RemoveDuplicatesFromSortedList();
            ListNode result = removeDuplicatesFromSortedList.DeleteDuplicates(head);


            ListNode expected = new ListNode(1, new ListNode(2, new ListNode(3)));

            while (expected != null)
            {
                Assert.AreEqual(expected.val, result.val);

                expected = expected.next;
                result = result.next;
            }
        }


    }
}
