using LeetCodeAlgorithms.BL.Tasks;

namespace LeetCodeAlgorithms.Tests
{
    public class SearchInsertPositionTests
    {
        private readonly SearchInsertPositionTask _solver;

        public SearchInsertPositionTests()
        {
            _solver = new SearchInsertPositionTask();
        }

        [Theory]
        [InlineData(new int[] { 1, 3, 5, 6 }, 5, 2)]
        [InlineData(new int[] { 1, 3, 5, 6 }, 2, 1)]
        [InlineData(new int[] { 1, 3, 5, 6 }, 7, 4)]
        public void Solution_ReturnsCorrectData(int[] nums, int target, int expected)
        {
            var result = _solver.Solution(nums, target);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 3, 5, 6 }, 5, 2)]
        [InlineData(new int[] { 1, 3, 5, 6 }, 2, 1)]
        [InlineData(new int[] { 1, 3, 5, 6 }, 7, 4)]
        public void Solution2_ReturnsCorrectData(int[] nums, int target, int expected)
        {
            var result = _solver.Solution2(nums, target);
            Assert.Equal(expected, result);
        }
    }
}
