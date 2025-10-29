using LeetCodeAlgorithms.BL.Helpers;
using LeetCodeAlgorithms.BL.Tasks;

namespace LeetCodeAlgorithms.Tests
{
    public class SameTreeTests
    {
        private readonly SameTreeTask _solver;

        public SameTreeTests()
        {
            _solver = new SameTreeTask();
        }

        public static IEnumerable<object[]> GetTestData()
        {
            yield return new object[] { new int?[] { 1, 2, 3 }, new int?[] { 1, 2, 3 }, true };
            yield return new object[] { new int?[] { 1, 2 }, new int?[] { 1, null, 2 }, false };
            yield return new object[] { new int?[] { 1, 2, 1 }, new int?[] { 1, 1, 2 }, false };
        }

        [Theory]
        [MemberData(nameof(GetTestData))]
        public void Solution_ReturnsCorrectData(int?[] p, int?[] q, bool expected)
        {
            var treeP = TreeNodeHelper.BuildTree<int?>(p);
            var treeQ = TreeNodeHelper.BuildTree<int?>(q);
            var actual = _solver.Solution(treeP, treeQ);
            Assert.Equal(expected, actual);
        }
    }
}
