using LeetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static LeetCode.Problems._21_MergeTwoSortedLists;

namespace LeetCodeTest.Problems
{
    [TestClass]
    public class _21_MergeTwoSortedListsTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(2);
            l1.next.next = new ListNode(4);
            ListNode l2 = new ListNode(1);
            l2.next = new ListNode(3);
            l2.next.next = new ListNode(4);

            _21_MergeTwoSortedLists mergeTwoSortedLists = new _21_MergeTwoSortedLists();
            ListNode result = mergeTwoSortedLists.MergeTwoLists(l1, l2);

            ListNode expected = new ListNode(1);
            expected.next = new ListNode(1);
            expected.next.next = new ListNode(2);
            expected.next.next.next = new ListNode(3);
            expected.next.next.next.next = new ListNode(4);
            expected.next.next.next.next.next = new ListNode(4);

            isEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {

            _21_MergeTwoSortedLists mergeTwoSortedLists = new _21_MergeTwoSortedLists();
            ListNode result = mergeTwoSortedLists.MergeTwoLists(null, new ListNode());

            ListNode expected = new ListNode();

            isEqual(expected, result);
        }


        [TestMethod]
        public void TestMethod3()
        {

            _21_MergeTwoSortedLists mergeTwoSortedLists = new _21_MergeTwoSortedLists();
            ListNode result = mergeTwoSortedLists.MergeTwoLists(null, null);

            ListNode expected = null;

            isEqual(expected, result);
        }

        void isEqual(ListNode expected, ListNode result)
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
