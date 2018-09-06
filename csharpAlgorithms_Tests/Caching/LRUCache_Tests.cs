using System;
using System.Collections.Generic;
using csharpAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharpAlgorithms_Tests
{
	[TestClass]
	public class LRUCache_Tests
	{
		[TestMethod]
		public void LRUCache_Test()
		{
			var sut = new LRUCache<int, int>();

			for (int i = 1; i < 12; i++)
			{
				sut.Add(i, i + 1);
			}

			var val = sut.Get(1);
			var val2 = sut.Get(11);

			Assert.AreEqual(val, 0);
			Assert.AreEqual(val2, 12);
		}
	}
}
