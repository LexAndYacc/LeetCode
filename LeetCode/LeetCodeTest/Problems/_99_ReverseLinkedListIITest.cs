using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCode.Problems._99_ReverseLinkedListII;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _99_ReverseLinkedListIITest
    {

        [TestMethod]
        public void TestMethod1()
        {
            ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            _99_ReverseLinkedListII reverseLinkedListII = new _99_ReverseLinkedListII();
            ListNode result = reverseLinkedListII.ReverseBetween(head, 2, 4);

            ListNode expected = new ListNode(1, new ListNode(4, new ListNode(3, new ListNode(2, new ListNode(5)))));

            do
            {
                Assert.AreEqual(expected.val, result.val);
                expected = expected.next;
                result = result.next;
            }
            while (expected != null);
        }
        [TestMethod]
        public void TestMethod2()
        {
            ListNode head =  new ListNode(5);
            _99_ReverseLinkedListII reverseLinkedListII = new _99_ReverseLinkedListII();
            ListNode result = reverseLinkedListII.ReverseBetween(head, 1, 1);

            ListNode expected = new ListNode(5);

            do
            {
                Assert.AreEqual(expected.val, result.val);
                expected = expected.next;
                result = result.next;
            }
            while (expected != null);
        }

    }
}
