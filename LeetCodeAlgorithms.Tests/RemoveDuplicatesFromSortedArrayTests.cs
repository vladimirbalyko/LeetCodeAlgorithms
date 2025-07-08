using LeetCodeAlgorithms.BL.Tasks;

namespace LeetCodeAlgorithms.Tests
{
    public class RemoveDuplicatesFromSortedArrayTests
    {
        [Theory]
        [InlineData(new int[] { 1, 1, 2 }, new int[] { 1, 2 }, 2)]
        [InlineData(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, new int[] { 0, 1, 2, 3, 4 }, 5)]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 }, 3)]
        [InlineData(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1 }, 1)]
        [InlineData(new int[] { }, new int[] { }, 0)]
        public void Solution_ReturnsCorrectData(int[] input, int[] expected, int expectedCount)
        {
            var solution = new RemoveDuplicatesFromSortedArrayTask();
            var inputCopy = (int[])input.Clone();

            int k = solution.Solution(inputCopy);

            Assert.Equal(expectedCount, k);

            for (int i = 0; i < k; i++)
            {
                Assert.Equal(expected[i], inputCopy[i]);
            }
        }
    }
}
