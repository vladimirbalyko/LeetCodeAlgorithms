
namespace LeetCodeAlgorithms.BL.Tasks
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

    // 21. Merge Two Sorted Lists (Easy)
    public class MergeTwoSortedListsTask : IExecutableTask
    {
        public ListNode? Solution(ListNode? list1, ListNode? list2)
        {
            if (list1 == null && list2 == null) return null;
            if (list1 == null) return list2;
            if (list2 == null) return list1;

            ListNode listNode = new ListNode(0);
            var current = listNode;

            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }
                current = current.next;
            }

            if (list1 != null) current.next = list1;
            if (list2 != null) current.next = list2;

            return listNode.next;
        }

        public void Execute()
        {
            Console.WriteLine("Running '21. Merge Two Sorted Lists' solutions...");

            var item1 = BuildList(new[] { 1, 2, 4 });
            var item2 = BuildList(new[] { 1, 3, 4 });

            var result = Solution(item1, item2);
            PrintList(result);
        }

        public ListNode? BuildList(int[] values)
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

        public void PrintList(ListNode head)
        {
            var current = head;
            while (current != null)
            {
                Console.Write(current.val);
                if (current.next != null)
                {
                    Console.Write(" -> ");
                }
                current = current.next;
            }
            Console.WriteLine();
        }
    }
}
