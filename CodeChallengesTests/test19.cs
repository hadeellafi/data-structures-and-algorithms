using data_structures_and_algorithms;
using System;


namespace CodeChallengesTests
{
    public class test19
    {
        [Fact]
        public void TestOddSumRetrrnSum()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            tree.Add(8);
            tree.Add(3);
            tree.Add(10);
            tree.Add(1);
            tree.Add(6);
            tree.Add(4);
            tree.Add(7);
            tree.Add(14);
            tree.Add(13);
            CC17<int> cc17 = new CC17<int>();
            var sum = cc17.OddSum(tree);
            Assert.Equal(24,sum);
        }
        [Fact]
        public void TestOddSum_EmptyTree_ReturnZero()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
           
            CC17<int> cc17 = new CC17<int>();
            var sum = cc17.OddSum(tree);
            Assert.Equal(0, sum);
        }
    }
}
