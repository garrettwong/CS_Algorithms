using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using csharpAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharpAlgorithms_Tests
{
	[TestClass]
	public class BinaryTree_CompressPath_Tests
	{
		[TestMethod]
		public void DictionaryGeneratorTest()
		{
			var root = GenerateTree();

			var btcp = new BinaryTree_CompressPath();
			var result = btcp.CompressPath(root);

			Assert.IsNotNull(result);

		}

		public void Print(TreeNode root, int level)
		{
			if (root != null)
			{
				// padding
				var str = "";
				for (var i = -20; i < level; i++)
				{
					str += ' ';
				}

				Debug.WriteLine(str + root.Value);
				Print(root.Left, level - 3);
				Print(root.Right, level + 3);
			}
		}


		public TreeNode GenerateTree()
		{
			var root = new TreeNode();

			// root has a left and a right
			var n3 = new TreeNode()
			{
				Value = 3
			};
			var n2 = new TreeNode()
			{
				Value = 5,
				Left = n3
			};

			var n8 = new TreeNode()
			{
				Value = 3
			};
			var n6 = new TreeNode()
			{
				Value = 5,
				Left = n8
			};
			var n5 = new TreeNode()
			{
				Value = 15,
				Left = n6
			};
			var n4 = new TreeNode()
			{
				Value = 10,
				Left = n2,
				Right = n5
			};

			root = n4;

			return root;
		}
	}
}
