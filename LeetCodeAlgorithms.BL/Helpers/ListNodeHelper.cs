using LeetCodeAlgorithms.BL.Tasks;

namespace LeetCodeAlgorithms.BL.Helpers
{
    public static class ListNodeHelper
    {
        public static ListNode? BuildList(int[] values)
        {
            if (values == null || values.Length == 0)
            {
                return null;
            }

            ListNode head = new ListNode(values[0]);
            ListNode current = head;
            for (int i = 1; i < values.Length; i++)
            {
                current.next = new ListNode(values[i]);
                current = current.next;
            }

            return head;
        }

        public static int[] ListToArray(ListNode? head)
        {
            var result = new List<int>();

            while (head != null)
            {
                result.Add(head.val);
                head = head.next;
            }

            return [.. result];
        }
    }
}
