using System;
using System.Collections.Generic;
using System.Linq;

namespace csharpAlgorithms.Trees
{
    public class TreeNode
    {
        public int Value { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
    }

    public class BinaryTree
    {
        public TreeNode Root { get; set; }

        public BinaryTree(TreeNode root)
        {
            this.Root = root;
        }

        public int FindMaxPathSum(TreeNode root)
        {
            if (root == null) return 0;

            int leftSum = FindMaxPathSum(root.Left);
            int rightSum = FindMaxPathSum(root.Right);

            return Math.Max(root.Value + leftSum, root.Value + rightSum);
        }
    }
}