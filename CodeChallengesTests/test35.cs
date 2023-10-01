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
        //////CC36
        [Fact]
        public void TestBreadthFirst_ReturnsCorrectOrder()
        {
            // Arrange
            Graph<int> graph = new Graph<int>();
            Vertex<int> node1 = graph.AddVertex(1);
            Vertex<int> node2 = graph.AddVertex(2);
            Vertex<int> node3 = graph.AddVertex(3);
            graph.AddUnDirectEdge(node1, node2);
            graph.AddUnDirectEdge(node2, node3);

            // Act
            List<Vertex<int>> result = graph.BreadthFirst(node1);

            // Assert
            Assert.Equal(3, result.Count);
            Assert.Equal(node1, result[0]);
            Assert.Equal(node2, result[1]);
            Assert.Equal(node3, result[2]);
        }

        [Fact]
        public void TestBreadthFirst_ReturnsEmptyListForIsolatedNode()
        {
            // Arrange
            Graph<int> graph = new Graph<int>();
            Vertex<int> isolatedNode = graph.AddVertex(4);

            // Act
            List<Vertex<int>> result = graph.BreadthFirst(isolatedNode);

            // Assert
            Assert.Single(result);
            Assert.Equal(isolatedNode, result[0]);
        }

        [Fact]
        public void TestBreadthFirst_ThrowsExceptionForNonExistentNode()
        {
            // Arrange
            Graph<int> graph = new Graph<int>();
            Vertex<int> nonExistentNode = new Vertex<int>(5);

            // Act & Assert
            Assert.Throws<KeyNotFoundException>(() => graph.BreadthFirst(nonExistentNode));
        }

    }

}
