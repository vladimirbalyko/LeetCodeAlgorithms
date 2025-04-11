using LeetCodeAlgorithms.BL.Tasks.LongestSubstring;

namespace LeetCodeAlgorithms.Tests
{
    public class LongestSubstringTaskTests
    {
        private readonly LongestSubstringTask _solver;

        public LongestSubstringTaskTests()
        {
            _solver = new LongestSubstringTask();
        }

        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        [InlineData("", 0)]
        [InlineData("abcdef", 6)]
        [InlineData("abba", 2)]
        [InlineData("aab", 2)]
        [InlineData("dvdf", 3)]
        public void Solution_ReturnsCorrectLength(string input, int expected)
        {
            var result = _solver.Solution(input);
            Assert.Equal(expected, result);
        }
    }
}