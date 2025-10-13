using LeetCodeAlgorithms.BL.Helpers;
using LeetCodeAlgorithms.BL.Tasks;

namespace LeetCodeAlgorithms.Tests
{
    public class RemoveDuplicatesFromSortedListTests
    {
        private readonly RemoveDuplicatesFromSortedListTask _solver;

        public RemoveDuplicatesFromSortedListTests()
        {
            _solver = new RemoveDuplicatesFromSortedListTask();
        }

        [Theory]
        [InlineData(new[] { 1, 1, 2 }, new[] { 1, 2 })]
        [InlineData(new[] { 1, 1, 2, 3, 3 }, new[] { 1, 2, 3 })]
        public void Solution_ReturnsCorrectData(int[] head, int[] expected)
        {
            var listNode = ListNodeHelper.BuildList(head);
            var actual = _solver.Solution(listNode);

            var actualArray = ListNodeHelper.ListToArray(actual);

            Assert.Equal(expected.Length, actualArray.Length);
            Assert.Equal(expected, actualArray);
        }
    }
}
