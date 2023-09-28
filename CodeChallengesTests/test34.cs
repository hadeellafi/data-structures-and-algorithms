using data_structures_and_algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengesTests
{
    public class test34
    {
        [Theory]
        [InlineData("In a galaxy far far away", "far")]
        [InlineData("Taco cat ate a taco", "taco")]
        [InlineData("No. Try not. Do or do not. There is no try.", "no")]
        public void MostReapetedWordTest(string input, string expected)
        {
            CC34 cc34 = new CC34();
            var result = cc34.MostReapetedWord(input);
            Assert.Equal(expected, result);
        }
    }
}
