using data_structures_and_algorithms;
using System;
using System.Threading.Tasks;

namespace CodeChallengesTests
{
    public class test15
    {
            [Fact]
            public void CanInstantiateEmptyTree()
            {
                BinaryTree<int> tree = new BinaryTree<int>();
                Assert.Null(tree.Root);
            }

            [Fact]
            public void CanInstantiateTreeWithSingleRootNode()
            {
                BinaryTree<int> tree = new BinaryTree<int>();
                tree.Root = new Node<int>(1);
                Assert.NotNull(tree.Root);
                Assert.Equal(1, tree.Root.Value);
                Assert.Null(tree.Root.Left);
                Assert.Null(tree.Root.Right);
            }

            [Fact]
            public void CanAddLeftAndRightChildToNodeInBinarySearchTree()
            {
                BinarySearchTree<int> tree = new BinarySearchTree<int>();
                tree.Add(2);
                tree.Add(1);
                tree.Add(3);

                Assert.Equal(2, tree.Root.Value);
                Assert.Equal(1, tree.Root.Left.Value);
                Assert.Equal(3, tree.Root.Right.Value);
            }

        [Fact]
        public void CanReturnPreOrder()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            tree.Add(10);
            tree.Add(5);
            tree.Add(15);
            tree.Add(3);
            tree.Add(7);
            tree.Add(12);
            tree.Add(20);

            var result = tree.PreOrderTraversal();

            int[] expected = { 10, 5, 3, 7, 15, 12, 20 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CanReturnInOrder()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            tree.Add(10);
            tree.Add(5);
            tree.Add(15);
            tree.Add(3);
            tree.Add(7);
            tree.Add(12);
            tree.Add(20);

            var result = tree.InOrderTraversal();

            int[] expected = { 3, 5, 7, 10, 12, 15, 20 };
            Assert.Equal(expected, result);
        }


        [Fact]
        public void CanReturnPostOrder()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            tree.Add(10);
            tree.Add(5);
            tree.Add(15);
            tree.Add(3);
            tree.Add(7);
            tree.Add(12);
            tree.Add(20);

            var result = tree.PostOrderTraversal();

            int[] expected = { 3, 7, 5, 12, 20, 15, 10 };
            Assert.Equal(expected, result);
        }


        [Fact]
            public void Contains_ReturnsTrue_ForExistingNodeValue()
            {
                BinarySearchTree<int> tree = new BinarySearchTree<int>();
                tree.Add(3);
                tree.Add(2);

                Assert.True(tree.Contains(3));
                Assert.True(tree.Contains(2));
            }

            [Fact]
            public void Contains_ReturnsFalse_ForNonExistingNodeValue()
            {
                BinarySearchTree<int> tree = new BinarySearchTree<int>();
                tree.Add(3);
                tree.Add(2);

                Assert.False(tree.Contains(1));
            }
        }
    }



