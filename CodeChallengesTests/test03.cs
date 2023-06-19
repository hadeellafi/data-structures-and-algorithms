using data_structures_and_algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengesTests
{
    public class test03
    {
        [Theory]
        [InlineData(new int[] { 0,1, 2, 3, 4, 5 },4,4)]
        [InlineData(new int[] {-1,0, 5,7,11,25 }, 0, 1)]
        [InlineData(new int[] {}, 4, -1)] //empty array 
        [InlineData(new int[] { 0, 1, 2, 3, 4, 5 }, 6, -1)]//target not exist in array


        public void TestBinarySearchReturnNum(int []arr,int target, int expected)
        {
            int[] arrTest = arr;
            int result = CC03.BinarySearch( arrTest,target);
            Assert.Equal(expected, result);
        }
    }
}
