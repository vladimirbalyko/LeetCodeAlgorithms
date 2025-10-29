using LeetCodeAlgorithms.BL.Helpers;
using LeetCodeAlgorithms.BL.Models;

namespace LeetCodeAlgorithms.BL.Tasks
{
    // 100. Same Tree (Easy)
    public class SameTreeTask : IExecutableTask
    {
        public bool Solution(TreeNode? p, TreeNode? q)
        {
            if (p == null && q == null) return true;
            if (p == null || q == null) return false;
            if (p.val != q.val) return false;
            return Solution(p.left, q.left) && Solution(p.right, q.right);
        }

        public void Execute()
        {
            Tuple<int?[], int?[], bool>[] testCases =
            [
                Tuple.Create(new int?[] { 1, 2, 3 }, new int?[] { 1, 2, 3 }, true),
                Tuple.Create(new int?[] { 1, 2 }, new int?[] { 1, null, 2 }, false),
                Tuple.Create(new int?[] { 1, 2, 1 }, new int?[] { 1, 1, 2 }, false)
            ];

            foreach (var testCase in testCases)
            {
                TreeNode? p = TreeNodeHelper.BuildTree<int?>(testCase.Item1);
                TreeNode? q = TreeNodeHelper.BuildTree(testCase.Item2);
                bool result = Solution(p, q);
                Console.WriteLine($"Input: p = {PrintDataHelper.PrintArray(testCase.Item1)}, q = {PrintDataHelper.PrintArray(testCase.Item2)}");
                Console.WriteLine($"Expected Output: {testCase.Item3}");
                Console.WriteLine($"Actual Output: {result}");
                Console.WriteLine();
            }
        }
    }
}
