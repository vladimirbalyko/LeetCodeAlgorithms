using LeetCodeAlgorithms.BL.Tasks;
using System;
using Xunit;

namespace LeetCodeAlgorithms.Tests
{
    public class ReverseIntegerTest
    {
        private readonly ReverseIntegerTask _solver;

        public ReverseIntegerTest()
        {
            _solver = new ReverseIntegerTask();
        }

        [Theory]
        [InlineData(123, 321)]
        [InlineData(-123, -321)]
        [InlineData(120, 21)]
        public void Solution_ReturnsCorrectData(int input, int expected)
        {
            var actual = _solver.Solution(input);
            Assert.Equal(expected, actual);
        }
    }
}
