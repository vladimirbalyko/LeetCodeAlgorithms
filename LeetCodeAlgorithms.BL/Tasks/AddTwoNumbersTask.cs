using LeetCodeAlgorithms.BL.Helpers;
using LeetCodeAlgorithms.BL.Models;

namespace LeetCodeAlgorithms.BL.Tasks
{
    // 2. Add Two Numbers (Medium)
    public class AddTwoNumbersTask : IExecutableTask
    {
        public ListNode? Solution(ListNode? l1, ListNode? l2)
        {
            ListNode head = new ListNode();
            ListNode current = head;

            int carry = 0;

            while (l1 != null || l2 != null || carry != 0)
            {
                int x = l1 != null ? l1.val : 0;
                int y = l2 != null ? l2.val : 0;
                int sum = x + y + carry;

                carry = sum / 10;
                int value = sum % 10;

                current.next = new ListNode(value);
                current = current.next;

                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;
            }

            return head.next;
        }

        public void Execute()
        {
            Console.WriteLine("Running '2. Add Two Numbers ...");

            Tuple<int[], int[], int[]>[] testCases =
            [
                Tuple.Create(new int[] { 2, 4, 3 }, new int[] { 5, 6, 4 }, new int[] { 7, 0, 8 }),
                Tuple.Create(new int[] { 0 }, new int[] { 0 }, new int[] { 0 }),
                Tuple.Create(new int[] { 9, 9, 9, 9, 9, 9, 9 }, new int[] { 9, 9, 9, 9 }, new int[] { 8, 9, 9, 9, 0, 0, 0, 1 })
            ];

            foreach (var testCase in testCases)
            {
                var item1 = ListNodeHelper.BuildList(testCase.Item1);
                var item2 = ListNodeHelper.BuildList(testCase.Item2);

                var result = ListNodeHelper.ListToArray(Solution(item1, item2));

                Console.WriteLine($"List 1: {PrintDataHelper.PrintArray(testCase.Item1)}");
                Console.WriteLine($"List 2: {PrintDataHelper.PrintArray(testCase.Item2)}");

                if (result.SequenceEqual(testCase.Item3))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Result: {PrintDataHelper.PrintArray(result)}");
                    Console.WriteLine("Correct result!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Actual result: {PrintDataHelper.PrintArray(result)}; Expected result: {PrintDataHelper.PrintArray(testCase.Item3)}");
                    Console.WriteLine("Wrong result!");
                }

                Console.WriteLine();
                Console.ResetColor();
            }
        }
    }
}
