using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharpAlgorithms.Sorts
{
	/// <summary>
	/// Test multiple cases of 0, 1, 2 sort
	/// </summary>
	[TestClass]
	public class Sort012_Tests
	{
		[TestMethod]
		public void Sort012_Test()
		{
			var testCases = new int[][]
			{
				new int[] { 0, 2, 1, 2, 1, 2, 0 }, // 0s, 1s and 2s
				new int[] { 0, 0, 0 }, 	// all 0s
				new int[] {}, 			// no elements
				new int[] { 2, 2, 2 }, 	// only 2s
				new int[] { 1, 1, 1 }, 	// only 1s
				new int[] { 0, 0 },    	// only 0s
				new int[] { 2, 0, 0, 0, 0 } // start with 2 and only 0s
			};

			Sort012 sorter = new Sort012();
			foreach (var arr in testCases)
			{
				sorter.Sort(arr);

				if (!_allIncreasing(arr))
				{
					throw new Exception("Array not sorted");
				}
			}
		}

		private bool _allIncreasing(int[] arr)
		{
			if (arr == null || arr.Length == 0) return true;

			int index = 1;
			int prev = arr[0];
			while (index < arr.Length - 1)
			{
				if (arr[index] < prev)
				{
					return false;
				}
				prev = arr[index];
				index++;
			}
			return true;
		}
	}
}
