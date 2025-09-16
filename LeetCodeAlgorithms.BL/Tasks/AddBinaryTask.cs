using LeetCodeAlgorithms.BL.Tasks;

public class AddBinaryTask : IExecutableTask
{
    // Fast solution
    public string Solution(string a, string b)
    {
        int i = a.Length - 1;
        int j = b.Length - 1;
        int carry = 0;
        var result = new System.Text.StringBuilder();

        while (i >= 0 || j >= 0 || carry > 0)
        {
            int sum = carry;

            if (i >= 0)
            {
                sum += a[i] - '0';
                i--;
            }

            if (j >= 0)
            {
                sum += b[j] - '0';
                j--;
            }

            result.Insert(0, (sum % 2).ToString()); // Append bit at the front
            carry = sum / 2;
        }

        return result.ToString();
    }

    public string Solution2(string a, string b)
    {
        if (string.IsNullOrEmpty(a))
            return b;

        if (string.IsNullOrEmpty(b))
            return a;

        var c = "";

        string max, min = "";
        if (a.Length > b.Length)
        {
            max = a;
            min = b;
        }
        else
        {
            max = b;
            min = a;
        }

        bool add = false;
        for (var i = 1; i <= max.Length; i++)
        {
            int s = 0;
            s = max[max.Length - i] - '0';
            if (min.Length >= i)
            {
                s += min[min.Length - i] - '0';
            }

            if (add) s++;

            switch (s)
            {
                case < 2: // s < 2
                    c = s + c;
                    add = false;
                    break;
                case 2:
                    c = "0" + c;
                    add = true;
                    break;
                case 3:
                    c = "1" + c;
                    add = true;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(s), "Unexpected value of s");
            }
        }

        if (add) c = "1" + c;

        return c;
    }

    public void Execute()
    {
        Console.WriteLine("Running '67. Add Binary' solutions...");

        TestCase[] testCases =
        [
            new TestCase("11", "1", "100"),
            new TestCase("1010", "1011", "10101"),
        ];

        foreach (var testCase in testCases)
        {
            var result = Solution2(testCase.A, testCase.B);

            Console.WriteLine(testCase.ToString());
            if (result == testCase.Result)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Result: {result}");
                Console.WriteLine("Correct result!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Actual result: {result}; Expected result: {testCase.Result}");
                Console.WriteLine("Wrong result!");
            }
            Console.ResetColor();
        }
    }

    private class TestCase
    {
        public TestCase(string a, string b, string result)
        {
            A = a;
            B = b;
            Result = result;
        }

        public string A { get; set; }
        public string B { get; set; }
        public string Result { get; set; }

        public override string ToString()
        {
            return $"A: {A}; B: {B};";
        }
    }
}