using LeetCodeAlgorithms.BL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithms.BL.Tasks
{
    public class ThreeSumClosestTask : IExecutableTask
    {
        public int Solution(int[] nums, int target)
        {
            Array.Sort(nums);
            int closestSum = nums[0] + nums[1] + nums[2];

            for (int i = 0; i < nums.Length - 2; i++)
            {
                int left = i + 1, right = nums.Length - 1;

                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];

                    if (Math.Abs(sum - target) < Math.Abs(closestSum - target))
                    {
                        closestSum = sum;
                    }

                    if (sum < target)
                    {
                        left++;
                    }
                    else if (sum > target)
                    {
                        right--;
                    }
                    else
                    {
                        return sum; // Exact match found
                    }
                }
            }

            return closestSum;
        }

        public void Execute()
        {
            Console.WriteLine("Running '16. 3Sum Closest...");

            var testCases = new[]
            {
                Tuple.Create(new int [] { -1, 2, 1, -4 }, 1, 2),
                Tuple.Create(new int [] { 0, 0, 0 }, 1, 0),
            };

            foreach (var testCase in testCases)
            {
                var result = Solution(testCase.Item1, testCase.Item2);

                var isCorrect = result == testCase.Item3;

                Console.WriteLine($"Input: {PrintDataHelper.PrintArray<int>(testCase.Item1)}");

                Console.WriteLine($"Expected: {testCase.Item3};");

                if (isCorrect)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct result!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Actual result: {result}; Wrong result!");
                }
                Console.ResetColor();
            }
        }
    }
}
