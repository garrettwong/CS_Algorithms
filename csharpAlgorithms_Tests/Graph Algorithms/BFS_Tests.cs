using System;
using System.Collections.Generic;
using System.Diagnostics;
using csharpAlgorithms;
using csharpAlgorithms.GraphEntities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharpAlgorithms_Tests
{
    [TestClass]
    public class BFSTests
    {
        [TestMethod]
        public void BFS_Test()
        {
            var graph = GraphSeeder.GetTestStructure();

            BFS bfs = new BFS();
            bfs.Search(graph);
        }
    }

    public class GraphSeeder
    {
        public static Graph<string> GetTestStructure()
        {
            var graph = new Graph<string>();

            graph.AddNode("Privacy.htm");
            graph.AddNode("People.aspx");
            graph.AddNode("About.htm");
            graph.AddNode("Index.htm");
            graph.AddNode("Products.aspx");
            graph.AddNode("Contact.aspx");

            graph.AddDirectedEdge((GraphNode<string>)graph.Nodes.FindByValue("People.aspx"), (GraphNode<string>)graph.Nodes.FindByValue("Privacy.htm"), 0);

            graph.AddDirectedEdge((GraphNode<string>)graph.Nodes.FindByValue("Privacy.htm"), (GraphNode<string>)graph.Nodes.FindByValue("Index.htm"), 0);
            graph.AddDirectedEdge((GraphNode<string>)graph.Nodes.FindByValue("Privacy.htm"), (GraphNode<string>)graph.Nodes.FindByValue("About.htm"), 0);

            graph.AddDirectedEdge((GraphNode<string>)graph.Nodes.FindByValue("About.htm"), (GraphNode<string>)graph.Nodes.FindByValue("Privacy.htm"), 0);
            graph.AddDirectedEdge((GraphNode<string>)graph.Nodes.FindByValue("About.htm"), (GraphNode<string>)graph.Nodes.FindByValue("People.aspx"), 0);
            graph.AddDirectedEdge((GraphNode<string>)graph.Nodes.FindByValue("About.htm"), (GraphNode<string>)graph.Nodes.FindByValue("Contact.aspx"), 0);

            graph.AddDirectedEdge((GraphNode<string>)graph.Nodes.FindByValue("Index.htm"), (GraphNode<string>)graph.Nodes.FindByValue("About.htm"), 0);
            graph.AddDirectedEdge((GraphNode<string>)graph.Nodes.FindByValue("Index.htm"), (GraphNode<string>)graph.Nodes.FindByValue("Contact.aspx"), 0);
            graph.AddDirectedEdge((GraphNode<string>)graph.Nodes.FindByValue("Index.htm"), (GraphNode<string>)graph.Nodes.FindByValue("Products.aspx"), 0);
            //web.AddDirectedEdge((GraphNode<string>)web.Nodes.FindByValue("Products.aspx" }, web.Nodes.FindByValue("Index.htm" }, 0);
            //web.AddDirectedEdge((GraphNode<string>)web.Nodes.FindByValue("Products.aspx" }, web.Nodes.FindByValue("People.aspx" }, 0);

            return graph;
        }
    }
}
