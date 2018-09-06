using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharpAlgorithms
{
    [TestClass]
	public class BinarySearch_Tests
	{
		[TestMethod]
		public void BinarySearch_FindIndex_Test()
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

			var binarySearcher = new BinarySearch();

			foreach (var testCase in testCases)
			{
				var result = binarySearcher.FindIndex(arr, testCase.Item1);

				Assert.AreEqual(result, testCase.Item2);
			}
        }

        [TestMethod]
        public void BinarySearchGeneric_FindIndex_Test()
        {
            var arr = new double[] { 0, 1.3, 2, 3, 4, 5, 6.4, 7, 8, 9, 10.0 };

            // (val, expectedIndex)
            var testCases = new Tuple<double, int>[]
            {
                new Tuple<double, int>(1.3, 1),
                new Tuple<double, int>(0.0, 0),
                new Tuple<double, int>(10.0, 10),
                new Tuple<double, int>(6.4, 6)
            };

            var binarySearcher = new BinarySearch<double>();

            foreach (var testCase in testCases)
            {
                var result = binarySearcher.FindIndex(arr, testCase.Item1);

				Assert.AreEqual(result, testCase.Item2);
            }
        }


        [TestMethod]
		public void BinarySearch_FindRangeIndex_Test()
		{
			var arr = new int[] { 0, 2, 5, 7, 8, 10 };

			int LENGTH = 3;
			var rangeArray = new Range[LENGTH];
			for (int i = 0; i < rangeArray.Length; i++)
			{
				rangeArray[i] = new Range()
				{
					Start = arr[2 * i],
					End = arr[2 * i + 1]
				};
			}

			// (val, expectedIndex)
			var testCases = new Tuple<int, int>[]
			{
				new Tuple<int, int>(3, -1),
				new Tuple<int, int>(0, 0),
				new Tuple<int, int>(7, 1),
				new Tuple<int, int>(10, 2)
			};

			var binarySearcher = new BinarySearch();

			foreach (var testCase in testCases)
			{
				var result = binarySearcher.FindRangeIndex(rangeArray, testCase.Item1);

				Assert.AreEqual(result, testCase.Item2);
			}
		}
	}
}
