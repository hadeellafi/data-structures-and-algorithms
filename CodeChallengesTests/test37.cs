using data_structures_and_algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengesTests
{
    public class TestBusinessTrip
    {
        [Fact]
        public void TestBusinessTrip_PossibleTrip_ReturnsTotalCost()
        {
            Graph<string> graph = new Graph<string>();
            Vertex<string> city1 = graph.AddVertex("City1");
            Vertex<string> city2 = graph.AddVertex("City2");
            graph.AddDirectEdge(city1, city2, 100);

            int? cost = GraphBusinessTrip.BusinessTrip(graph, new string[] { "City1", "City2" });

            Assert.Equal(100, cost);
        }

        [Fact]
        public void TestBusinessTrip_ImpossibleTripWithThreeCities_ReturnsNull()
        {
            Graph<string> graph = new Graph<string>();
            Vertex<string> city1 = graph.AddVertex("City1");
            Vertex<string> city2 = graph.AddVertex("City2");
            Vertex<string> city3 = graph.AddVertex("City3");
            graph.AddDirectEdge(city1, city2, 100);
            graph.AddDirectEdge(city2, city3, 100);



            int? cost = GraphBusinessTrip.BusinessTrip(graph, new string[] { "City1", "City3" });

            Assert.Null(cost);
        }

        [Fact]
        public void TestBusinessTrip_EmptyItinerary_ReturnsZero()
        {
            Graph<string> graph = new Graph<string>();

            int? cost = GraphBusinessTrip.BusinessTrip(graph, new string[] { });

            Assert.Equal(0, cost);
        }
        [Fact]
        public void TestBusinessTrip_TripWithThreeCities_ReturnsTotalCost()
        {
            Graph<string> graph = new Graph<string>();
            Vertex<string> city1 = graph.AddVertex("City1");
            Vertex<string> city2 = graph.AddVertex("City2");
            Vertex<string> city3 = graph.AddVertex("City3");
            graph.AddDirectEdge(city1, city2, 100);
            graph.AddDirectEdge(city2, city3, 200);

            int? cost = GraphBusinessTrip.BusinessTrip(graph, new string[] { "City1", "City2", "City3" });

            Assert.Equal(300, cost);
        }


    }
}
