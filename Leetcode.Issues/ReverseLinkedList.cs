namespace Leetcode.Issues
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-linked-list/
    /// </summary>
    public class ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            var current = head;
            ListNode prev = null;
            while (current != null)
            {
                var tmp = current.next;
                current.next = prev;

                prev = current;
                current = tmp;
            }

            return prev;
        }
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
