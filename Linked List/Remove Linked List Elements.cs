/// 203.  https://leetcode.com/problems/remove-linked-list-elements/description/


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
    public ListNode RemoveElements(ListNode head, int val)
    {

        ListNode dummy = new ListNode();
        dummy.next = head;
        ListNode result = dummy;

        while (dummy.next != null)
        {
            if (dummy.next.val == val) dummy.next = dummy.next.next;
            else dummy = dummy.next;
        }
        return result.next;
    }
}