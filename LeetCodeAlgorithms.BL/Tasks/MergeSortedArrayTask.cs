using LeetCodeAlgorithms.BL.Helpers;

namespace LeetCodeAlgorithms.BL.Tasks
{
    // 88. Merge Sorted Array (Easy)
    public class MergeSortedArrayTask : IExecutableTask
    {
        public void Solution(int[] nums1, int m, int[] nums2, int n)
        {
            var i = m - 1;
            var j = n - 1;
            var k = m + n - 1;

            while (i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[k--] = nums1[i--];
                }
                else
                {
                    nums1[k--] = nums2[j--];
                }
            }

            while (j >= 0)
            {
                nums1[k--] = nums2[j--];
            }
        }

        public void Execute()
        {
            Console.WriteLine("Running '67. Add Binary' solutions...");

            TestCase[] testCases =
            [
                new TestCase([1,2,3,0,0,0], 3, [2,5,6], 3, [1,2,2,3,5,6]),
            ];

            foreach (var testCase in testCases)
            {
                int[] nums1Copy = (int[])testCase.Nums1.Clone();
                Solution(nums1Copy, testCase.M, testCase.Nums2, testCase.N);

                Console.WriteLine($"\nExpected value: {PrintDataHelper.PrintArray(testCase.Expected)}");
                Console.WriteLine($"\nActual value: {PrintDataHelper.PrintArray(nums1Copy)}");
                Console.WriteLine();
            }
        }

        private class TestCase
        {
            public TestCase(int[] nums1, int n, int[] nums2, int m, int[] expected)
            {
                Nums1 = nums1;
                N = n;
                Nums2 = nums2;
                M = m;
                Expected = expected;
            }

            public int[] Nums1 { get; set; }
            public int M { get; set; }
            public int[] Nums2 { get; set; }
            public int N { get; set; }
            public int[] Expected { get; set; }

        }
    }
}
