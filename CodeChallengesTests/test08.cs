using data_structures_and_algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengesTests
{
    public class test08
    {
        [Fact]
        public void TestZipListBothListEmplty()
        {
            List list1 = new List();
            List list2 = new List();
            List zipList = new List();
            zipList=zipList.zipLists(list1 , list2);

            Assert.Null(zipList.head);

        }

        [Fact]
        public void TestZipListOneListEmpty()
        {
            List list1 = new List();
            List list2 = new List();
            List zipList = new List();

            list1.InsertEnd(1);
            list1.InsertEnd(2);
            list1.InsertEnd(3);

            zipList = zipList.zipLists(list1, list2);

            Assert.Equal(list1.Size() , zipList.Size());
            Assert.Equal(list1.ToString(), zipList.ToString());
        }

        [Fact]
        public void TestZipListBothListsSameSize()
        {
            List list1 = new List();
            List list2 = new List();
            List zipList = new List();

            list1.InsertEnd(1);
            list1.InsertEnd(3);
            list1.InsertEnd(5);

            list2.InsertEnd(2);
            list2.InsertEnd(4);
            list2.InsertEnd(6);

            zipList = zipList.zipLists(list1, list2);

            Assert.Equal(list1.Size() + list2.Size(), zipList.Size());
            Assert.Equal("{1}->{2}->{3}->{4}->{5}->{6}->Null", zipList.ToString());
        }
        [Fact]
        public void TestZipListOneListBigger()
        {
            List list1 = new List();
            List list2 = new List();
            List zipList = new List();

            list1.InsertEnd(1);
            list1.InsertEnd(3);
            list1.InsertEnd(5);

            list2.InsertEnd(2);
            list2.InsertEnd(4);

            zipList = zipList.zipLists(list1, list2);

            Assert.Equal(list1.Size() + list2.Size(), zipList.Size());
            Assert.Equal("{1}->{2}->{3}->{4}->{5}->Null", zipList.ToString());
        }

    }
}
