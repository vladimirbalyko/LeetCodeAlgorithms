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
    }
}
