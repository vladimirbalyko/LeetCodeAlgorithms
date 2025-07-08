using System.Text;

namespace LeetCodeAlgorithms.BL.Tasks
{
    // 14. Longest Common Prefix (Easy)
    // Write a function to find the longest common prefix string amongst an array of strings.
    // If there is no common prefix, return an empty string "".

    // Example 1:
    // Input: strs = ["flower", "flow", "flight"]
    // Output: "fl"

    // Example 2:
    // Input: strs = ["dog", "racecar", "car"]
    // Output: ""
    // Explanation: There is no common prefix among the input strings.

    // Constraints:
    // 1 <= strs.length <= 200
    // 0 <= strs[i].length <= 200
    // strs[i] consists of only lowercase English letters if it is non-empty.

    // https://leetcode.com/problems/longest-common-prefix/description/
    public class LongestCommonPrefixTask : IExecutableTask
    {
        public string Solution(string[] strs)
        {
            if (strs.Length == 0)
            {
                return string.Empty;
            }

            var len = strs.Min(str => str.Length);
            var result = new StringBuilder();

            for (int i = 0; i < len; i++)
            {
                var c = strs[0][i];
                var match = strs.All(str => str[i] == c);
                if (match)
                {
                    result.Append(c);
                }
                else
                {
                    break;
                }
            }

            return result.ToString();
        }

        public string Solution2(string[] strs)
        {
            if (strs == null || strs.Length == 0)
            {
                return "";
            }

            // Start with the first string in the array
            string prefix = strs[0];

            // Compare the prefix with each string in the array
            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0) // While prefix is not a prefix of strs[i]
                {
                    // Reduce the length of the prefix by one character
                    prefix = prefix.Substring(0, prefix.Length - 1);

                    // If there is no common prefix, return empty string
                    if (prefix == "")
                        return "";
                }
            }

            return prefix;
        }

        public void Execute()
        {
            Console.WriteLine("Running 'Longest Common Prefix' solutions...");

            var testCases = new Dictionary<string[], string>
            {
                { ["flower","flow","flight"], "fl" },
                { ["dog","racecar","car"], "" }
            };

            foreach (var testCase in testCases)
            {
                var actual = Solution(testCase.Key);
                var isCorrect = actual == testCase.Value;
                var text = $"{PrintInputData(testCase.Key)}: {actual} - {isCorrect}";
                PrintResult(isCorrect ? ConsoleColor.Green : ConsoleColor.Red, text);
            }
            Console.WriteLine();
        }

        private string PrintInputData(string[] input)
        {
            return input.Length > 0 ? $"[{string.Join(", ", input)}]" : string.Empty;
        }

        private void PrintResult(ConsoleColor color, string text)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
