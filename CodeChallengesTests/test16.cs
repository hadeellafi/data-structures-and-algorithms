using data_structures_and_algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengesTests
{
    public class test16
    {
        [Fact]
        public void testFindMax_ReturnsMaxValue1()
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>();
            binaryTree.Root = new Node<int>(11);
            binaryTree.Root.Left = new Node<int>(4);
            binaryTree.Root.Right = new Node<int>(12);
            binaryTree.Root.Left.Left = new Node<int>(15);
            binaryTree.Root.Left.Right = new Node<int>(7);

            int maxValue = binaryTree.FindMax();

            int expectedMax = 15;
            Assert.Equal(expectedMax, maxValue);
        }
        [Fact]
        public void testFindMax_ReturnsMaxValue2()
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

            int maxValue = binaryTree.FindMax();

            int expectedMax = 11;
            Assert.Equal(expectedMax, maxValue);
        }
        [Fact]
        public void testFindMax_EmptyTree_ThrowsException()
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>();

            Assert.Throws<InvalidOperationException>(() => binaryTree.FindMax());
        }
    }
}
