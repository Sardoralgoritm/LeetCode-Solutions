/// 234.  https://leetcode.com/problems/palindrome-linked-list/description/


namespace Linked_List;

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public bool IsPalindrome(ListNode head)
    {
        Stack<int> stack = new Stack<int>();
        ListNode dummy = head;
        if (head == null) return true;

        while (head != null)
        {
            stack.Push(head.val);
            head = head.next;
        }

        while (dummy != null)
        {
            if (dummy.val != stack.Pop()) return false;
            dummy = dummy.next;
        }
        return true;
    }
}
