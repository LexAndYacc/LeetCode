using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class _21_MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            return mySolution(l1,l2);
        }

        ListNode mySolution(ListNode l1,ListNode l2)
        {
            ListNode dummy = new ListNode();
            ListNode pointer = dummy;

            while (l1 != null || l2 != null)
            {
                if(l1 != null && l2 != null)
                {
                    if (l1.val >= l2.val)
                    {
                        pointer.next = l2;
                        l2 = l2.next;
                    }
                    else
                    {
                        pointer.next = l1;
                        l1 = l1.next;
                    }
                    pointer = pointer.next;
                }
                else
                {
                    if (l1 != null)
                    {
                        pointer.next = l1;
                    }

                    if (l2 != null)
                    {
                        pointer.next = l2;
                    }
                    break;
                }
            }

            return dummy.next;
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
