using LeetCodeAlgorithms.BL.Helpers;

namespace LeetCodeAlgorithms.BL.Tasks
{
    /// <summary>
    /// 1. Sort the array.
    //  2. Use the first loop to fix the first number(i).
    //  3. Use the second loop to fix the second number(j).
    //  4. Use two pointers(left, right) to find the remaining two numbers.
    //  5. Calculate the sum of four numbers:
    //  - nums[i] + nums[j] + nums[left] + nums[right]
    //  6. If the sum is:
    //  - smaller than target → move left right
    //  - greater than target → move right left
    //  - equal to target → save the quadruplet
    //  7. Skip duplicate values to avoid repeated results.
    //  8. Continue until all combinations are checked.
    //  Complexity
    //  - Time: O(n^3)
    //  - Space: O(1) (excluding output)
    /// </summary>
    public class FourSumTask : IExecutableTask
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            var result = new List<IList<int>>();
            Array.Sort(nums);

            int n = nums.Length;

            for (int i = 0; i < n - 3; i++)
            {
                // Skip duplicates for i
                if (i > 0 && nums[i] == nums[i - 1]) continue;

                for (int j = i + 1; j < n - 2; j++)
                {
                    // Skip duplicates for j
                    if (j > i + 1 && nums[j] == nums[j - 1]) continue;

                    int left = j + 1, right = n - 1;

                    while (left < right)
                    {
                        long sum = (long)nums[i] + nums[j] + nums[left] + nums[right];

                        if (sum == target)
                        {
                            result.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });
                            left++; right--;

                            // Skip duplicates for left and right pointer
                            while (left < right && nums[left] == nums[left - 1]) left++;
                            while (left < right && nums[right] == nums[right + 1]) right--;
                        }
                        else if (sum < target)
                        {
                            left++;
                        }
                        else
                        {
                            right--;
                        }
                    }
                }
            }

            return result;
        }

        public void Execute()
        {
            Console.WriteLine("Running '18. 4Sum ...'");

            var testCases = new[]
            {
                Tuple.Create(new int [] { 1,0,-1,0,-2,2 }, 0),
                Tuple.Create(new int [] { 2, 2, 2, 2, 2 }, 8),
            };

            foreach (var testCase in testCases)
            {
                var result = FourSum(testCase.Item1, testCase.Item2);

                Console.WriteLine($"Input: {PrintDataHelper.PrintArray<int>(testCase.Item1)}");
                Console.WriteLine($"Output: {PrintDataHelper.PrintNestedList<int>(result)}");
                Console.WriteLine("____________________________");
            }
        }
    }
}
