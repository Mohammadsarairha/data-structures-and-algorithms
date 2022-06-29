using System;
using Xunit;
using Graph;
using System.Collections.Generic;

namespace GraphTest
{
    public class UnitTest1
    {
        //Node can be successfully added to the graph
        [Fact]
        public void Test1()
        {
            Graphs graph = new Graphs();
            graph.addNode(1);
            graph.addNode(2);
            graph.addNode(3);

            Assert.Equal(3, graph.getSize());
        }

        //An edge can be successfully added to the graph
        [Fact]
        public void Test2()
        {
            Graphs graph = new Graphs();
            Node one = graph.addNode(1);
            Node Two = graph.addNode(2);
            Node Three = graph.addNode(3);

            Assert.True(graph.addEdge(one,Two));
            Assert.True(graph.addEdge(one, Three));
        }

        // A collection of all nodes can be properly retrieved from the graph

        [Fact]
        public void Test3()
        {
            Graphs graph = new Graphs();
            Node one = graph.addNode(1);
            Node two = graph.addNode(2);
            Node three = graph.addNode(2);

            HashSet<Node> expected = new HashSet<Node>();
            expected.Add(one);
            expected.Add(two);
            expected.Add(three);

            Assert.Equal(graph.getNodes() , expected);

        }

        //An empty graph properly returns null
        [Fact]
        public void Test4()
        {
            Graphs graph = new Graphs();
            Assert.Equal(0, graph.getSize());
        }

        [Fact]
        public void test_bfs()
        {
            Graphs graph = new Graphs();
            Node one = graph.addNode(1);
            Node two = graph.addNode(2);
            Node three = graph.addNode(2);

            one.addNeighbor(two);
            one.addNeighbor(three);

            List<Node> expected = new List<Node>();
            expected.Add(one);
            expected.Add(three);
            expected.Add(two);

            Assert.Equal(expected, graph.Depthfirst(one));
        }
        
        [Fact]
        public void test_dfs()
        {
            Graphs graph = new Graphs();
            Node one = graph.addNode(1);
            Node two = graph.addNode(2);
            Node three = graph.addNode(2);

            one.addNeighbor(two);
            one.addNeighbor(three);

            List<Node> expected = new List<Node>();
            expected.Add(one);
            expected.Add(two);
            expected.Add(three);

            Assert.Equal(expected, graph.BreadthFirst(one));
        }
    }
}
