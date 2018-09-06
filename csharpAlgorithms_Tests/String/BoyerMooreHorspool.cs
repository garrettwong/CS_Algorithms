using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharpAlgorithms
{
	[TestClass]
	public class BoyerMooreHorspool_Tests
	{
		[TestMethod]
		public void BoyerMooreHorspool_Test()
		{
			var bmh = new BoyerMooreHorspool();
			var firstIndex = bmh.Search("hello", "where am i goin to say hello to this young hello mahn");
			Assert.AreEqual(firstIndex, 23);
			firstIndex = bmh.Search("hello", "hello to this young hello mahn");
			Assert.AreEqual(firstIndex, 0);
			firstIndex = bmh.Search("hello", "helio to this young hello");
			Assert.AreEqual(firstIndex, 20);
			firstIndex = bmh.Search("hello", "elloho");
			Assert.AreEqual(firstIndex, -1);
		}
	}
}
