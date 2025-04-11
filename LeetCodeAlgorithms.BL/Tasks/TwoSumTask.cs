namespace LeetCodeAlgorithms.BL.Tasks.TwoSum
{
    // 1. Two Sum (Easy)
    // Given an array of integers nums and an integer target,
    // return indices of the two numbers such that they add up to target.

    // You may assume that each input would have exactly one solution,
    // and you may not use the same element twice.

    // You can return the answer in any order.

    // Example 1:

    // Input: nums = [2, 7, 11, 15], target = 9
    // Output: [0, 1]
    // Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

    // Example 2:

    // Input: nums = [3, 2, 4], target = 6
    // Output: [1, 2]

    // Example 3:

    // Input: nums = [3, 3], target = 6
    // Output: [0, 1]

    //Constraints:

    // 2 <= nums.length <= 104
    // -109 <= nums[i] <= 109
    // -109 <= target <= 109
    // Only one valid answer exists.

    // Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?
    // https://leetcode.com/problems/two-sum/description/
    public class TwoSumTask
    {
        // Simple solution
        public static int[] Solution(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return [i, j];
                    }
                }
            }

            return [];
        }

        // Advanced solution
        public static int[] Solution2(int[] nums, int target)
        {
            Dictionary<int, int> numMap = [];

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (numMap.TryGetValue(complement, out int index))
                {
                    return [index, i];
                }
                numMap[nums[i]] = i;
            }

            return [];
        }

        public void Execute()
        {
            Console.WriteLine("Running 'Two Sum' solutions...");

            int[][] testCases =
            [
                [2, 7, 11, 15],
                [3, 2, 4],
                [3, 3]
            ];
            int[] targets = { 9, 6, 6 };

            foreach (var method in new Func<int[], int, int[]>[] { Solution, Solution2 })
            {
                Console.WriteLine($"\nExecuting {method.Method.Name}:");

                for (int i = 0; i < testCases.Length; i++)
                {
                    PrintResult(method(testCases[i], targets[i]));
                }
            }
        }

        private static void PrintResult(int[] result)
        {
            if (result.Length == 2)
            {
                Console.WriteLine($"[{result[0]}, {result[1]}]");
            }
            else
            {
                Console.WriteLine("No valid pair found.");
            }
        }
    }
}
