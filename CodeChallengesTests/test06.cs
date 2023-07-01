using data_structures_and_algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengesTests
{
    public class test06
    {
        [Fact]
        public void TestInsertEndIntoEmptyList()
        {
            List testList = new List();

            testList.InsertEnd(10);

            Assert.Equal(10, testList.head.data);
            Assert.Equal(testList.head, testList.tail);
        }
        [Fact]
        public void TestInsertMultipleNodes2()
        {
            List testList = new List();

            testList.InsertEnd(50);
            testList.InsertEnd(40);
            testList.InsertEnd(30);


            Assert.Equal(50, testList.head.data);
            Assert.Equal(30, testList.tail.data);
            Assert.Equal(40, testList.head.next.data);

            Assert.Null(testList.head.next.next.next);
        }

        [Fact]
        public void TestInsertBeforeInMiddle()
        {
            List testList = new List();

            testList.InsertEnd(10);
            testList.InsertEnd(30);
            testList.InsertEnd(40);
            testList.InsertBefore(30, 20);

            Assert.Equal(10, testList.head.data);
            Assert.Equal(20, testList.head.next.data);
            Assert.Equal(30, testList.head.next.next.data);
            Assert.Equal(40, testList.tail.data);

        }

        [Fact]
        public void TestInsertBeforeHead()
        {
            List testList = new List();

            testList.InsertEnd(20);
            testList.InsertEnd(30);
           
            testList.InsertBefore(20, 10);

            Assert.Equal(10, testList.head.data);
            Assert.Equal(20, testList.head.next.data);
            Assert.Equal(30, testList.tail.data);

        }

        [Fact]
        public void TestInsertAfterInMiddle()
        {
            List testList = new List();

            testList.InsertEnd(10);
            testList.InsertEnd(30);
            testList.InsertEnd(40);
            testList.InsertAfter(10, 20);

            Assert.Equal(10, testList.head.data);
            Assert.Equal(20, testList.head.next.data);
            Assert.Equal(30, testList.head.next.next.data);
            Assert.Equal(40, testList.tail.data);

        }
        [Fact]
        public void TestInsertAfterTail()
        {
            List testList = new List();

            testList.InsertEnd(10);
            testList.InsertEnd(20);

            testList.InsertAfter(20, 30);

            Assert.Equal(10, testList.head.data);
            Assert.Equal(20, testList.head.next.data);
            Assert.Equal(30, testList.head.next.next.data);

            Assert.Equal(30, testList.tail.data);

        }
        [Fact]
        public void TestDeleteHeadValue() {
            List testList = new List();
            testList.InsertEnd(10);
            testList.InsertEnd(20);
            testList.InsertEnd(30);
            testList.DeleteNodeByValue(10);
            Assert.Equal(20, testList.head.data);
            Assert.Equal(30, testList.head.next.data);
            Assert.Equal(30, testList.tail.data);


        }
        [Fact]
        public void TestDeleteTailValue()
        {
            List testList = new List();
            testList.InsertEnd(10);
            testList.InsertEnd(20);
            testList.InsertEnd(30);
            testList.DeleteNodeByValue(30);
            Assert.Equal(20, testList.tail.data);
        }

        [Fact]
        public void TestDeleteInMiddleValue()
        {
            List testList = new List();
            testList.InsertEnd(10);
            testList.InsertEnd(20);
            testList.InsertEnd(30);
            testList.DeleteNodeByValue(20);
            Assert.Equal(10, testList.head.data);
            Assert.Equal(30, testList.head.next.data);
            Assert.Equal(30, testList.tail.data);


        }

    }
}
/*
Can successfully insert a node after the last node of the linked list*/