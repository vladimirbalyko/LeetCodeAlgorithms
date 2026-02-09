namespace LeetCodeAlgorithms.BL.Tasks
{
    // 5. Longest Palindromic Substring (Medium)
    // Given a string s, return the longest palindromic substring in s.
    // Example 1:
    // Input: s = "babad"
    // Output: "bab"
    // Explanation: "aba" is also a valid answer.
    // Example 2:
    // Input: s = "cbbd"
    // Output: "bb"
    public class LongestPalindromeSubstringTask : IExecutableTask
    {
        public string Solution(string s)
        {
            var start = 0;
            var maxLength = 1;

            for (var i = 0; i < s.Length; i++)
            {
                // Odd length palindromes
                ExpandFromCenter(s, i, i, ref start, ref maxLength);
                // Even length palindromes
                ExpandFromCenter(s, i, i + 1, ref start, ref maxLength);
            }

            return s.Substring(start, maxLength);
        }

        private void ExpandFromCenter(string s, int left, int right, ref int start, ref int maxLen)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                var len = right - left + 1;
                if (len > maxLen)
                {
                    start = left;
                    maxLen = len;
                }

                left--;
                right++;
            }
        }

        public void Execute()
        {
            Console.WriteLine("Running '5. Longest Palindromic Substring ...");

            var testCases = new[]
            {
                Tuple.Create("babad", "bab"), // "aba" or "bab"
                Tuple.Create("cbbd", "bb"),
                Tuple.Create("a", "a"),
                Tuple.Create("ac", "a"), // "a" or "c"
            };

            foreach (var testCase in testCases)
            {
                var result = Solution(testCase.Item1);
                if (result == testCase.Item2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Result: {result}");
                    Console.WriteLine("Correct result!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Actual result: {result}; Expected result: {testCase.Item2}");
                    Console.WriteLine("Wrong result!");
                }
            }
        }
    }
}
