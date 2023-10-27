using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms
{
     public class CC39 
    {
        static public Dictionary<string, List<string>> ConvertMatrixToList(string[] nodes, bool[][] matrix)
        {
            var adjacencyList = new Dictionary<string, List<string>>();

            for (int i = 0; i < nodes.Length; i++)
            {
                adjacencyList[nodes[i]] = new List<string>();

                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j])
                    {
                        adjacencyList[nodes[i]].Add(nodes[j]);
                    }
                }
            }

            return adjacencyList;
        }

    }
}
