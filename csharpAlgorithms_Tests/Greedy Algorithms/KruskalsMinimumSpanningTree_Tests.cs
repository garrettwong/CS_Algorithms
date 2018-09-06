
using System;
using System.Diagnostics;
using System.Linq;
using csharpAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharpAlgorithms_Tests
{
    /// <summary>
    /// http://www.geeksforgeeks.org/greedy-algorithms-set-2-kruskals-minimum-spanning-tree-mst/
    /// </summary>
    [TestClass]
    public class KruskalsMinimumSpanningTree
    {
        [TestMethod]
        public void Test_KruskalsMinimumSpanningTree()
        {
            /* Let us create following weighted graph
                 10
            0--------1
            |  \     |
           6|   5\   |15
            |      \ |
            2--------3
                4       */
            int V = 4;  // Number of vertices in graph
            int E = 5;  // Number of edges in graph
            var graph = new Graph(V, E);

            // add edge 0-1
            graph.Edges[0].Src = 0;
            graph.Edges[0].Dest = 1;
            graph.Edges[0].Weight = 10;

            // add edge 0-2
            graph.Edges[1].Src = 0;
            graph.Edges[1].Dest = 2;
            graph.Edges[1].Weight = 6;

            // add edge 0-3
            graph.Edges[2].Src = 0;
            graph.Edges[2].Dest = 3;
            graph.Edges[2].Weight = 5;

            // add edge 1-3
            graph.Edges[3].Src = 1;
            graph.Edges[3].Dest = 3;
            graph.Edges[3].Weight = 15;

            // add edge 2-3
            graph.Edges[4].Src = 2;
            graph.Edges[4].Dest = 3;
            graph.Edges[4].Weight = 4;

            var edges = graph.KruskalMST();

            Assert.IsNotNull(edges);
            Assert.AreEqual(edges.Sum(a => a.Weight), 19); // weight: 10 + 5 + 4
        }
    }
}
