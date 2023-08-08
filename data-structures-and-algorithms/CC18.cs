using System;

namespace data_structures_and_algorithms
{
    public class CC18<T> where T : IComparable
    {
        public BinaryTree<string> FizzBuzzTree(BinaryTree<T> tree)
        {
            BinaryTree<string> binaryTree = new BinaryTree<string>();
            binaryTree.Root = ConvertTree(tree.Root);
            return binaryTree;
        }

        public Node<string> ConvertTree(Node<T> originNode)
        {
            if (originNode == null)
            {
                return null;
            }

            int intValue = Convert.ToInt32(originNode.Value);

            string newValue;
            if (intValue % 3 == 0 && intValue % 5 == 0)
            {
                newValue = "FizzBuzz";
            }
            else if (intValue % 3 == 0)
            {
                newValue = "Fizz";
            }
            else if (intValue % 5 == 0)
            {
                newValue = "Buzz";
            }
            else
            {
                newValue = originNode.Value.ToString();
            }

            Node<string> newNode = new Node<string>(newValue);
            newNode.Left = ConvertTree(originNode.Left);
            newNode.Right = ConvertTree(originNode.Right);

            return newNode;
        }
    }
}
