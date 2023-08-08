using data_structures_and_algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengesTests
{
    public class test18
    {
        [Fact]
        public void FizzBuzzTreeReturnsFizzBuzzTree()
        {
            BinaryTree<int> originalTree = new BinaryTree<int>();
            originalTree.Root = new Node<int>(3);
            originalTree.Root.Left = new Node<int>(5);
            originalTree.Root.Right = new Node<int>(15);
            originalTree.Root.Left.Left = new Node<int>(2);
            originalTree.Root.Left.Right = new Node<int>(10);
            originalTree.Root.Right.Left = new Node<int>(30);
            originalTree.Root.Right.Right = new Node<int>(7);

            CC18<int> fizzBuzzConverter = new CC18<int>();
            BinaryTree<string> fizzBuzzTree = fizzBuzzConverter.FizzBuzzTree(originalTree);

            List<string> result = fizzBuzzTree.PreOrderTraversal();
            string[] expected = { "Fizz", "Buzz", "2", "Buzz", "FizzBuzz", "FizzBuzz", "7" };

            Assert.Equal(expected, result);
        }

        [Fact]
        public void FizzBuzzTreeReturnsEmptyTreeForEmptyInput()
        {
            BinaryTree<int> originalTree = new BinaryTree<int>();

            CC18<int> fizzBuzzConverter = new CC18<int>();
            BinaryTree<string> fizzBuzzTree = fizzBuzzConverter.FizzBuzzTree(originalTree);

            List<string> result = fizzBuzzTree.InOrderTraversal();
            Assert.Empty(result);
        }
    }
}
