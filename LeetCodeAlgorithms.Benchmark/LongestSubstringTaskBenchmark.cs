using BenchmarkDotNet.Attributes;
using LeetCodeAlgorithms.BL.Tasks.LongestSubstring;

namespace LeetCodeAlgorithms.Benchmark
{
    [MemoryDiagnoser]
    public class LongestSubstringTaskBenchmark
    {
        private string shortInput = "abcabcbb";
        private string longInput = new string('a', 10000) + "b";

        private readonly LongestSubstringTask solver = new();

        [Benchmark]
        public int ShortInputTest() => solver.Solution(shortInput);

        [Benchmark]
        public int LongInputTest() => solver.Solution(longInput);
    }
}
