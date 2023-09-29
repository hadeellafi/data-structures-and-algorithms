using data_structures_and_algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengesTests
{

    public class GraphTests
    {
        [Fact]
        public void CanAddVertex()
        {
            var graph = new Graph<int>();

            var vertex = graph.AddVertex(1);

            Assert.True(graph.Contains(vertex));
        }

        [Fact]
        public void CanAddEdge()
        {
            var graph = new Graph<int>();
            var vertex1 = graph.AddVertex(1);
            var vertex2 = graph.AddVertex(2);

            graph.AddDirectEdge(vertex1, vertex2);

            Assert.Contains(vertex2, graph.GetNeighbors(vertex1).Select(edge => edge.Vertex));
        }

        [Fact]
        public void CanRetrieveAllVertices()
        {
            var graph = new Graph<int>();
            var vertex1 = graph.AddVertex(1);
            var vertex2 = graph.AddVertex(2);

            var vertices = graph.GetVertices();

            Assert.Equal(2, vertices.Count);
        }

        [Fact]
        public void CanRetrieveNeighbors()
        {
            var graph = new Graph<int>();
            var vertex1 = graph.AddVertex(1);
            var vertex2 = graph.AddVertex(2);
            graph.AddDirectEdge(vertex1, vertex2);

            var neighbors = graph.GetNeighbors(vertex1);

            Assert.Contains(vertex2, neighbors.Select(edge => edge.Vertex));
        }

        [Fact]
        public void CanRetrieveSize()
        {
            var graph = new Graph<int>();

            graph.AddVertex(1);

            Assert.Equal(1, graph.Size());
        }

        [Fact]
        public void CanHandleGraphWithOneVertexAndEdge()
        {
            var graph = new Graph<int>();
            var vertex1 = graph.AddVertex(1);

            graph.AddDirectEdge(vertex1, vertex1);

            Assert.Single(graph.GetNeighbors(vertex1));
        }
    }

}
