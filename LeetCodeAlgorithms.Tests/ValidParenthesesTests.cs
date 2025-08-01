using LeetCodeAlgorithms.BL.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithms.Tests
{
    public class ValidParenthesesTests
    {
        private readonly ValidParenthesesTask _solver;

        public ValidParenthesesTests()
        {
            _solver = new ValidParenthesesTask();
        }

        [Theory]
        [InlineData("()", true)]
        [InlineData("()[]{}", true)]
        [InlineData("(]", false)]
        [InlineData("([])", true)]
        [InlineData("([)]", false)]
        public void Solution_ReturnsCorrectData(string input, bool expected)
        {
            var result = _solver.Solution(input);

            Assert.Equal(expected, result);
        }
    }
}
