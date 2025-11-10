
using LeetCodeAlgorithms.BL.Helpers;
using LeetCodeAlgorithms.BL.Tasks;

namespace LeetCodeAlgorithms.Tests
{
    public class AddTwoNumbersTests
    {
        private readonly AddTwoNumbersTask _solver;

        public AddTwoNumbersTests()
        {
            _solver = new AddTwoNumbersTask();
        }

        [Theory]
        [InlineData(new int[] { 2, 4, 3 }, new int[] { 5, 6, 4 }, new int[] { 7, 0, 8 })]
        [InlineData(new int[] { 0 }, new int[] { 0 }, new int[] { 0 })]
        [InlineData(new int[] { 9, 9, 9, 9, 9, 9, 9 }, new int[] { 9, 9, 9, 9 }, new int[] { 8, 9, 9, 9, 0, 0, 0, 1 })]
        public void Solution_ReturnsCorrectData(int[] a, int[] b, int[] expected)
        {
            var l1 = ListNodeHelper.BuildList(a);
            var l2 = ListNodeHelper.BuildList(b);

            var result = _solver.Solution(l1, l2);
            var actual = ListNodeHelper.ListToArray(result);

            Assert.Equal(expected, actual);
        }
    }
}
