using LeetCodeAlgorithms.BL.Models;

namespace LeetCodeAlgorithms.BL.Helpers
{
    public static class PrintDataHelper
    {
        public static string PrintArray<T>(T[] array)
        {
            if (array == null || array.Length == 0)
            {
                Console.WriteLine("[]");
                return "";
            }
            return "[" + string.Join(", ", array) + "]";
        }

        public static string PrintList<T>(List<T> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("[]");
                return "";
            }
            return "[" + string.Join(", ", list) + "]";
        }

        public static void PrintListNode(ListNode? head)
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
