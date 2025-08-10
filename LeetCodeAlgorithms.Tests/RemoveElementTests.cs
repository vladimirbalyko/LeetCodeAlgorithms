using LeetCodeAlgorithms.BL.Tasks;

namespace LeetCodeAlgorithms.Tests
{
    public class RemoveElementTests
    {
        private readonly RemoveElementTask _solver;

        public RemoveElementTests()
        {
            _solver = new RemoveElementTask();
        }

        [Theory]
        [InlineData(new int[] { 3, 2, 2, 3 }, 3, new int[] { 2, 2 }, 2)]
        [InlineData(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, new int[] { 0, 1, 3, 0, 4 }, 5)]
        public void Solution_ReturnsCorrectData(int[] input, int removeValue, int[] expected, int expectedCount)
        {
            var inputCopy = (int[])input.Clone();
            var k = _solver.Solution(inputCopy, removeValue);

            Assert.Equal(expectedCount, k);

            for (int i = 0; i < k; i++)
            {
                Assert.Equal(inputCopy[i], expected[i]);
            }
        }
    }
}
