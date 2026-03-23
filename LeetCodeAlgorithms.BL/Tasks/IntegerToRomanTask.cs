using LeetCodeAlgorithms.BL.Tasks;
using System.Text;

public class IntegerToRomanTask : IExecutableTask
{
    public string Solution(int num)
    {
        var map = new (int value, string symbol)[]
            {
                (1000, "M"),
                (900, "CM"),
                (500, "D"),
                (400, "CD"),
                (100, "C"),
                (90, "XC"),
                (50, "L"),
                (40, "XL"),
                (10, "X"),
                (9, "IX"),
                (5, "V"),
                (4, "IV"),
                (1, "I")
        };

        var result = new StringBuilder();

        foreach (var (value, symbol) in map)
        {
            while (num >= value)
            {
                num -= value;
                result.Append(symbol);
            }
        }

        return result.ToString();
    }

    public void Execute()
    {
        Console.WriteLine("Running '12. Integer to Roman' solutions...");

        var testCases = new[]
            {
                Tuple.Create(3749, "MMMDCCXLIX"),
                Tuple.Create(58, "LVIII"),
                Tuple.Create(1994, "MCMXCIV"),
            };

        foreach (var testCase in testCases)
        {
            var result = Solution(testCase.Item1);

            Console.WriteLine(testCase.ToString());
            if (result == testCase.Item2)
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
            Console.ResetColor();
        }
    }
}