using LeetCodeAlgorithms.BL.Tasks;

namespace LeetCodeAlgorithms.Tests
{
    public class ThreeSumClosestTests
    {
        private readonly ThreeSumClosestTask _solver;

        public ThreeSumClosestTests()
        {
            _solver = new ThreeSumClosestTask();
        }

        [Theory]
        [MemberData(nameof(GetTestData))]
        public void Solution1_ReturnsCorrectData(int[] nums, int target, int expected)
        {
            var solution = _solver.Solution(nums, target);
            Assert.Equal(expected, solution);
        }

        public static IEnumerable<object[]> GetTestData()
        {
            yield return new object[]
            {
                new int[] { -1, 2, 1, -4 },
                1,
                2
            };
            yield return new object[]
            {
                new int[] { 0, 0, 0 },
                1,
                0
            };
        }
    }
}
