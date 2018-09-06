using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using System.Linq;
using csharpAlgorithms;

namespace csharpAlgorithms_Tests
{
    [TestClass]
	public class BinaryTreeTests
	{
        [TestMethod]
        public void FindMaxPathSum() {

			// root has a left and a right
            /*
                                n4
                              /     \
                            n2       n5
                           /   \        \
                         n1     n3       n6
                                        /   \
                                      n7     n8
                    
             */
			var n1 = new TreeNode()
			{
				Value = 20
			};

			var n3 = new TreeNode()
			{
				Value = 1
			};

			var n2 = new TreeNode()
			{
				Value = 2,
				Left = n1,
				Right = n3
			};

			var n7 = new TreeNode()
			{
				Value = 3
			};
			var n8 = new TreeNode()
			{
				Value = 4
			};
			var n6 = new TreeNode()
			{
				Value = -25,
				Left = n7,
				Right = n8
			};
			var n5 = new TreeNode()
			{
				Value = 10,
				Right = n6
			};
			var n4 = new TreeNode()
			{
				Value = 10,
				Left = n2,
				Right = n5
			};

            var binaryTree = new BinaryTree(n4);

            var sum = binaryTree.FindMaxPathSum(n4);
            
            Assert.AreEqual(sum, 32);
        }



		[TestMethod]
		public void DictionaryGeneratorTest()
		{
			Dictionary<string, object> dict = GetDictionary();
			
            foreach (object value in RandomValues(dict).Take(10))
			{
				Console.WriteLine(value);
			}
		}

		public Dictionary<string, object> GetDictionary()
		{
			return new Dictionary<string, object>()
			{
				{"entry", "entries"},
				{"image", "images"},
				{"view", "views"},
				{"file", "files"},
				{"result", "results"},
				{"word", "words"}
			};
		}

		public IEnumerable<TValue> RandomValues<TKey, TValue>(IDictionary<TKey, TValue> dict)
		{
			Random rand = new Random();
			List<TValue> values = Enumerable.ToList(dict.Values);
			int size = dict.Count;
			while (true)
			{
				yield return values[rand.Next(size)];
			}
		}
	}
}
