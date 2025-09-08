using LeetCodeAlgorithms.BL.Helpers;

namespace LeetCodeAlgorithms.BL.Tasks
{
    // 66. Plus One (Easy)
    public class PlusOneTask : IExecutableTask
    {
        public int[] Solution(int[] digits)
        {
            if (digits == null || digits.Length == 0)
            {
                return [1];
            }

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }

            int[] result = new int[digits.Length + 1];
            result[0] = 1;
            return result;
        }

        public void Execute()
        {
            int[][] testCases =
            [
                [1,2,3],
                [4,3,2,1],
                [9],
                [9,9,9]
            ];

            int[][] expectedResult =
            [
                [1,2,4],
                [4,3,2,2],
                [1,0],
                [1,0,0,0]
            ];

            for (int i = 0; i < testCases.Length; i++)
            {
                var input = testCases[i];
                var result = Solution(input);

                Console.WriteLine($"Input Data: \"{PrintDataHelper.PrintArray(input)}\";");
                Console.WriteLine($"Expected: {PrintDataHelper.PrintArray(expectedResult[i])}; Actual: {PrintDataHelper.PrintArray(result)};");

                if (ArrayComparer.AreEqual(result, expectedResult[i]))
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
