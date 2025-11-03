using LeetCodeAlgorithms.BL.Helpers;
using LeetCodeAlgorithms.BL.Models;

namespace LeetCodeAlgorithms.BL.Tasks
{
    // 94. Binary Tree Inorder Traversal (Easy)
    public class BinaryTreeInorderTraversalTask : IExecutableTask
    {
        // Recursive solution
        public IList<int> Solution(TreeNode? root)
        {
            IList<int> result = new List<int>();
            void InorderTraversal(TreeNode? node)
            {
                if (node == null)
                    return;
                InorderTraversal(node.left);
                result.Add(node.val);
                InorderTraversal(node.right);
            }
            InorderTraversal(root);
            return result;
        }

        // Iterative solution (via stack)
        public IList<int> Solution2(TreeNode? root)
        {
            var result = new List<int>();
            var stack = new Stack<TreeNode>();
            var current = root;

            while (current != null || stack.Count > 0)
            {
                // We go to the leftmost node
                while (current != null)
                {
                    stack.Push(current);
                    current = current.left;
                }

                // We process the node
                current = stack.Pop();
                result.Add(current.val);

                // We go to the right subtree
                current = current.right;
            }

            return result;
        }

        public void Execute()
        {
            Console.WriteLine("Running '94. Binary Tree Inorder Traversal' solutions...");

            Tuple<int?[], int[]>[] testCases =
            [
                Tuple.Create(new int?[] { 1, null, 2, 3 }, new int[] { 1, 3, 2 }),
                Tuple.Create(new int?[] { 1, 2, 3, 4, 5, null, 8, null, null, 6, 7, 9 }, new int[] { 4, 2, 6, 5, 7, 1, 3, 9, 8 }),
                Tuple.Create(new int?[] { }, new int[] { }),
                Tuple.Create(new int?[] { 1 }, new int[] { 1 })
            ];

            foreach (var testCase in testCases)
            {
                TreeNode? root = TreeNodeHelper.BuildTree(testCase.Item1);
                var actual = Solution(root).ToArray();

                Console.WriteLine($"\nExpected value: {PrintDataHelper.PrintArray(testCase.Item2)}");
                Console.WriteLine($"\nActual value: {PrintDataHelper.PrintArray(actual)}");
                if (testCase.Item2.Length != actual.Length || !testCase.Item2.SequenceEqual(actual))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Test case failed!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Test case passed!");
                }
                Console.ResetColor();
                Console.WriteLine();
            }
        }
    }
}
