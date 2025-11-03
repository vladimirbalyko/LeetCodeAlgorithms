using LeetCodeAlgorithms.BL.Helpers;
using LeetCodeAlgorithms.BL.Tasks;

namespace LeetCodeAlgorithms.Tests
{
    public class BinaryTreeInorderTraversalTests
    {
        private readonly BinaryTreeInorderTraversalTask _solver;

        public BinaryTreeInorderTraversalTests()
        {
            _solver = new BinaryTreeInorderTraversalTask();
        }

        [Theory]
        [MemberData(nameof(GetTestData))]
        public void Solution1_ReturnsCorrectData(int?[] data, int[] expected)
        {
            var root = TreeNodeHelper.BuildTree(data);
            var actual = _solver.Solution(root).ToArray();
            Assert.Equal(expected.Length, actual.Length);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(GetTestData))]
        public void Solution2_ReturnsCorrectData(int?[] data, int[] expected)
        {
            var root = TreeNodeHelper.BuildTree(data);
            var actual = _solver.Solution(root).ToArray();
            Assert.Equal(expected.Length, actual.Length);
            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> GetTestData()
        {
            yield return new object[] { new int?[] { 1, null, 2, 3 }, new int[] { 1, 3, 2 } };
            yield return new object[] { new int?[] { 1, 2, 3, 4, 5, null, 8, null, null, 6, 7, 9 }, new int[] { 4, 2, 6, 5, 7, 1, 3, 9, 8 } };
            yield return new object[] { new int?[] { }, new int[] { } };
            yield return new object[] { new int?[] { 1 }, new int[] { 1 } };
        }
    }
}
