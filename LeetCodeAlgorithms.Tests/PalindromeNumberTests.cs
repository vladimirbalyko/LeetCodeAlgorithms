using LeetCodeAlgorithms.BL.Tasks;

namespace LeetCodeAlgorithms.Tests
{
    public class PalindromeNumberTests
    {
        private readonly PalindromeNumberTask _solver;

        public PalindromeNumberTests()
        {
            _solver = new PalindromeNumberTask();
        }

        [Theory]
        [InlineData(121, true)]
        [InlineData(-121, false)]
        [InlineData(10, false)]
        public void Solution1_ReturnsCorrectData(int input, bool expected)
        {
            var result = _solver.Solution(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(121, true)]
        [InlineData(-121, false)]
        [InlineData(10, false)]
        public void Solution2_ReturnsCorrectData(int input, bool expected)
        {
            var result = _solver.Solution2(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(121, true)]
        [InlineData(-121, false)]
        [InlineData(10, false)]
        public void Solution3_ReturnsCorrectData(int input, bool expected)
        {
            var result = _solver.Solution3(input);

            Assert.Equal(expected, result);
        }
    }
}
