using LeetCodeAlgorithms.BL.Tasks;

namespace LeetCodeAlgorithms.Tests
{
    public class LetterCombinationsOfAPhoneNumberTests
    {
        private readonly LetterCombinationsOfAPhoneNumberTask _solution;

        public LetterCombinationsOfAPhoneNumberTests()
        {
            _solution = new LetterCombinationsOfAPhoneNumberTask();
        }

        [Theory]
        [InlineData("23", new[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" })]
        [InlineData("", new string[] { })]
        [InlineData("2", new[] { "a", "b", "c" })]
        public void TestLetterCombinations_ReturnsCorrectData(string input, string[] expected)
        {
            var result = _solution.LetterCombinations(input);

            Assert.Equal(expected.Length, result.Count);

            foreach (var item in result)
            {
                Assert.Contains(item, expected);
            }
        }
    }
}
