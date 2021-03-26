using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class _83_RemoveDuplicatesFromSortedList
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            return mySolution(head);
        }

        ListNode mySolution(ListNode head)
        {
            ListNode p = new ListNode(666, head);

            while (head != null && head.next != null)
            {
                if (head.val == head.next.val)
                {
                    head.next = head.next.next;
                }
                else
                {
                    head = head.next;
                }

            }

            return p.next;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}
