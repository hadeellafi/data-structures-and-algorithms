using data_structures_and_algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengesTests
{

    public class test14
    {
        [Fact]
        public void testGetMaxReturnMaxValue()
        {
            var maxStack = new MaxStack();
            maxStack.Push(5);
            maxStack.Push(10);
            maxStack.Push(3);
            maxStack.Push(15);

            int max1 = maxStack.GetMax();
            maxStack.Pop();

            int max2 = maxStack.GetMax();
            maxStack.Pop();

            int max3 = maxStack.GetMax();
            maxStack.Pop();

            int max4 = maxStack.GetMax();

            Assert.Equal(15, max1);
            Assert.Equal(10, max2);
            Assert.Equal(10, max3);
            Assert.Equal(5, max4);

        }

        [Fact]
        public void testGetMaxThrowException()
        {
            var maxStack = new MaxStack();

            Assert.Throws<InvalidOperationException>(() => maxStack.GetMax());
        }
    }
}


