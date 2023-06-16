using data_structures_and_algorithms  ;
using Xunit;
namespace CodeChallengesTests {
    public class testCC01
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
        [InlineData(new int[] { -1, 5, 3, 2 }, new int[] { 2, 3, 5, -1 })]
        [InlineData(new int[] { }, null)]

        public void reverceTest(int[] arr, int[] expectedArr)
        {
            int[] arrTest = arr;
            int[] result =CC01.reverce(arrTest);
            Assert.Equal(expectedArr, result);
        }
    }
}