namespace LeetCodeAlgorithms.BL.Tasks
{
    // 27. Remove Element (Easy)
    public class RemoveElementTask : IExecutableTask
    {
        public int Solution(int[] nums, int val)
        {
            int k = 0;

            for (var i = 0; i < nums.Length; i++ )
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }

            return k;
        }

        public void Execute()
        {
            Console.WriteLine("Running '27. Remove Element' solutions...");

            int[][] numsArr =
            [
                [3,2,2,3],
                [0,1,2,2,3,0,4,2]
            ];
            int[] valArr = { 3, 2 };

            int[][] targets =
            {
                [2, 2],
                [0, 1, 3, 0, 4]
            };

            for (var i = 0; i < numsArr.Length; i++)
            {
                var inputCopy = (int[])numsArr[i].Clone();
                var result = Solution(inputCopy, valArr[i]);

                var expected = targets[i];

                Console.WriteLine($"\nInitial data:");
                Console.WriteLine($"Array: {PrintInputData(numsArr[i])};\nRemove value: {valArr[i]};");

                Console.WriteLine($"\nExpected value: {PrintInputData(expected)}");
                Console.WriteLine($"Actual value: {PrintInputData(inputCopy, result)}");
                Console.WriteLine();
            }
        }

        private string PrintInputData(int[] input, int? l = null)
        {
            if (input.Length == 0) return string.Empty;
            return $"[{string.Join(", ", l != null ? input.Take((int)l) : input)}]";
        }
    }
}
