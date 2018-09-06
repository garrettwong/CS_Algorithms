using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharpAlgorithms
{
	[TestClass]
	public class AddBinaryStrings_Tests
	{

		[TestMethod]
		public void AddBinaryStrings_Test()
		{
			// 1st param is string1, string2 then expected result
			var testCases = new Tuple<string, string, string>[]
			{
				new Tuple<string, string, string>("110", "111", "1101"),
				new Tuple<string, string, string>("110", "001", "111"),
				new Tuple<string, string, string>("000", "010", "010"),
				new Tuple<string, string, string>("100", "001", "101")
			};

			var tester = new AddBinaryStrings();

			foreach (var testCase in testCases)
			{
				var str1 = testCase.Item1;
				var str2 = testCase.Item2;
				var expected = testCase.Item3;

				var result = tester.Add(str1, str2);

				Assert.AreEqual(expected, result);
			}
		}
	}
}
