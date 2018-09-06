using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharpAlgorithms
{
    [TestClass]
    public class OptimizedQuickSort_Tests
    {
        [TestMethod]
        public void OptimizedQuickSort_Test()
        {
            var arr = new int[5] { 2, 4, 3, 5, 1 };
            OptimizedQuickSort oqs = new OptimizedQuickSort();
            oqs.QuickSort(arr);

            foreach (var r in arr)
            {
                Console.Write(r);
            }
        }
    }
}
