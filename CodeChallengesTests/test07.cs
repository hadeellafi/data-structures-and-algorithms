using data_structures_and_algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengesTests
{
    public class test07
    {
        [Fact]
        public void KthFromEnd_GreaterThanLengthReturn_ThrowsArgumentException()
        {
            List list = new List();
            list.InsertEnd(1);
            list.InsertEnd(3);
            list.InsertEnd(-1);
            list.InsertEnd(2);

            Assert.Throws<ArgumentException>(() => list.kthFromEnd(5));
        }
        [Fact]
        public void KthFromEnd_KEqualsLength_ThrowsArgumentException()
        {
            List list = new List();
            list.InsertEnd(1);
            list.InsertEnd(3);
            list.InsertEnd(-1);
            list.InsertEnd(2);

            Assert.Throws<ArgumentException>(() => list.kthFromEnd(4));
        }
        [Fact]
        public void KthFromEnd_NegativeK_ThrowsArgumentException()
        {
            List list = new List();
            list.InsertEnd(1);
            list.InsertEnd(2);
            list.InsertEnd(3);

            Assert.Throws<ArgumentException>(() => list.kthFromEnd(-1));
        }
        [Fact]
        public void KthFromEnd_ListOfSize1_ReturnsNodeValue()
        {
            List list = new List();
            list.InsertEnd(5);
            int result = list.kthFromEnd(0);
            Assert.Equal(5, result);
        }

        [Fact]
        public void KthFromEnd_KInMiddle_ReturnsNodeValue()
        {
            List list = new List();
            list.InsertEnd(1);
            list.InsertEnd(3);
            list.InsertEnd(5);
            list.InsertEnd(7);
            list.InsertEnd(9);

            int result = list.kthFromEnd(2);

            Assert.Equal(5, result);
        }
    }
}
