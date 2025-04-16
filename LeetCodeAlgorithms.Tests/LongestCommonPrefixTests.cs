using LeetCodeAlgorithms.BL.Tasks;

namespace LeetCodeAlgorithms.Tests
{
    public class LongestCommonPrefixTests
    {
        private readonly LongestCommonPrefixTask _solver;

        public LongestCommonPrefixTests()
        {
            _solver = new LongestCommonPrefixTask();
        }

        [Fact]
        public void Test_Example1()
        {
            var strs = new string[] { "flower", "flow", "flight" };
            var result = _solver.Solution(strs);
            Assert.Equal("fl", result);
        }

        [Fact]
        public void Test_Example2()
        {
            var strs = new string[] { "dog", "racecar", "car" };
            var result = _solver.Solution(strs);
            Assert.Equal("", result);  // No common prefix
        }

        [Fact]
        public void Test_SingleString()
        {
            var strs = new string[] { "hello" };
            var result = _solver.Solution(strs);
            Assert.Equal("hello", result);  // Only one string, so the common prefix is the string itself
        }

        [Fact]
        public void Test_EmptyArray()
        {
            var strs = new string[] { };
            var result = _solver.Solution(strs);
            Assert.Equal("", result);  // Empty array, no prefix
        }

        [Fact]
        public void Test_EmptyStringInArray()
        {
            var strs = new string[] { "flower", "", "flow" };
            var result = _solver.Solution(strs);
            Assert.Equal("", result);  // One empty string means no common prefix
        }

        [Fact]
        public void Test_AllStringsIdentical()
        {
            var strs = new string[] { "hello", "hello", "hello" };
            var result = _solver.Solution(strs);
            Assert.Equal("hello", result);  // All strings are identical, so the common prefix is the entire string
        }

        [Fact]
        public void Test_NoCommonPrefix()
        {
            var strs = new string[] { "abcd", "efgh", "ijkl" };
            var result = _solver.Solution(strs);
            Assert.Equal("", result);  // No common prefix
        }

        [Fact]
        public void Test_LongestCommonPrefixWithVaryingLengths()
        {
            var strs = new string[] { "interstellar", "internet", "internal" };
            var result = _solver.Solution(strs);
            Assert.Equal("inter", result);  // Common prefix is "inter"
        }

        [Fact]
        public void Test_AllSingleCharacterStrings()
        {
            var strs = new string[] { "a", "a", "a" };
            var result = _solver.Solution(strs);
            Assert.Equal("a", result);  // All strings are just "a"
        }
    }
}
