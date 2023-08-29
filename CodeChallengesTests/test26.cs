using data_structures_and_algorithms.Sorting;
using System;
using System.Threading.Tasks;

namespace CodeChallengesTests
{
    public class test26
    {
        
        [Theory]
        [InlineData(new int[] { 2, 3, 5, 7, 13, 11 }, new int[] { 2, 3, 5, 7, 11, 13 })]//NearlysortedArray
        [InlineData(new int[] { 5, 12, 7, 5, 5, 7 }, new int[] { 5, 5, 5, 7, 7, 12 })]//FewUniquesArray
        [InlineData(new int[] { 20, 18, 12, 8, 5, -2 }, new int[] { -2, 5, 8, 12, 18, 20 })]//ReverseSortedArray
        [InlineData(new int[] { 8, 4, 23, 42, 16, 15 }, new int[] { 4, 8, 15, 16, 23, 42 })]//InputArray
        public void TestInsertionSort(int[] input, int[] expected)
        {
            CC26 sorter = new CC26();
            int[] sortedArr =new int[input.Length];
            sortedArr = sorter.InsertionSort(input);

            Assert.Equal(expected, sortedArr);
        }
    }
}
