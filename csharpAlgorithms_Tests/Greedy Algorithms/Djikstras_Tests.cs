
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharpAlgorithms.Greedy_Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharpAlgorithms_Tests
{
    [TestClass]
    public class DjikstrasTests
    {
        [TestMethod]
        public void Test_Djikstras()
        {
            /* Let us create the example graph discussed above */
            int[][] graph = new int[][]{
                                    new int[] {0, 4, 0, 0, 0, 0, 0, 8, 0},
                                    new int[] {4, 0, 8, 0, 0, 0, 0, 11, 0},
                                    new int[] {0, 8, 0, 7, 0, 4, 0, 0, 2},
                                    new int[] {0, 0, 7, 0, 9, 14, 0, 0, 0},
                                    new int[] {0, 0, 0, 9, 0, 10, 0, 0, 0},
                                    new int[] {0, 0, 4, 14, 10, 0, 2, 0, 0},
                                    new int[] {0, 0, 0, 0, 0, 2, 0, 1, 6},
                                    new int[] {8, 11, 0, 0, 0, 0, 1, 0, 7},
                                    new int[] {0, 0, 2, 0, 0, 0, 6, 7, 0}
                                 };
            Djikstras d = new Djikstras();
            d.Compute(graph, 0);
        }
    }
}
