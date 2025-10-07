using LeetCodeAlgorithms.BL.Tasks;

namespace LeetCodeAlgorithms.Tests
{
    public class ClimbingStairsTests
    {
        private readonly ClimbingStairsTask _solver;

        public ClimbingStairsTests()
        {
            _solver = new ClimbingStairsTask();
        }

        [Theory]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        public void Solution1_ReturnsCorrectData(int n, int expected)
        {
            var actual = _solver.Solution(n);
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        public void Solution2_ReturnsCorrectData(int n, int expected)
        {
            var actual = _solver.Solution2(n);
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        public void Solution3_ReturnsCorrectData(int n, int expected)
        {
            var actual = _solver.Solution3(n);
            Assert.Equal(actual, expected);
        }
    }
}
