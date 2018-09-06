
using System;
using System.Collections.Generic;
using System.Diagnostics;
using csharpAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharpAlgorithms_Tests
{
    /// <summary>
    /// http://www.geeksforgeeks.org/greedy-algorithms-set-3-huffman-coding/
    /// </summary>
    [TestClass]
    public class HuffmanCodingTests
    {
        [TestMethod]
        public void Test_HuffmanCoding()
        {
            char[] arr = { 'a', 'b', 'c', 'd', 'e', 'f' };
            int[] freq = { 5, 9, 12, 13, 16, 45 };
            int size = arr.Length;
            MinHeap hc = new MinHeap();
            hc.HuffmanCodes(arr, freq, size);
        }
    }
}