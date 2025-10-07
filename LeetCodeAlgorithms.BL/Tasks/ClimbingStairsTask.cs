namespace LeetCodeAlgorithms.BL.Tasks
{
    // 70. Climbing Stairs (Easy)
    // This problem is equivalent to computing the nth Fibonacci number:
    // To reach step n, you can come from either:
    //      - step n-1 (taking 1 step), or
    //      - step n-2 (taking 2 steps)
    // So: ways(n) = ways(n - 1) + ways(n - 2)
    // We can solve this iteratively in O(n) time and O(1) space.
    public class ClimbingStairsTask : IExecutableTask
    {
        /// <summary>
        /// Fast algorithm
        /// </summary>
        public int Solution(int n)
        {
            if (n <= 2) return n;

            int first = 1, second = 2;
            for (int i = 3; i <= n; i++)
            {
                int current = first + second;
                first = second;
                second = current;
            }

            return second;
        }

        /// <summary>
        /// Calculating a factorial using recursion
        /// </summary>
        public int Solution2(int n)
        {
            if (n <= 2) return n;
            return Solution2(n - 1) + Solution2(n - 2);
        }


        private Dictionary<int, int> memo = new();
        /// <summary>
        /// Calculating a factorial using recursion with optimization
        /// </summary>
        public int Solution3(int n)
        {
            if (n <= 2) return n;

            if (memo.ContainsKey(n)) return memo[n];

            int result = Solution3(n - 1) + Solution3(n - 2);

            memo[n] = result;

            return result;
        }

        public void Execute()
        {
            Console.WriteLine("Running '70. Climbing Stairs' solutions...");

            int[] testCases = [2, 3];
            int[] expected = [2, 3];

            for (var i = 0; i < testCases.Length; i++)
            {
                var result = Solution(testCases[i]);

                Console.WriteLine($"{testCases[i]}-step staircase can be walked in '{result}' steps");
                if (result == expected[i])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Result: {result}");
                    Console.WriteLine("Correct result!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Actual result: {result}; Expected result: {expected[i]}");
                    Console.WriteLine("Wrong result!");
                }
                Console.ResetColor();
            }
        }
    }
}
