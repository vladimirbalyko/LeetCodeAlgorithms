using LeetCodeAlgorithms.BL.Helpers;

namespace LeetCodeAlgorithms.BL.Tasks
{
    public class ThreeSumTask : IExecutableTask
    {
        public IList<IList<int>> Solution(int[] nums)
        {
            var result = new List<IList<int>>();
            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0) break;

                if (i > 0 && nums[i] == nums[i - 1]) continue;

                int left = i + 1, right = nums.Length - 1;

                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];

                    if (sum == 0)
                    {
                        result.Add(new List<int>() { nums[i], nums[left], nums[right] });

                        left++; right--;

                        // Skip duplicates for left and right pointer
                        while (left < right && nums[left] == nums[left - 1]) left++;
                        while (left < right && nums[right] == nums[right + 1]) right--;
                    }
                    else if (sum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            return result;
        }

        public void Execute()
        {
            Console.WriteLine("Running '15. 3Sum...");

            var testCases = new[]
            {
                Tuple.Create(new int [] { -1,0,1,2,-1,-4 }),
                Tuple.Create(new int [] { 0, 1, 1 }),
                Tuple.Create(new int [] { 0, 0, 0 }),
            };

            foreach (var testCase in testCases)
            {
                var result = Solution(testCase.Item1);

                Console.WriteLine($"Input: {PrintDataHelper.PrintArray<int>(testCase.Item1)}");
                Console.WriteLine($"Output: {PrintDataHelper.PrintNestedList<int>(result)}");
                Console.WriteLine("____________________________");
            }
        }
    }
}
