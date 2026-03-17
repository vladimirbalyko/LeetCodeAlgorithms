namespace LeetCodeAlgorithms.BL.Tasks
{
    // 11. Container With Most Water (Medium)
    public class ContainerWithMostWaterTask : IExecutableTask
    {
        public int Solution(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int maxArea = 0;

            while (left < right)
            {
                int currentArea = Math.Min(height[left], height[right]) * (right - left);
                maxArea = Math.Max(maxArea, currentArea);
                if (height[left] < height[right])
                    left++;
                else
                    right--;
            }

            return maxArea;
        }

        public void Execute()
        {
            Console.WriteLine("Running '11. Container With Most Water'...");
            // Example placeholder run
            var testCases = new[]
            {
                (Input: new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, Expected: 49),
                (Input: new int[] { 1, 1 }, Expected: 1),
                (Input: new int[] { 4, 3, 2, 1, 4 }, Expected: 16),
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
