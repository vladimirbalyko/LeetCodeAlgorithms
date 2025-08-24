using LeetCodeAlgorithms.BL.Helpers;

namespace LeetCodeAlgorithms.BL.Tasks
{
    // 35. Search Insert Position (Easy)
    public class SearchInsertPositionTask : IExecutableTask
    {
        public int Solution(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= target)
                {
                    return i;
                }
            }

            return nums.Length;
        }

        public int Solution2(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }

            int left = 0, right = nums.Length - 1;
            int mid = 0;
            while (left <= right)
            {
                mid = left + (right - left) / 2;
                if (nums[mid] == target)
                {
                    return mid; // Target found
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1; // Search in the right half
                }
                else
                {
                    right = mid - 1; // Search in the left half
                }
            }

            return ++mid;
        }

        public void Execute()
        {
            Console.WriteLine("Running '35. Search Insert Position' solutions...");

            int[][] testCases =
            [
                [1,3,5,6],
                [1,3,5,6],
                [1,3,5,6]
            ];

            int[] target =
            [
                5,
                2,
                7,
            ];

            int[] expectedResult =
            [
                2,
                1,
                4,
            ];

            for (int i = 0; i < testCases.Length; i++)
            {
                var result = Solution(testCases[i], target[i]);

                Console.WriteLine("Input Data:");
                var inputArray = PrintDataHelper.PrintArray(testCases[i]);
                Console.WriteLine($"Array: {inputArray}; Targer: {target[i]};");
                Console.WriteLine($"Expected: {expectedResult[i]}; Actual: {result};");
                if (result == expectedResult[i])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct result!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong result!");
                }
                Console.ResetColor();
            }
        }
    }
}
