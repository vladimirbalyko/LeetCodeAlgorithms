using LeetCodeAlgorithms.BL.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithms.Tests
{
    public class StringToIntegerTests
    {
        private readonly StringToIntegerTask _solver;

        public StringToIntegerTests()
        {
            _solver = new StringToIntegerTask();
        }

        [Theory]
        [InlineData("42", 42)]
        [InlineData("   -42", -42)]
        [InlineData("4193 with words", 4193)]
        [InlineData("words and 987", 0)]
        public void Solution_ReturnsCorrectData(string s, int expected)
        {
             var actual = _solver.Solution(s);
             Assert.Equal(actual, expected);
        }
    }
}
