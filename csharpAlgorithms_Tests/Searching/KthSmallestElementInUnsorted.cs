using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharpAlgorithms
{

    [TestClass]
    public class KthSmallestElementInUnsorted_Tests
    {
        // Kth Smallest using a MinHeap
        [DataTestMethod]
        [DataRow(new int[] { 7, 10, 4, 3, 20, 15 }, 3, 7)]
        [DataRow(new int[] { 7, 10, 4, 3, 20, 15 }, 4, 10)]
        public void KthSmallestElementInUnsorted_Test(int[] arr, int k, int expectedResult)
        {
            var kthSmallest = new KthSmallestElementInUnsorted();

            var res = kthSmallest.FindKthSmallest(arr, k);

            Assert.AreEqual(res, expectedResult);
        }

        // Quickselect
        [TestMethod]
        public void KthSmallestElementInUnsorted_Test()
        {
            Quickselect ob = new Quickselect();
            int[] arr = { 12, 3, 5, 7, 4, 19, 26 };
            int n = arr.Length, k = 3;
            Assert.AreEqual(5, ob.FindKthSmallest(arr, k));
        }
    }
}
