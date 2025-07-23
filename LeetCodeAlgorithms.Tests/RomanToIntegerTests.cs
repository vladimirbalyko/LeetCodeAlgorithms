using LeetCodeAlgorithms.BL.Tasks;

namespace LeetCodeAlgorithms.Tests
{
    public class RomanToIntegerTests
    {
        private readonly RomanToIntegerTask _solver;

        public RomanToIntegerTests()
        {
            _solver = new RomanToIntegerTask();
        }

        [Theory]
        [InlineData("III", 3)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCIV", 1994)]
        public void Solution1_ReturnsCorrectData(string input, int expected)
        {
            var result = _solver.Solution(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("III", 3)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCIV", 1994)]
        public void Solution2_ReturnsCorrectData(string input, int expected)
        {
            var result = _solver.Solution2(input);

            Assert.Equal(expected, result);
        }
    }
}
