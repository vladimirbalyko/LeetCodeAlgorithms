using LeetCodeAlgorithms.BL.Helpers;
using LeetCodeAlgorithms.BL.Models;

namespace LeetCodeAlgorithms.BL.Tasks
{
    // 83. Remove Duplicates from Sorted List (Easy)
    public class RemoveDuplicatesFromSortedListTask : IExecutableTask
    {
        public ListNode Solution(ListNode head)
        {
            if (head == null) return null;

            var current = head;

            while (current != null)
            {
                var next = current.next;
                if (next == null || current.val != next.val)
                {
                    current = next;
                }
                else
                {
                    current.next = current.next?.next;
                }
            }

            return head;
        }

        public void Execute()
        {
            Console.WriteLine("Running '83. Remove Duplicates from Sorted List' solutions...");

            int[][] testCases = [[1, 1, 2], [1, 1, 2, 3, 3]];

            foreach (var testCase in testCases)
            {
                Console.WriteLine("Original list:");
                var listNode = ListNodeHelper.BuildList(testCase);
                PrintDataHelper.PrintListNode(listNode);

                var result = Solution(listNode);
                Console.WriteLine("Calculated list:");
                PrintDataHelper.PrintListNode(result);

                Console.WriteLine();
            }
        }
    }
}
