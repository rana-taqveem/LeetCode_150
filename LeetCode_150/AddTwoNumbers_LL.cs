using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace LeetCode_150
{
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

 
    public class AddTwoNumbers
    {
        public static ListNode Execute(ListNode l1, ListNode l2)
        {

            return Add_2(l1, l2);

        }




        private static ListNode Add_3(ListNode l1, ListNode l2)
        {
            ListNode dummyHead = new ListNode();
            ListNode current = dummyHead;
            int carry = 0;

            while (l1 != null || l2 != null || carry > 0)
            {
                int val1 = l1 != null ? l1.val : 0;
                int val2 = l2 != null ? l2.val : 0;

                int sum = val1 + val2 + carry;
                carry = sum / 10;

                current.next = new ListNode(sum % 10);
                current = current.next;

                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;
            }

            return dummyHead.next;
        }

        private static ListNode Add_2(ListNode l1, ListNode l2)
        {
            var node = new ListNode();
            var head = node;
            int op1 = 0; // 9,9,9,9,9,9,9
            int op2 = 0; // 9,9,9,9,
            int carry = 0;

            while (l1 != null || l2 != null || carry > 0)
            {
                if (l1 != null)
                {
                    op1 = l1.val; // 9, 9, 9, 9, 9
                    l1 = l1.next; // 9, 9, 9, 9
                }
                else
                {
                    op1 = 0;
                }

                if (l2 != null)
                {
                    op2 = l2.val; // 9, 9, 9, 9
                    l2 = l2.next; // 9, 9, 9, null
                }
                else
                {
                    op2 = 0;
                }

                int sum = op1 + op2 + carry; // 18, 19, 19, 19, 10
                carry = sum / 10;
                node.val = sum % 10;

                if (l1 != null || l2 != null || carry > 0)
                {
                    node.next = new ListNode(); //
                    node = node.next; //
                }
            }

            return head;
        }
        private static ListNode Add_1(ListNode l1, ListNode l2)
        {
            long sum = getNumFromList(l1) + getNumFromList(l2);

            var node = new ListNode();
            var head = node;
            while (sum > 10)
            {
                node.val = (int)(sum % 10);
                node.next = new ListNode();
                node = node.next;

                sum = sum / 10;
            }

            node.val = (int)sum;
            return head;
        }

        private static long getNumFromList(ListNode l)
        {
            long num = 0;
            long b = 1;

            ListNode node = l;

            while (node != null)
            {
                num = num + node.val * b;
                b = b * 10;
                node = node.next;
            }

            return num;
        }


    }

}
