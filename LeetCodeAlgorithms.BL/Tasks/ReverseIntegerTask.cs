namespace LeetCodeAlgorithms.BL.Tasks
{
    // 7. Reverse Integer (Medium)
    public class ReverseIntegerTask : IExecutableTask
    {
        // Reverse integer with overflow handling placeholder
        public int Solution(int x)
        {
            var result = 0;

            while (x != 0)
            {
                int digit = x % 10;
                x /= 10;

                // Check for overflow before multiplying result by 10
                if (result > int.MaxValue / 10 ||
                    (result == int.MaxValue / 10 && digit > 7))
                    return 0;

                if (result < int.MinValue / 10 || 
                    (result == int.MinValue / 10 && digit < -8))
                    return 0;

                result = result * 10 + digit;
            }

            return result;
        }

        public void Execute()
        {
            Console.WriteLine("Running '7. Reverse Integer' solutions...");

            var testCases = new[]
            {
                (Input: 123, Expected: 321),
                (Input: -123, Expected: -321),
                (Input: 120, Expected: 21),
            };

            foreach (var testCase in testCases)
            {
                var result = Solution(testCase.Input);
                if (result == testCase.Expected)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Input: {testCase.Input}; Result: {result}; Expected: {testCase.Expected}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Input: {testCase.Input}; Actual: {result}; Expected: {testCase.Expected}");
                }
                Console.ResetColor();
            }
        }
    }
}
