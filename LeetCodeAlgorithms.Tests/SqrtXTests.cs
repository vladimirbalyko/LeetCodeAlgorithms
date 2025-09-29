using LeetCodeAlgorithms.BL.Tasks;

namespace LeetCodeAlgorithms.Tests
{
    public class SqrtXTests
    {
        private readonly SqrtXTask _solver;

        public SqrtXTests()
        {
            _solver = new SqrtXTask();
        }

        [Theory]
        [InlineData(9, 3)]
        [InlineData(3, 1)]
        [InlineData(4, 2)]
        [InlineData(8, 2)]
        [InlineData(36, 6)]
        [InlineData(2147395599, 46339)]
        public void Solution1_ReturnsCorrectData(int x, int expected)
        {
            var actual = _solver.Solution(x);
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(9, 3)]
        [InlineData(3, 1)]
        [InlineData(4, 2)]
        [InlineData(8, 2)]
        [InlineData(36, 6)]
        [InlineData(2147395599, 46339)]
        public void Solution2_ReturnsCorrectData(int x, int expected)
        {
            var actual = _solver.Solution2(x);
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(9, 3)]
        [InlineData(3, 1)]
        [InlineData(4, 2)]
        [InlineData(8, 2)]
        [InlineData(36, 6)]
        [InlineData(2147395599, 46339)]
        public void Solution3_ReturnsCorrectData(int x, int expected)
        {
            var actual = _solver.Solution3(x);
            Assert.Equal(actual, expected);
        }
    }
}
