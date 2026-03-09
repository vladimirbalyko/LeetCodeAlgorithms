using System;

namespace LeetCodeAlgorithms.BL.Tasks
{
    // 8. String to Integer (atoi)
    public class StringToIntegerTask : IExecutableTask
    {
        // Convert string to integer following LeetCode problem 8 requirements
        public int Solution(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            // 1. Skip whitespace
            s = s.TrimStart();

            if (string.IsNullOrEmpty(s))
                return 0;

            int i = 0;
            // 2. Check sign
            int sign = s[i] == '-' ? -1 : 1;
            long result = 0;

            int INT_MAX = int.MaxValue;   // 2147483647
            int INT_MIN = int.MinValue;   // -2147483648

            if (s[i] == '+' || s[i] == '-')
                i++;

            // 3. Convert digits to integer
            while (i < s.Length && char.IsDigit(s[i]))
            {
                int digit = s[i] - '0';
                result = result * 10 + digit;

                // 4. Overflow check
                if (sign * result >= INT_MAX)
                    return INT_MAX;

                if (sign * result <= INT_MIN)
                    return INT_MIN;

                i++;
            }

            return (int)(sign * result);
        }

        public void Execute()
        {
            Console.WriteLine("Running '8. String to Integer (atoi)' solutions...");

            var testCases = new[]
            {
                (Input: "42", Expected: 42),
                (Input: " -042", Expected: -42),
                (Input: "1337c0d3", Expected: 1337),
            };

            foreach (var testCase in testCases)
            {
                var result = Solution(testCase.Input);
                if (result == testCase.Expected)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Input: '{testCase.Input}'; Result: {result}; Expected: {testCase.Expected}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Input: '{testCase.Input}'; Actual: {result}; Expected: {testCase.Expected}");
                }
                Console.ResetColor();
            }
        }
    }
}
