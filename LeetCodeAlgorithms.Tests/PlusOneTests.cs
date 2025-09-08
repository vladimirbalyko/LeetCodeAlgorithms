using LeetCodeAlgorithms.BL.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithms.Tests
{
    public class PlusOneTests
    {
        private readonly PlusOneTask _solver;

        public PlusOneTests()
        {
            _solver = new PlusOneTask();
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 4 })]
        [InlineData(new int[] { 4, 3, 2, 1 }, new int[] { 4, 3, 2, 2 })]
        [InlineData(new int[] { 9 }, new int[] { 1, 0 })]
        public void Solution_ReturnsCorrectData(int[] input, int[] expected)
        {
            var actual = _solver.Solution(input);

            Assert.Equal(expected, actual);
        }
    }
}
