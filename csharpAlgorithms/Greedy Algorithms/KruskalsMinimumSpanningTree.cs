﻿
using System;
using System.Diagnostics;
using System.Linq;

namespace csharpAlgorithms
{
    public class Edge : IComparable
    {
        public int Src { get; set; }
        public int Dest { get; set; }
        public int Weight { get; set; }

        public int CompareTo(object obj)
        {
            return Weight - ((Edge)obj).Weight;
        }
    }
    public class Subset
    {
        public int Parent { get; set; }
        public int Rank { get; set; }
    }
    public class Graph
    {
        public int V { get; set; }
        public int E { get; set; }
        public Edge[] Edges { get; set; }

        public Graph(int v, int e)
        {
            V = v;
            E = e;
            Edges = new Edge[e];
            for (int i = 0; i < e; i++)
            {
                Edges[i] = new Edge();
            }
        }

        /// <summary>
        /// Find set of element i
        /// </summary>
        /// <param name="subsets"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public int Find(Subset[] subsets, int i)
        {
            if (subsets[i].Parent != i)
                subsets[i].Parent = Find(subsets, subsets[i].Parent);

            return subsets[i].Parent;
        }

        public void Union(Subset[] subsets, int x, int y)
        {
            int xRoot = Find(subsets, x);
            int yRoot = Find(subsets, y);

            // attach smaller rank tree under root of high rank tree
            // (Union by rank)
            if (subsets[xRoot].Rank < subsets[yRoot].Rank)
            {
                subsets[xRoot].Parent = yRoot;
            }
            else if(subsets[xRoot].Rank > subsets[yRoot].Rank)
            {
                subsets[yRoot].Parent = xRoot;
            }
            else
            {
                // if ranks are the same, make one as root and increment by one
                subsets[yRoot].Parent = xRoot;
                subsets[xRoot].Rank++;
            }
        }

        public Edge[] KruskalMST()
        {
            var result = new Edge[V];  // This will store the resulting MST
            int e = 0;  // An index variable, used for result[]
            int i = 0;  // An index variable, used for sorted edges
            for (i = 0; i < V; ++i)
                result[i] = new Edge();

            // Step 1:  Sort all the edges in non-decreasing order of their
            // weight.  If we are not allowed to change the given graph, we
            // can create a copy of array of edges
            Array.Sort(Edges);

            // Allocate memory for creating V ssubsets
            var subsets = new Subset[V];
            for (i = 0; i < V; ++i)
                subsets[i] = new Subset();

            // Create V subsets with single elements
            for (int v = 0; v < V; ++v)
            {
                subsets[v].Parent = v;
                subsets[v].Rank = 0;
            }

            i = 0;  // Index used to pick next edge

            // Number of edges to be taken is equal to V-1
            while (e < V - 1)
            {
                // Step 2: Pick the smallest edge. And increment the index
                // for next iteration
                Edge next_edge = new Edge();
                next_edge = Edges[i++];

                int x = Find(subsets, next_edge.Src);
                int y = Find(subsets, next_edge.Dest);

                // If including this edge does't cause cycle, include it
                // in result and increment the index of result for next edge
                if (x != y)
                {
                    result[e++] = next_edge;
                    Union(subsets, x, y);
                }
                // Else discard the next_edge
            }

            // print the contents of result[] to display the built MST
            Debug.WriteLine("Following are the edges in the constructed MST");
            for (i = 0; i < e; i++)
            {
                Debug.WriteLine(result[i].Src + " -- " + result[i].Dest + " == " + result[i].Weight);
            }

            var res = new Edge[e];
            Array.Copy(result, res, e);
            return res;
        }
    }
}
