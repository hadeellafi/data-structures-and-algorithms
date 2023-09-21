using System;
using System.Collections.Generic;

namespace data_structures_and_algorithms
{
    public class TreeIntersection
    {
        public static HashSet<int> FindCommonValues(Node<int> root1, Node<int> root2)
        {
            HashSet<int> commonValues = new HashSet<int>();
            Dictionary<int, bool> valuesMap = new Dictionary<int, bool>();

            void TraverseTree(Node<int> node)
            {
                if (node == null)
                    return;

                valuesMap[node.Value] = true;
                TraverseTree(node.Left);
                TraverseTree(node.Right);
            }

            TraverseTree(root1);

            void CheckCommonValues(Node<int> node)
            {
                if (node == null)
                    return;

                if (valuesMap.ContainsKey(node.Value))
                {
                    commonValues.Add(node.Value);
                }

                CheckCommonValues(node.Left);
                CheckCommonValues(node.Right);
            }

            CheckCommonValues(root2);

            return commonValues;
        }
    }
}
