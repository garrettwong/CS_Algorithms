using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;


namespace csharpAlgorithms
{
	public class BinaryTree_CompressPath
	{
		private Dictionary<string, TreeNode> _visitedNodes = new Dictionary<string, TreeNode>();

		public BinaryTree_CompressPath()
		{
			_visitedNodes = new Dictionary<string, TreeNode>();
		}

		/// <summary>
		/// The tree might look like
		/// 
		/// 					10
		/// 			5				15
		/// 	3					5
		/// 					3
		/// 
		/// 	Reurns a compressed tree that may look like:
		/// 
		/// 				10
		/// 			  /		\
		/// 			 /		15
		/// 				 /
		/// 			5
		/// 		  /
		/// 		 3
		/// </summary>
		/// <returns>The path.</returns>
		/// <param name="root">Root.</param>
		public TreeNode CompressPath(TreeNode root)
		{
			if (root == null)
			{
				return null;
			}

			// compute path
			var path = ComputePath(root);

			if (!_visitedNodes.ContainsKey(path))
			{
				// add current node to visited list
				_visitedNodes.Add(path, root);
			}
			else
			{
				// we can return if we have already visited this
				return _visitedNodes[path];
			}

			// if we have already visited this node, then we can

			// created a visited list to track the paths that we have visited
			root.Left = CompressPath(root.Left);
			root.Right = CompressPath(root.Right);

			// find duplicate paths and hash
			return root;
		}

		/// <summary>
		/// returns a comma separated path
		/// </summary>
		/// <returns>The path.</returns>
		/// <param name="root">Root.</param>
		public string ComputePath(TreeNode root)
		{
			var s = _computePath(root, new StringBuilder());

			return s;
		}
		private string _computePath(TreeNode root, StringBuilder pathBuilder)
		{
			if (root == null) return "";
			pathBuilder.Append(root.Value + ",");
			_computePath(root.Left, pathBuilder);
			_computePath(root.Right, pathBuilder);
			return pathBuilder.ToString();
		}
	}
}
