using LeetCodeAlgorithms.BL.Tasks;

namespace LeetCodeAlgorithms.Tests
{
    public class LongestPalindromeSubstringTests
    {
        private readonly LongestPalindromeSubstringTask _solver;

        public LongestPalindromeSubstringTests()
        {
            _solver = new LongestPalindromeSubstringTask();
        }

        [Theory]
        [InlineData("babad", "bab")] // "aba" or "bab"
        [InlineData("cbbd", "bb")]
        [InlineData("a", "a")]
        [InlineData("ac", "a")] // "a" or "c"
        public void Solution_ReturnsCorrectData(string input, string expected)
        {
            var actual = _solver.Solution(input);
            Assert.Equal(expected, actual);
        }
    }
}
