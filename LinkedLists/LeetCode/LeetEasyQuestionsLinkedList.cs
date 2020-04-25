﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists.LeetCode
{
   public class LeetEasyQuestionsLinkedList
    {
        //1290 https://leetcode.com/problems/convert-binary-number-in-a-linked-list-to-integer/submissions/
        public int GetDecimalValue(ListNode head)
        {
            if (head == null) throw new ArgumentNullException(nameof(head));

            StringBuilder sb = new StringBuilder();

            while (head != null)
            {
                sb.Append(head.val);
                head = head.next;
            }
            return Convert.ToInt32(sb.ToString(), 2);
        }

        //876. https://leetcode.com/problems/middle-of-the-linked-list/
        public ListNode MiddleNode(ListNode head)
        {
            var pointer2 = head;
            while(pointer2!=null && pointer2.next != null)
            {
                head = head.next;
                pointer2 = pointer2.next.next;
            }
            return head;
        }
    }
}