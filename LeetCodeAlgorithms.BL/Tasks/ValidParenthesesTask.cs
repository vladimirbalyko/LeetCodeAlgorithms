namespace LeetCodeAlgorithms.BL.Tasks
{
    // 20. Valid Parentheses (Easy)
    public class ValidParenthesesTask : IExecutableTask
    {
        public bool Solution(string s)
        {
            var stack = new Stack<char>();

            foreach (var c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0) return false;

                    var top = stack.Pop();

                    if ((c == ')' && top != '(') ||
                        (c == '}' && top != '{') ||
                        (c == ']' && top != '['))
                    {
                        return false;
                    }
                }
            }

           return stack.Count == 0;
        }

        public void Execute()
        {
            Console.WriteLine("Running '20. Valid Parentheses' solutions...");

            var testCases = new Dictionary<string, bool>
            {
                { "()", true },
                { "()[]{}", true },
                { "(]", false },
                { "([])", true },
                { "([)]", false }
            };

            foreach (var testCase in testCases)
            {
                var value = testCase.Key;
                var actual = Solution(value);
                var expected = testCase.Value;

                Console.ForegroundColor =
                        actual == expected ? ConsoleColor.Green : ConsoleColor.Red;

                Console.WriteLine($"'{value}': actual: {actual}; expected: {testCase.Value}");
                Console.ResetColor();
            }
        }
    }
}
