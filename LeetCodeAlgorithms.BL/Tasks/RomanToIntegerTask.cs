using System;

namespace LeetCodeAlgorithms.BL.Tasks
{
    // 13. Roman to Integer (Easy)
    public class RomanToIntegerTask : IExecutableTask
    {
        private readonly Dictionary<char, int> _romanMap;

        public RomanToIntegerTask()
        {
            _romanMap = new Dictionary<char, int>()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 },
            };
        }

        public int Solution(string s)
        {
            if (s?.Length == 0) return 0;

            int result = 0;
            int index = 0;
            int len = s.Length;

            while (index < len)
            {
                if (index < len - 1 && _romanMap[s[index]] < _romanMap[s[index + 1]])
                {
                    result += _romanMap[s[index + 1]] - _romanMap[s[index]];
                    index += 2;
                }
                else
                {
                    result += _romanMap[s[index]];
                    index++;
                }
            }

            return result;
        }

        public int Solution2(string s)
        {
            int total = 0;

            for (int i = 0; i < s.Length; i++)
            {
                // If the current value is less than the next one, subtract it
                if (i < s.Length - 1 && _romanMap[s[i]] < _romanMap[s[i + 1]])
                {
                    total -= _romanMap[s[i]];
                }
                else
                {
                    total += _romanMap[s[i]];
                }
            }

            return total;
        }

        public void Execute()
        {
            Console.WriteLine("Running '13. Roman to Integer' solutions...");

            string[] testCases =
            [
                "III",
                "LVIII",
                "MCMXCIV"
            ];
            int[] targets = { 3, 58, 1994 };

            for (int i = 0; i < testCases.Length; i++)
            {
                var value = testCases[i];
                var actual = Solution(value);
                var expected = targets[i];

                Console.WriteLine($"'{value}': actual: {actual}; expected: {expected}");
            }
        }
    }
}
