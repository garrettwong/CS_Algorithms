using System;
using System.Collections.Generic;
using System.Diagnostics;
using csharpAlgorithms;
using csharpAlgorithms_Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharpAlgorithms_Tests
{
	[TestClass]
	public class DFSTests
	{
		[TestMethod]
		public void DFS_Test()
		{
			var graph = GraphSeeder.GetTestStructure();

			DFS bfs = new DFS();
			bfs.Search("People.aspx", graph);
		}
	}
}
