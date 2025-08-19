namespace LeetCodeAlgorithms.BL.Tasks
{
    // 28. Find the Index of the First Occurrence in a String (Easy)
    public class FirstOccurrenceIndexTask : IExecutableTask
    {
        public int Solution(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle))
            {
                return 0;
            }

            return haystack.IndexOf(needle);
        }

        // Solution without IndexOf
        public int Solution2(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle))
            {
                return 0;
            }

            for (var i = 0; i <= haystack.Length - needle.Length; i++)
            {
                var matched = true;
                for (var j = 0; j < needle.Length; j++)
                {
                    if (needle[j] != haystack[i + j])
                    {
                        matched = false;
                        break;
                    }
                }
                if (matched)
                {
                    return i;
                }
            }

            return -1;
        }

        public void Execute()
        {
            Console.WriteLine("Running '28. Find the Index of the First Occurrence in a String' solutions...");

            TestCase[] testCases =
            [
                new TestCase("sadbutsad", "sad", 0),
                new TestCase("leetcode", "leeto", -1),
                new TestCase("qwertytest", "test", 6),
            ];

            foreach (var testCase in testCases)
            {
                var result = Solution2(testCase.Haystack, testCase.Needle);

                Console.WriteLine(testCase.ToString());
                if (result == testCase.Result)
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

        private class TestCase
        {
            public TestCase(string haystack, string needle, int result)
            {
                Haystack = haystack;
                Needle = needle;
                Result = result;
            }

            public string Haystack { get; set; }
            public string Needle { get; set; }
            public int Result { get; set; }

            public override string ToString()
            {
                return $"Haystack: {Haystack}; Needle: {Needle};";
            }
        }
    }
}
