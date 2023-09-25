using data_structures_and_algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengesTests
{
    public class test33
    {
     
        [Fact]
        public void TestLeftJoin_WithCommonKeys()
        {
            var table1 = new HashTable(10);
            var table2 = new HashTable(10);
            table1.Set("key1", "synonym1");
            table2.Set("key1", "antonym1");
            var leftJoin = new HashMapLeftJoin();
            var result = leftJoin.LeftJoin(table1, table2);
            Assert.Equal(new List<string> { "key1", "synonym1", "antonym1" }, result[0]);
        }

        [Fact]
        public void TestLeftJoin_WithNoCommonKeys()
        {
            var table1 = new HashTable(10);
            var table2 = new HashTable(10);
            table1.Set("key1", "synonym1");
            table2.Set("key2", "antonym2");
            var leftJoin = new HashMapLeftJoin();
            var result = leftJoin.LeftJoin(table1, table2);
            Assert.Equal(new List<string> { "key1", "synonym1", "NULL" }, result[0]);
        }

        [Fact]
        public void TestLeftJoin_WithEmptySecondTable()
        {
            var table1 = new HashTable(10);
            var table2 = new HashTable(10);
            table1.Set("key1", "synonym1");
            var leftJoin = new HashMapLeftJoin();
            var result = leftJoin.LeftJoin(table1, table2);
            Assert.Equal(new List<string> { "key1", "synonym1", "NULL" }, result[0]);
        }
    }

}

