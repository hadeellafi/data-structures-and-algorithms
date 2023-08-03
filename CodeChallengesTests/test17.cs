using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using data_structures_and_algorithms; // Updated namespace

namespace CodeChallengesTests
{
    public class Test17
    {
        [Fact]
        public void TestBreadthFirstReturnsArray()
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>();
            binaryTree.Root = new Node<int>(2);
            binaryTree.Root.Left = new Node<int>(7);
            binaryTree.Root.Right = new Node<int>(5);
            binaryTree.Root.Left.Left = new Node<int>(2);
            binaryTree.Root.Left.Right = new Node<int>(6);
            binaryTree.Root.Right.Right = new Node<int>(9);
            binaryTree.Root.Left.Right.Left = new Node<int>(5);
            binaryTree.Root.Left.Right.Right = new Node<int>(11);
            binaryTree.Root.Right.Right.Right = new Node<int>(4);

            CC17<int> cc17 = new CC17<int>(); 
            var result = cc17.BreadthFirst(binaryTree);
            int[] expected = { 2, 7, 5, 2, 6, 9, 5, 11, 4 };

            Assert.Equal(expected, result); 
        }

        [Fact]
        public void TestBreadthFirstThrowsException()
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>();
            CC17<int> cc17 = new CC17<int>();

            Assert.Throws<InvalidOperationException>(() => cc17.BreadthFirst(binaryTree));
        }
    }
}
