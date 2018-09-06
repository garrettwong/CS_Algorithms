using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharpAlgorithms.String
{
    [TestClass]
    public class LongestSubstringOfUniqueCharacters_Test
	{
		[TestMethod]
		public void Test()
		{
            var lsouc = new LongestSubstringOfUniqueCharacters();
            var longest = lsouc.Solve("apple");
			Assert.AreEqual(longest, "ple");
			
            var longest2 = lsouc.Solve("hogarrett");
            Assert.AreEqual(longest2, "hogar");
		}
	}
}
