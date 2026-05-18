using LeetCodeAlgorithms.BL.Tasks;

namespace LeetCodeAlgorithms.Tests
{
    public class FourSumTests
    {
        private readonly FourSumTask _solution;

        public FourSumTests()
        {
            _solution = new FourSumTask();
        }

        [Theory]
        [MemberData(nameof(GetTestData))]
        public void Solution1_ReturnsCorrectData(int[] nums, int target, IList<IList<int>> expected)
        {
            var solution = _solution.FourSum(nums, target);

            var normalizedSolution = Normalize(solution);
            var normalizedExpected = Normalize(expected);

            Assert.Equal(normalizedExpected, normalizedSolution);
        }

        private static List<string> Normalize(IList<IList<int>> data)
        {
            return data
                .Select(triplet => string.Join(",", triplet.OrderBy(x => x)))
                .OrderBy(x => x)
                .ToList();
        }

        public static IEnumerable<object[]> GetTestData()
        {
            yield return new object[]
            {
                new int[] { 1, 0, -1, 0, -2, 2 },
                0,
                (IList<IList<int>>) new List<IList<int>>
                {
                    new List<int> { -2, -1, 1, 2 },
                    new List<int> { -2, 0, 0, 2 },
                    new List<int> { -1, 0, 0, 1 }
                }
            };
            yield return new object[]
            {
                new int[] { 2, 2, 2, 2, 2 },
                8,
                (IList<IList<int>>) new List<IList<int>>
                {
                    new List<int> { 2, 2, 2, 2 }
                }
            };
        }
    }
}
