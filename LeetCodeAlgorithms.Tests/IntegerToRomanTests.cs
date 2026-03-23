namespace LeetCodeAlgorithms.Tests
{
    public class IntegerToRomanTests
    {
        private readonly IntegerToRomanTask _solver;

        public IntegerToRomanTests()
        {
            _solver = new IntegerToRomanTask();
        }

        [Theory]
        [InlineData(3749, "MMMDCCXLIX")]
        [InlineData(58, "LVIII")]
        [InlineData(1994, "MCMXCIV")]
        public void Solution1_ReturnsCorrectData(int num, string expected)
        {
            var actual = _solver.Solution(num);
            Assert.Equal(expected, actual);
        }
    }
}
