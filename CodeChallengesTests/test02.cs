using data_structures_and_algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace CodeChallengesTests
{
    public class test02
    {
        [Theory]
        [InlineData(6,new int[] { 1, 2, 3, 4, 5 }, new int[] { 1,2,3,6,4,5 })]
        [InlineData(16,new int[] {1,2}, new int[] { 1,16,2 })]
        [InlineData(1,new int[] { }, new int[] { 1 })]

        public void arrayShiftInsertTest(int inputNumber,int[] arr, int[] expectedArr)
        {
            int[] arrTest = arr;
            int[] result = CC02Base.insertShiftArray(arrTest, inputNumber);
            Assert.Equal(expectedArr, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 4, 5 })]
        [InlineData(new int[] { 1, 2 }, new int[] { 1 })]
        [InlineData(new int[] { 1 }, new int[] { })]

        public void arrayShiftRemoveTest(int[] arr, int[] expectedArr)
        {
            int[] arrTest = arr;
            int[] result = CC02Base.removeShiftArray(arrTest);
            Assert.Equal(expectedArr, result);
        }

    }
}
