using data_structures_and_algorithms.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengesTests
{
    public class test27
    {
        [Theory]
        [InlineData(new[] { 8, 4, 23, 42, 16, 15 }, new[] { 4, 8, 15, 16, 23, 42 })]
        [InlineData(new[] { 20, 18, 12, 8, 5, -2 }, new[] { -2, 5, 8, 12, 18, 20 })]
        [InlineData(new[] { 5, 12, 7, 5, 5, 7 }, new[] { 5, 5, 5, 7, 7, 12 })]
        [InlineData(new[] { 2, 3, 5, 7, 13, 11 }, new[] { 2, 3, 5, 7, 11, 13 })]
        public void Mergesort_ShouldSortCorrectly(int[] inputArray, int[] expectedSortedArray)
        {
            var cc27 = new CC27();

            cc27.Mergesort(inputArray);

            Assert.Equal(expectedSortedArray, inputArray);
        }

    }
}
