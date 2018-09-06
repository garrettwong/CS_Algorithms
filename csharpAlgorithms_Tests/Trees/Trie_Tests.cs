using System;
using System.Collections.Generic;
using System.Text;
using csharpAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharpAlgorithms_Tests
{
	[TestClass]
	public class TrieTests
	{
		private Trie _trie;

		[TestInitialize]
		public void SetUp()
		{
			_trie = new Trie(255);

			int v = 26 - 'a';

			if (v + 1 ==  2)
			{
				return;
			}
		}

		[TestMethod]
		public void Trie_Test()
		{
			_trie.Insert("hello");
			_trie.Insert("world");
			_trie.Insert("hey");
			_trie.Insert("wong");
			_trie.Insert("WHALE");
			_trie.Insert("worthy");
			_trie.Insert("worse");


			var res = _trie.Search("wo");

			Assert.AreNotEqual(res.Count, 3);
		}

	}
}
