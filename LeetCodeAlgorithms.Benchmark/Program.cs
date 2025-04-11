// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using LeetCodeAlgorithms.Benchmark;

Console.WriteLine("Run Benchmark ...");
BenchmarkRunner.Run<LongestSubstringTaskBenchmark>();