using LeetCodeAlgorithms.BL.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithms.Tests
{
    public class FirstOccurrenceIndexTests
    {
        private readonly FirstOccurrenceIndexTask _solver;

        public FirstOccurrenceIndexTests()
        {
            _solver = new FirstOccurrenceIndexTask();
        }

        [Theory]
        [InlineData("sadbutsad", "sad", 0)]
        [InlineData("leetcode", "leeto", -1)]
        [InlineData("qwertytest", "test", 6)]
        public void Solution1_ReturnsCorrectData(string haystack, string needle, int expected)
        {
            var actual = _solver.Solution(haystack, needle);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("sadbutsad", "sad", 0)]
        [InlineData("leetcode", "leeto", -1)]
        [InlineData("qwertytest", "test", 6)]
        public void Solution2_ReturnsCorrectData(string haystack, string needle, int expected)
        {
            var actual = _solver.Solution2(haystack, needle);
            Assert.Equal(expected, actual);
        }
    }
}
