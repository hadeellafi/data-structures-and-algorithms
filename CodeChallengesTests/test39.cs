using data_structures_and_algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengesTests
{
    public class GraphConversionTests
    {
        [Fact]
        public void TestConvertMatrixToList_SingleNodeGraph()
        {
            string[] nodes = new string[] { "a" };
            bool[][] matrix = new bool[][] { new bool[] { false } };
            var adjacencyList = CC39.ConvertMatrixToList(nodes, matrix);
            Assert.Single(adjacencyList);
            Assert.Empty(adjacencyList["a"]);
        }

        [Fact]
        public void TestConvertMatrixToList_LinearGraph()
        {
            string[] nodes = new string[] { "a", "b", "c" };
            bool[][] matrix = new bool[][]
            {
            new bool[] { false, true, false },
            new bool[] { true, false, true },
            new bool[] { false, true, false }
            };
            var adjacencyList = CC39.ConvertMatrixToList(nodes, matrix);
            Assert.Equal(3, adjacencyList.Count);
            Assert.Single(adjacencyList["a"]);
            Assert.Equal(2, adjacencyList["b"].Count);
            Assert.Single(adjacencyList["c"]);
        }

        [Fact]
        public void TestConvertMatrixToList_BranchingGraph()
        {
            string[] nodes = new string[] { "a", "b", "c" };
            bool[][] matrix = new bool[][]
            {
            new bool[] { false, true, true },
            new bool[] { true, false, true },
            new bool[] { true, true, false }
            };
            var adjacencyList = CC39.ConvertMatrixToList(nodes, matrix);
            Assert.Equal(3, adjacencyList.Count);
            Assert.Equal(2, adjacencyList["a"].Count);
            Assert.Equal(2, adjacencyList["b"].Count);
            Assert.Equal(2, adjacencyList["c"].Count);
        }
    }

}
