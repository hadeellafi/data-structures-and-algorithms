using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data_structures_and_algorithms;
using Xunit;

namespace CodeChallengesTests
{
    public class test05s
    {
        [Fact]
        public void TestInsertEmptyList()
        {
            List testList=new List();
            bool result = testList.IsEmpty();
            Assert.Equal(result, true);
        }
        [Fact]
        public void TestInsertIntoEmptyList()
        {
            List testList = new List();

            testList.InsertFirst(10);

            Assert.Equal(10, testList.head.data);
            Assert.Equal(testList.head, testList.tail);
        }
        [Fact]
        public void TestInsertIntoNonEmptyList()//Can properly insert into the linked list
        {
            List testList = new List();
            testList.InsertFirst(10);
            testList.InsertFirst(20);
            Assert.Equal(20, testList.head.data);
            Assert.Equal(10, testList.tail.data);

        }
        [Fact]
        public void TestHead()//The head property will properly point to the first node
        {
            List testList = new List();
            testList.InsertFirst(10);
            testList.InsertFirst(20);
            testList.InsertFirst(30);
            Assert.Equal(30, testList.head.data);
        }
        [Fact]
        public void TestInsertMultipleNodes()
        {
            List testList = new List();

            testList.InsertFirst(50);
            testList.InsertFirst(40);
            testList.InsertFirst(30);
            

            Assert.Equal(30, testList.head.data);
            Assert.Equal(50, testList.tail.data);
            Assert.Equal(40, testList.head.next.data);
          
            Assert.Null(testList.head.next.next.next);
        }

        [Theory]
        [InlineData(10, true)]
        [InlineData(20, true)]
        [InlineData(30, true)]
        [InlineData(40, false)]
        [InlineData(50, false)]
        public void TestIsIncludeReturnBool(int value, bool expected)//test IsIncludefunction
        {
            List testList = new List();
            testList.InsertFirst(30);
            testList.InsertFirst(20);
            testList.InsertFirst(10);

            bool actual = testList.IsInclude(value);

            
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestToStringRetrunString()
        {
            List testList = new List();
            testList.InsertFirst(10);
            testList.InsertFirst(20);
            testList.InsertFirst(30);

            string result = testList.ToString();

            Assert.Equal("{30}->{20}->{10}->Null", result);
        }

    }

}
/*

Can properly return a collection of all the values that exist in the linked list*/
