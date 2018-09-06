using System;
using System.Collections.Generic;
using csharpAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharpAlgorithms_Tests
{
	[TestClass]
	public class MinHeap_Tests
	{
		[TestMethod]
		public void MinHeap_Test()
		{
			var minHeap = new MinHeap<int>();

			minHeap.Insert(5);
			minHeap.Insert(3);
			minHeap.Insert(1);
			minHeap.Insert(4);
			minHeap.Insert(2);

			var result = minHeap.ExtractMin();

			Assert.AreEqual(result, 1);

			var secondResult = minHeap.ExtractMin();

			Assert.AreEqual(secondResult, 2);
		}
	}
}
