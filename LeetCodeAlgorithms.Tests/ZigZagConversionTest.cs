using LeetCodeAlgorithms.BL.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithms.Tests
{
    public class ZigZagConversionTest
    {
        private readonly ZigZagConversionTask _solver;

        public ZigZagConversionTest()
        {
            _solver = new ZigZagConversionTask();
        }

        [Theory]
        [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
        [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
        [InlineData("A", 1, "A")]
        public void Solution_ReturnsCorrectData(string a, int row, string expected)
        {
            var actual = _solver.Solution(a, row);
            Assert.Equal(expected, actual);
        }
    }
}
