using data_structures_and_algorithms;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CodeChallengesTests
{
    public class test13
    {
        [Theory]
        [InlineData("{}", true)]
        [InlineData("{}(){}", true)]
        [InlineData("()[[Extra Characters]]", true)]
        [InlineData("(){}[[]]", true)]
        [InlineData("{}{Code}[Fellows](())", true)]
        [InlineData("", true)] // Empty string is balanced
        [InlineData("[({}]", false)]
        [InlineData("(]", false)]
        [InlineData("{(})", false)]
        [InlineData("{",false)]
        [InlineData(")", false)]

        public void testValidateBrackets(string input, bool expectedOutput)
        {
            var validator = new CC13();
            Assert.Equal(expectedOutput,validator.ValidateBrackets(input));
        }
    }
}
