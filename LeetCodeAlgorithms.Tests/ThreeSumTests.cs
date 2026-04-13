using LeetCodeAlgorithms.BL.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithms.Tests
{
    public class ThreeSumTests
    {
        private readonly ThreeSumTask _solver;

        public ThreeSumTests()
        {
            _solver = new ThreeSumTask();
        }

        [Theory]
        [MemberData(nameof(GetTestData))]
        public void Solution1_ReturnsCorrectData(int[] nums, IList<IList<int>> expected)
        {
            var solution = _solver.Solution(nums);

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
                new int[] { -1, 0, 1, 2, -1, -4 },
                (IList<IList<int>>) new List<IList<int>>
                {
                    new List<int> { -1, -1, 2 },
                    new List<int> { -1, 0, 1 }
                }
            };
            yield return new object[]
            {
                new int[] { 0, 1, 1 },
                (IList<IList<int>>) new List<IList<int>>()
            };
            yield return new object[]
            {
                new int[] { 0, 0, 0 },
                (IList<IList<int>>) new List<IList<int>>
                {
                    new List<int> { 0, 0, 0 }
                }
            };
        }
    }
}
