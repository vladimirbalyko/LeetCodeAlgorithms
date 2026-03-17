using LeetCodeAlgorithms.BL.Tasks;

namespace LeetCodeAlgorithms.Tests
{
    public class ContainerWithMostWaterTests
    {
        private readonly ContainerWithMostWaterTask _solver;

        public static TheoryData<int[], int> TestCases => new()
        {
            { new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49 },
            { new int[] { 1, 1 }, 1 },
            { new int[] { 4, 3, 2, 1, 4 }, 16 }
        };

        public ContainerWithMostWaterTests()
        {
            _solver = new ContainerWithMostWaterTask();
        }

        [Theory]
        [MemberData(nameof(TestCases))]
        public void Solution_ReturnsCorrectData(int[] height, int expected)
        {
            var actual = _solver.Solution(height);
            Assert.Equal(actual, expected);
        }
    }
}
