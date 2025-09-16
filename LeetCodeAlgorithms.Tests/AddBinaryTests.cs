namespace LeetCodeAlgorithms.Tests
{
    public class AddBinaryTests
    {
        private readonly AddBinaryTask _solver;

        public AddBinaryTests()
        {
            _solver = new AddBinaryTask();
        }

        [Theory]
        [InlineData("11", "1", "100")]
        [InlineData("1010", "1011", "10101")]
        public void Solution1_ReturnsCorrectData(string a, string b, string expected)
        {
            var actual = _solver.Solution(a, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("11", "1", "100")]
        [InlineData("1010", "1011", "10101")]
        public void Solution2_ReturnsCorrectData(string a, string b, string expected)
        {
            var actual = _solver.Solution(a, b);
            Assert.Equal(expected, actual);
        }
    }
}
