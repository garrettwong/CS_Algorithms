using System;
using System.Collections.Generic;
using System.Diagnostics;
using csharpAlgorithms.GraphEntities;

namespace csharpAlgorithms
{
	public class BFS
	{
		public void Search(Graph<string> graph)
		{
			// Mark all vertices as not visited (by default, set to false)
			var visited = new HashSet<Node<string>>();

			// Create queue for BFS
			var queue = new List<Node<string>>();

			// Mark current node as visted and enqueue
			var startNode = graph.Nodes.FindByValue("People.aspx");
			visited.Add(startNode);
			queue.Add(startNode);

			while (queue.Count != 0)
			{
				// Dequeue a vertex from queue and print it
				var node = (GraphNode<string>)queue[0];
				queue.RemoveAt(0);

				Debug.Write(node.Value + " ");

				// Get all adjacent vertices of the dequeued vertex s
				// If a adjacent has not been visited, then mark it
				// visited and enqueue it
				foreach (var neighborNode in node.Neighbors)
				{
					if (!visited.Contains(neighborNode))
					{
						visited.Add(neighborNode);
						queue.Add(neighborNode);
					}
				}
			}
		}
	}
}
