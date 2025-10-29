using LeetCodeAlgorithms.BL.Models;

namespace LeetCodeAlgorithms.BL.Helpers
{
    public static class TreeNodeHelper
    {
        public static TreeNode? BuildTree<T>(T?[] arr)
        {
            if (arr == null || arr.Length == 0 || arr[0] == null)
                return null;

            TreeNode root = new TreeNode(Convert.ToInt32(arr[0]));
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            int i = 1;
            while (i < arr.Length)
            {
                TreeNode current = queue.Dequeue();

                if (arr[i] != null)
                {
                    current.left = new TreeNode(Convert.ToInt32(arr[i]));
                    queue.Enqueue(current.left);
                }
                i++;

                if (i < arr.Length && arr[i] != null)
                {
                    current.right = new TreeNode(Convert.ToInt32(arr[i]));
                    queue.Enqueue(current.right);
                }
                i++;
            }

            return root;
        }

        public static int?[] TreeToArray(TreeNode tree)
        {
            if (tree == null) return Array.Empty<int?>();

            var result = new List<int?>();
            var queue = new Queue<TreeNode>();
            queue.Enqueue(tree);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                result.Add(current.val);

                if (current.left != null) queue.Enqueue(current.left);
                if (current.right != null) queue.Enqueue(current.right);
            }

            return result.ToArray();
        }
    }
}
