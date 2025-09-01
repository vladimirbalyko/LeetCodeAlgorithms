namespace LeetCodeAlgorithms.BL.Tasks
{
    // 58. Length of Last Word (Easy)
    public class LengthOfLastWordTask : IExecutableTask
    {
        // Main solution
        public int Solution(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return 0;
            }

            var str = s.TrimEnd();
            for (var i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] == ' ')
                {
                    return str.Length - 1 - i;
                }
            }
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] == ' ')
                {
                    return str.Length - 1 - i;
                }
            }

            return str.Length;
        }

        // Easy but slow solution
        public int Solution2(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return 0;
            }
            string[] words = s.Trim().Split(' ');
            return words.Length == 0 ? 0 : words[^1].Length;
        }

        public void Execute()
        {
            string[] testCases =
            [
                "Hello World",
                "   fly me   to   the moon  ",
                "luffy is still joyboy"
            ];

            int[] expectedResult =
            [
                5,
                4,
                6,
            ];

            for (int i = 0; i < testCases.Length; i++)
            {
                var inputString = testCases[i];
                var result = Solution(inputString);

                Console.WriteLine("Input Data: \"${inputString}\";");
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
