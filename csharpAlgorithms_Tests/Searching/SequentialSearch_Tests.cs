using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharpAlgorithms
{
	[TestClass]
	public class SequentialSearch_Tests
    {
		[TestMethod]
		public void SequentialSearch_FindIndex_Test()
		{
			var arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			// (val, expectedIndex)
			var testCases = new Tuple<int, int>[]
			{
				new Tuple<int, int>(1, 1),
				new Tuple<int, int>(0, 0),
				new Tuple<int, int>(10, 10),
				new Tuple<int, int>(6, 6)
			};

			var searcher = new SequentialSearch();

			foreach (var testCase in testCases)
			{
				var result = searcher.FindIndex(arr, testCase.Item1);

				Assert.AreEqual(result, testCase.Item2);
			}
		}
	}
}
