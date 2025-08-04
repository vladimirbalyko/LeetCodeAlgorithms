using LeetCodeAlgorithms.BL.Tasks;
using LeetCodeAlgorithms.BL.Helpers;

namespace LeetCodeAlgorithms.Tests
{
    public class MergeTwoSortedListsTests
    {
        private readonly MergeTwoSortedListsTask _solver;
        public MergeTwoSortedListsTests()
        {
            _solver = new MergeTwoSortedListsTask();
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 4 }, new int[] { 1, 3, 4 }, new int[] { 1, 1, 2, 3, 4, 4 })]
        [InlineData(new int[] { }, new int[] { }, new int[] { })]
        [InlineData(new int[] { }, new int[] { 0 }, new int[] { 0 })]
        public void Solution_ReturnsCorrectData(int[] item1, int[] item2, int[] expected)
        {
            var list1 = ListNodeHelper.BuildList(item1);
            var list2 = ListNodeHelper.BuildList(item2);

            var result = _solver.Solution(list1, list2);
            Assert.Equal(expected, ListNodeHelper.ListToArray(result));
        }
    }
}
