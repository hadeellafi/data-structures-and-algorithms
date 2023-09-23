using data_structures_and_algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengesTests
{
    public class test32
    {
            [Fact]
            public void TestTreeIntersectionMethodReturnsCommonValues()
            {
                TreeNode root1 = new TreeNode(1);
                root1.Left = new TreeNode(2);
                root1.Right = new TreeNode(3);

                TreeNode root2 = new TreeNode(2);
                root2.Left = new TreeNode(3);
                root2.Right = new TreeNode(4);

                TreeIntersection treeIntersection = new TreeIntersection();

                HashSet<int> result = treeIntersection.TreeIntersectionMethod(root1, root2);

                Assert.Equal(2, result.Count);
                Assert.Contains(2, result);
                Assert.Contains(3, result);
            }

            [Fact]
            public void TestTreeIntersectionMethodReturnsEmptySet()
            {
                TreeNode root1 = new TreeNode(1);
                root1.Left = new TreeNode(2);
                root1.Right = new TreeNode(3);

                TreeNode root2 = new TreeNode(4);
                root2.Left = new TreeNode(5);
                root2.Right = new TreeNode(6);

                TreeIntersection treeIntersection = new TreeIntersection();

                HashSet<int> result = treeIntersection.TreeIntersectionMethod(root1, root2);

                Assert.Empty(result);
            }

            [Fact]
            public void TestTreeIntersectionMethodReturnsAllValuesForIdenticalTrees()
            {
                TreeNode root1 = new TreeNode(1);
                root1.Left = new TreeNode(2);
                root1.Right = new TreeNode(3);

                TreeNode root2 = new TreeNode(1);
                root2.Left = new TreeNode(2);
                root2.Right = new TreeNode(3);

                TreeIntersection treeIntersection = new TreeIntersection();

                HashSet<int> result = treeIntersection.TreeIntersectionMethod(root1, root2);

                Assert.Equal(3, result.Count);
                Assert.Contains(1, result);
                Assert.Contains(2, result);
                Assert.Contains(3, result);
            }
        }
    }

