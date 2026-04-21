namespace Leetcode.Problems;

public partial class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {

        int sumDigit = l1.val + l2.val;
        ListNode res = new ListNode(sumDigit % 10);
        var head = res;

        int carry = sumDigit / 10;
        while (l1.next != null && l2.next != null)
        {
            l1 = l1.next;
            l2 = l2.next;
            sumDigit = l1.val + l2.val + carry;
            res.next = new ListNode(sumDigit % 10);
            res = res.next;
            carry = sumDigit / 10;
        }

        while (l1.next != null)
        {
            l1 = l1.next;
            sumDigit = l1.val + carry;
            res.next = new ListNode(sumDigit % 10);
            res = res.next;
            carry = sumDigit / 10;
        }

        while (l2.next != null)
        {
            l2 = l2.next;
            sumDigit = l2.val + carry;
            res.next = new ListNode(sumDigit % 10);
            res = res.next;
            carry = sumDigit / 10;
        }

        if (carry != 0)
        {
            res.next = new ListNode(carry);
        }

        return head;
    }
}

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}