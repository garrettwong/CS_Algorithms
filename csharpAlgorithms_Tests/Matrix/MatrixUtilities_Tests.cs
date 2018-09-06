using System;
using System.Diagnostics;
using System.Text;
using csharpAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharpAlgorithms_Tests
{
	[TestClass]
	public class MatrixUtilities_Tests
	{
		[TestMethod]
		public void MatrixUtilities_Test()
		{
			var arr = MatrixTestsGenerator.GetTestArray();

			var result = MatrixUtilities.ToString(arr);

			Assert.AreEqual(result, @"1, 2, 3, 4, 5, 
6, 7, 8, 9, 10, 
11, 12, 13, 14, 15, 
16, 17, 18, 19, 20, 
21, 22, 23, 24, 25, 
");

		}
	}
}
