using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCode.Problems._19_RemoveNthNodeFromEndOfList;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _19_RemoveNthNodeFromEndOfListTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            ListNode head = new ListNode(1);
            ListNode pointer = head;
            int n = 2;
            for(int i = 2; i <= 5; i++)
            {
                pointer.next = new ListNode(i);
                pointer = pointer.next;
            }
            _19_RemoveNthNodeFromEndOfList removeNthNodeFromEndOfList = new _19_RemoveNthNodeFromEndOfList();
            ListNode result = removeNthNodeFromEndOfList.RemoveNthFromEnd(head, n);

            ListNode expected = new ListNode(1);
            pointer = expected;
            for(int i = 2; i <= 5; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                pointer.next = new ListNode(i);
                pointer = pointer.next;
            }



            isEqual(expected, result);

        }

        [TestMethod]
        public void TestMethod2()
        {
            ListNode head = new ListNode(1);
            ListNode pointer = head;
            int n = 1;
            _19_RemoveNthNodeFromEndOfList removeNthNodeFromEndOfList = new _19_RemoveNthNodeFromEndOfList();
            ListNode result = removeNthNodeFromEndOfList.RemoveNthFromEnd(head, n);

            ListNode expected = null;


            isEqual(expected, result);
        }


        [TestMethod]
        public void TestMethod3()
        {
            ListNode head = new ListNode(1);
            ListNode pointer = head;
            int n = 1;
            for (int i = 2; i <= 2; i++)
            {
                pointer.next = new ListNode(i);
                pointer = pointer.next;
            }
            _19_RemoveNthNodeFromEndOfList removeNthNodeFromEndOfList = new _19_RemoveNthNodeFromEndOfList();
            ListNode result = removeNthNodeFromEndOfList.RemoveNthFromEnd(head, n);

            ListNode expected = new ListNode(1);



            isEqual(expected, result);

        }

        void isEqual(ListNode expected,ListNode result)
        {
            if (expected != null && result != null)
            {
                while (expected != null && result != null)
                {
                    Assert.AreEqual(expected.val, result.val);
                    if (expected.next == null && result.next == null)
                    {
                        break;
                    }
                    else if (expected != null && result != null)
                    {
                        expected = expected.next;
                        result = result.next;
                    }
                    else
                    {
                        throw new System.Exception();
                    }

                }
            }
            else if (expected == null && result == null)
            {

            }
            else
            {
                throw new System.Exception();
            }
        }

    }
}
