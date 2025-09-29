namespace LeetCodeAlgorithms.BL.Tasks
{
    // 69. Sqrt(x) (Easy)
    // Binary Search (for positive numbers)
    // A simple and universal method.
    // - Set the interval [0, N] (if 𝑁 > 1, otherwise [0,1]).
    // - Take the midpoint 𝑚=(𝑙+𝑟)/2.
    // - Compare 𝑚*𝑚 with 𝑁.
    //      - If 𝑚*𝑚 < 𝑁, shift the left boundary: 𝑙 = 𝑚.
    //      If 𝑚*𝑚 > 𝑁, shift the right boundary: 𝑟 = 𝑚.
    // Repeat until the interval becomes smaller than the required precision.
    // Algorithm:
    // N=8
    // Interval: [𝑙,𝑟]=[0,8]
    // While 𝑟−𝑙 > 0.001:
    //      - m=(l+r)/2
    //      - If 𝑚*𝑚 < 8 → shift 𝑙=𝑚
    //      - Else → 𝑟=𝑚
    public class SqrtXTask : IExecutableTask
    {
        // The most accurate solution allows you to calculate the square root with a certain accuracy
        public int Solution(int x)
        {
            if (x == 1) return 1;

            decimal l = 0;
            decimal r = x;
            decimal m = 0;
            decimal accuracy = 0.001m;

            while (r - l > accuracy)
            {
                m = (l + r) / 2;
                var _m = (int)m;
                if ((_m * _m) == x)
                    return _m;
                else if ((m * m) < x)
                    l = m;
                else
                    r = m;
            }

            return (int)m;
        }

        // Easy solution
        public int Solution2(int x)
        {
            if (x == 1) return 1;
            long l = 0, r = x, answer = 0;

            while (l <= r)
            {
                long m = (l + r) / 2;
                long square = m * m;
                if (square == x) return (int)m;
                else if (square < x)
                {
                    l = m + 1;
                    answer = m;
                }
                else
                {
                    r = m - 1;
                }
            }

            return (int)answer;
        }

        // Fast solution
        public int Solution3(int x)
        {
            if (x == 0) return 0;
            if (x == 1) return 1;
            int left = 1, right = x / 2, ans = 0;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                long square = (long)mid * mid;
                if (square == x)
                    return mid;
                else if (square < x)
                {
                    left = mid + 1;
                    ans = mid; // Update answer to the current mid
                }
                else
                {
                    right = mid - 1;
                }
            }
            return ans;
        }

        public void Execute()
        {
            Console.WriteLine("Running '69. Sqrt(x)' solutions...");

            int[] testCases = [9, 3, 4, 8, 36, 2147395599];
            int[] expected = [3, 1, 2, 2, 6, 46339];

            for (var i = 0; i < testCases.Length; i++)
            {
                var result = Solution(testCases[i]);

                Console.WriteLine($"√{testCases[i]} = {result}");
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
