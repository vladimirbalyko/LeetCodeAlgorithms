namespace LeetCodeAlgorithms.BL.Tasks
{
    // 9. Palindrome Number (Easy)
    public class PalindromeNumberTask : IExecutableTask
    {
        // Simple solution
        public bool Solution(int x)
        {
            if (x < 0) return false;

            var origin = x.ToString();
            var y = origin.Reverse();
            var result = string.Join("", y);

            return origin.Equals(result);
        }

        public bool Solution2(int x)
        {
            if (x < 0) return false;

            var origin = x.ToString();
            var len = origin.Length;

            for (var i = 0; i < len / 2; i++)
            {
                if (origin[i] != origin[len - i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        // Advanced solution
        public bool Solution3(int x)
        {
            // Negative numbers and numbers ending with 0 (but not 0 itself) are not palindromes
            if (x < 0 || (x % 10 == 0 && x != 0)) return false;

            int reversed = 0;
            while (x > reversed)
            {
                reversed = reversed * 10 + x % 10;
                x /= 10;
            }

            // For even and odd length numbers
            return x == reversed || x == reversed / 10;
        }

        public void Execute()
        {
            Console.WriteLine("Running '9. Palindrome Number' solutions...");

            int[] testCases =
            [
                121,
                -121,
                10
            ];
            bool[] targets = { true, false, false };

            foreach (int testCase in testCases)
            {
                var result = Solution3(testCase);
                Console.WriteLine($"'{testCase}' - Palindrome Number: {result}");
            }
        }
    }
}
