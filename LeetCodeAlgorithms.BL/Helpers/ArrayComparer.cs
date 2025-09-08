namespace LeetCodeAlgorithms.BL.Helpers
{
    public static class ArrayComparer
    {
        /// <summary>
        /// Checks if two arrays are equal (same length, same elements, same order).
        /// </summary>
        public static bool AreEqual<T>(T[] first, T[] second)
        {
            if (first == null || second == null)
                return first == second;

            if (first.Length != second.Length)
                return false;

            return first.SequenceEqual(second);
        }

        /// <summary>
        /// Finds items that are in the first array but not in the second.
        /// </summary>
        public static T[] GetDifferences<T>(T[] first, T[] second)
        {
            if (first == null) return Array.Empty<T>();
            if (second == null) return first;

            return first.Except(second).ToArray();
        }
    }
}
