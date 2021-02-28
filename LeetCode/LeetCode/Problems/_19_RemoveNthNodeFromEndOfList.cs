using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class _19_RemoveNthNodeFromEndOfList
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            return bestSolution(head, n);
        }

        ListNode mySolution(ListNode head,int n)
        {
            ListNode pointer = head;
            List<ListNode> listNodes = new List<ListNode>();
            
            while (pointer != null)
            {
                listNodes.Add(pointer);
                pointer = pointer.next;
            }

            if (listNodes.Count < n)
            {
                return null;
            }

            pointer = listNodes[listNodes.Count - n];
            listNodes.Remove(pointer);
            if(listNodes.Count == 0)
            {
                head = null;
            }
            else if(listNodes.Count - n == -1)
            {
                head = pointer.next;
            }
            else
            {
                listNodes[listNodes.Count - n].next = pointer.next;
            }


            return head;
        }

        public ListNode bestSolution(ListNode head, int n)
        {
            ListNode dummy = new ListNode(0, head);
            ListNode first = head;
            ListNode second = dummy;
            int i = 0;
            while (first != null)
            {
                first = first.next;
                if (i >= n)
                    second = second.next;
                ++i;
            }
            second.next = second.next.next;
            ListNode ans = dummy.next;
            return ans;
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
