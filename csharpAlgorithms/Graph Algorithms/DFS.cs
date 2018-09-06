using System;
using System.Collections.Generic;
using System.Diagnostics;
using csharpAlgorithms.GraphEntities;

namespace csharpAlgorithms
{
    public class DFS
    {
        public void Search(string startValue, Graph<string> graph)
        {
            Search(startValue, graph, new HashSet<Node<string>>());
        }

        public void Search(string startValue, Graph<string> graph, HashSet<Node<string>> visited)
        {
            var startNode = (GraphNode<string>)graph.Nodes.FindByValue(startValue);
            visited.Add(startNode);
            Debug.Write(startValue + " ");

            foreach (var neighborNode in startNode.Neighbors)
            {
                if (!visited.Contains(neighborNode))
                {
                    Search(neighborNode.Value, graph, visited);
                }
            }

        }
    }
}
