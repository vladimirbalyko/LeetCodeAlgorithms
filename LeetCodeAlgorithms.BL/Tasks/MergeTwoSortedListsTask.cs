
using LeetCodeAlgorithms.BL.Helpers;
using LeetCodeAlgorithms.BL.Models;

namespace LeetCodeAlgorithms.BL.Tasks
{
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

            var item1 = ListNodeHelper.BuildList(new[] { 1, 2, 4 });
            var item2 = ListNodeHelper.BuildList(new[] { 1, 3, 4 });

            var result = Solution(item1, item2);
            PrintDataHelper.PrintListNode(result);
        }
    }
}
