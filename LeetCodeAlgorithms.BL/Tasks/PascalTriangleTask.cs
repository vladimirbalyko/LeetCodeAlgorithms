namespace LeetCodeAlgorithms.BL.Tasks.PascalTriangle
{
    // 118. Pascal's Triangle (Easy)
    // Given an integer numRows, return the first numRows of Pascal's triangle.
    //In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:

    //Example 1:
    //Input: numRows = 5
    //Output: [[1],[1, 1],[1, 2, 1],[1, 3, 3, 1],[1, 4, 6, 4, 1]]

    //Example 2:
    //Input: numRows = 1
    //Output: [[1]]

    //Constraints:

    //1 <= numRows <= 30
    // https://leetcode.com/problems/pascals-triangle/description/
    public class PascalTriangleTask : IExecutableTask
    {
        public IList<IList<int>> Solution(int numRows)
        {
            IList<IList<int>> triangle = [];

            for (int i = 0; i < numRows; i++)
            {
                IList<int> row = [];
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        row.Add(1);
                    }
                    else
                    {
                        row.Add(triangle[i - 1] [j - 1] + triangle[i - 1][j]);
                    }
                }
                triangle.Add(row);
            }

            return triangle;
        }

        public void Execute()
        {
            Console.WriteLine("Running 'Pascal's Triangle' solutions...");

            int[] testCases = [5, 1];

            foreach (int testCase in testCases)
            {
                var result = Solution(testCase);
                Console.WriteLine($"{testCase}:");
                PrintResult(result);
                Console.WriteLine();
            }
        }

        public static void PrintResult(IList<IList<int>> triangle)
        {
            int numRows = triangle.Count;
            for (int i = 0; i < numRows; i++)
            {
                Console.Write(new string(' ', (numRows - i) * 2));
                foreach (int num in triangle[i])
                {
                    Console.Write(num + "   ");
                }
                Console.WriteLine();
            }
        }

        private static void SimplePrintResult(IList<IList<int>> triangle)
        {
            foreach (var row in triangle)
            {
                foreach (var element in row)
                {
                    Console.Write($"{element} ");
                }
                Console.WriteLine();
            }
        }
    }
}
