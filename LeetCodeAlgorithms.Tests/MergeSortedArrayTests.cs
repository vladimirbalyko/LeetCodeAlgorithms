using LeetCodeAlgorithms.BL.Tasks;

namespace LeetCodeAlgorithms.Tests
{
    public class MergeSortedArrayTests
    {
        private readonly MergeSortedArrayTask _solver;

        public MergeSortedArrayTests()
        {
            _solver = new MergeSortedArrayTask();
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3, new int[] { 1, 2, 2, 3, 5, 6 })]
        [InlineData(new int[] { 1 }, 1, new int[] { }, 0, new int[] { 1 })]
        [InlineData(new int[] { 0 }, 0, new int[] { 1 }, 1, new int[] { 1 })]
        public void Solution_ReturnsCorrectData(int[] nums1, int m, int[] nums2, int n, int[] expected)
        {
            int[] actualResult = (int[])nums1.Clone();
            _solver.Solution(actualResult, m, nums2, n);

            Assert.Equal(expected, actualResult);

            Assert.Equal(expected.Length, actualResult.Length);

            for (int i = 0; i < n + m; i++)
            {
                Assert.Equal(expected[i], actualResult[i]);
            }
        }
    }
}
