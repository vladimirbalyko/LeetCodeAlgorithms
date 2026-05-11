using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithms.BL.Tasks
{
    public class LetterCombinationsOfAPhoneNumberTask : IExecutableTask
    {
        public IList<string> LetterCombinations(string digits)
        {
            var result = new List<string>();

            var digitToCharMap = new Dictionary<char, string>
            {
                { '2', "abc" },
                { '3', "def" },
                { '4', "ghi" },
                { '5', "jkl" },
                { '6', "mno" },
                { '7', "pqrs" },
                { '8', "tuv" },
                { '9', "wxyz" }
            };

            if (string.IsNullOrEmpty(digits))
                return result;

            void Backtrack(int index, StringBuilder current)
            {
                if (index == digits.Length)
                {
                    result.Add(current.ToString());
                    return;
                }

                var letters = digitToCharMap[digits[index]];
                foreach (var letter in letters)
                {
                    Backtrack(index + 1, current.Append(letter));
                    current.Length--;
                }
            }

            Backtrack(0, new StringBuilder());

            return result;
        }

        public void Execute()
        {
            Console.WriteLine("Running '17. Letter Combinations of a Phone Number ...'");

            var tastCases = new[]
            {
                Tuple.Create("23"),
                Tuple.Create(""),
                Tuple.Create("2"),
            };

            foreach (var testCase in tastCases)
            {
                var result = LetterCombinations(testCase.Item1);
                Console.WriteLine($"Input: {testCase.Item1} => Output: [{string.Join(", ", result)}]");
            }
        }
    }
}
