using LeetCodeAlgorithms.BL.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithms.Tests
{
    public class LengthOfLastWordTests
    {
        private readonly LengthOfLastWordTask _solver;

        public LengthOfLastWordTests()
        {
            _solver = new LengthOfLastWordTask();
        }

        [Theory]
        [InlineData("", 0)]
        [InlineData("Hello World", 5)]
        [InlineData("   fly me   to   the moon  ", 4)]
        [InlineData("luffy is still joyboy", 6)]
        [InlineData("a", 1)]
        public void Solution1_ReturnsCorrectData(string s, int expected)
        {
            var actual = _solver.Solution(s);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("", 0)]
        [InlineData("Hello World", 5)]
        [InlineData("   fly me   to   the moon  ", 4)]
        [InlineData("luffy is still joyboy", 6)]
        [InlineData("a", 1)]
        public void Solution2_ReturnsCorrectData(string s, int expected)
        {
            var actual = _solver.Solution(s);
            Assert.Equal(expected, actual);
        }
    }
}
