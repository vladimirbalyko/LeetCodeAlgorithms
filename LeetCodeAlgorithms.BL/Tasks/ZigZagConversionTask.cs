using System.Text;

namespace LeetCodeAlgorithms.BL.Tasks
{
    // 6. Zigzag Conversion (Medium)
    public class ZigZagConversionTask : IExecutableTask
    {
        public string Solution(string s, int numRows)
        {
            if (numRows == 1 || s.Length <= numRows)
                return s;

            var rows = new StringBuilder[Math.Min(numRows, s.Length)];
            for (int i = 0; i < rows.Length; i++)
                rows[i] = new StringBuilder();

            int row = 0;
            int direction = 1; // 1 for down, -1 for up
            foreach (char c in s)
            {
                rows[row].Append(c);

                if (row == 0)
                    direction = 1; // Change direction to down
                else if (row == numRows - 1)
                    direction = -1; // Change direction to up

                row += direction;
            }

            var result = new StringBuilder();
            foreach (var r in rows)
                result.Append(r);

            return result.ToString();
        }

        public void Execute()
        {
            Console.WriteLine("Running '6. Zigzag Conversion ...");

            var testCases = new[]
            {
                Tuple.Create("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR"),
                Tuple.Create("PAYPALISHIRING", 4, "PINALSIGYAHRPI"),
                Tuple.Create("A", 1, "A"),
            };

            foreach (var testCase in testCases)
            {
                var result = Solution(testCase.Item1, testCase.Item2);
                if (result == testCase.Item3)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Result: {result}");
                    Console.WriteLine("Correct result!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Actual result: {result}; Expected result: {testCase.Item2}");
                    Console.WriteLine("Wrong result!");
                }
            }
        }
    }
}
