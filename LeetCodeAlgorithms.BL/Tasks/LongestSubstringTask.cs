namespace LeetCodeAlgorithms.BL.Tasks.LongestSubstring
{
    // 3. Longest Substring Without Repeating Characters (Medium)
    // Given a string s, find the length of the longest substring without duplicate characters.

    //Example 1:
    //Input: s = "abcabcbb"
    //Output: 3
    //Explanation: The answer is "abc", with the length of 3.

    //Example 2:
    //Input: s = "bbbbb"
    //Output: 1
    //Explanation: The answer is "b", with the length of 1.

    //Example 3:
    //Input: s = "pwwkew"
    //Output: 3
    //Explanation: The answer is "wke", with the length of 3.
    //Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.

    //Constraints:

    //0 <= s.length <= 5 * 104
    //s consists of English letters, digits, symbols and spaces.

    // https://leetcode.com/problems/longest-substring-without-repeating-characters/description/
    public class LongestSubstringTask : IExecutableTask
    {
        public int Solution(string s)
        {
            string result = string.Empty;
            string current = string.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                var index = current.IndexOf(s[i]);
                if (index == -1)
                {
                    current += s[i];
                }
                else
                {
                    if (current.Length > result.Length)
                    {
                        result = current;
                    }
                    current = current[(index + 1)..] + s[i]; // current.Substring(index + 1)
                }
            }

            if (current.Length > result.Length)
            {
                result = current;
            }

            return result.Length;
        }

        public int Solution2(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            var seen = new Dictionary<char, int>();
            int maxLength = 0;
            int start = 0;

            for (int end = 0; end < s.Length; end++)
            {
                char currentChar = s[end];

                if (seen.ContainsKey(currentChar) && seen[currentChar] >= start)
                {
                    // Move the start pointer to the right of the previous duplicate character
                    start = seen[currentChar] + 1;
                }

                // Update or add the current character's index
                seen[currentChar] = end;

                // Calculate the current window length and update max
                maxLength = Math.Max(maxLength, end - start + 1);
            }

            return maxLength;
        }

        public void Execute()
        {
            Console.WriteLine("Running 'Longest Substring Without Repeating Characters' solutions...");

            var testCases = new Dictionary<string, int>
            {
                { "abcabcbb", 3 },
                { "bbbbb", 1 },
                { "pwwkew", 3 }
            };

            foreach (var testCase in testCases)
            {
                var actual = Solution(testCase.Key);
                var isCorrect = actual == testCase.Value;
                var text = $"{testCase.Key}: {actual} - {isCorrect}";
                PrintResult(isCorrect ? ConsoleColor.Green : ConsoleColor.Red, text);
            }
            Console.WriteLine();
        }

        private void PrintResult(ConsoleColor color, string text)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
