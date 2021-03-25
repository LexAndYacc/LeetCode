using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class _82_RemoveDuplicatesFromSortedListII
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            return mySolution(head);
        }

        ListNode mySolution(ListNode head)
        {
            ListNode p = new ListNode(666, head);
            ListNode last = p;
            int flag = 666;

            while (head != null && head.next != null)
            {
                if (head.val == head.next.val)
                {
                    flag = head.val;
                    last.next = head.next.next;
                    head = head.next.next;
                }
                else
                {
                    flag = 666;
                    last = head;
                    head = head.next;
                }
                while (head != null)
                {
                    if (head.val == flag)
                    {
                        last.next = head.next;
                        head = head.next;
                    }
                    else
                    {
                        break;
                    }
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
