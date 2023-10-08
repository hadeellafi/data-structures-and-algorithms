using data_structures_and_algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengesTests
{
    public class DepthFisrtSearch
    {
    
        [Fact]
        public void TestDepthFirst_SingleNodeGraph()
        {
            var graph = new Graph<int>();
            var node = graph.AddVertex(1);
            var result = graph.DepthFirst(node);
            Assert.Single(result);
            Assert.Equal(node, result.First());
        }

        [Fact]
        public void TestDepthFirst_LinearGraph()
        {
            var graph = new Graph<int>();
            var node1 = graph.AddVertex(1);
            var node2 = graph.AddVertex(2);
            var node3 = graph.AddVertex(3);
            graph.AddDirectEdge(node1, node2);
            graph.AddDirectEdge(node2, node3);

            var result = graph.DepthFirst(node1);
            Assert.Equal(3, result.Count);
            Assert.Equal(node1, result[0]);
            Assert.Equal(node2, result[1]);
            Assert.Equal(node3, result[2]);
        }

        [Fact]
        public void TestDepthFirst_BranchingGraph()
        {
            var graph = new Graph<int>();
            var node1 = graph.AddVertex(1);
            var node2 = graph.AddVertex(2);
            var node3 = graph.AddVertex(3);
            var node4 = graph.AddVertex(4);
            graph.AddDirectEdge(node1, node2);
            graph.AddDirectEdge(node1, node3);
            graph.AddDirectEdge(node2, node4);

            var result = graph.DepthFirst(node1);
            Assert.Equal(4, result.Count);
            Assert.Equal(node1, result[0]);
        }
    }

}

