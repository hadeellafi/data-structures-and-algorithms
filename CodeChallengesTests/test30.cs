using data_structures_and_algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengesTests
{
    public class test30
    {
        [Fact]
        public void SetAndGetKeySuccessfully()
        {
            var hashTable = new HashTable(10);

            hashTable.Set("key1", "value1");
            var result = hashTable.Get("key1");

            Assert.Equal("value1", result);
        }

        [Fact]
        public void SetAndGetNonExistentKeyReturnsNull()
        {
            var hashTable = new HashTable(10);

            var result = hashTable.Get("key");

            Assert.Null(result);
        }

        [Fact]
        public void RetrieveListOfKeysSuccessfully()
        {
            var hashTable = new HashTable(10);
            hashTable.Set("key1", "value1");
            hashTable.Set("key2", "value2");
            hashTable.Set("key3", "value3");

            var keys = hashTable.Keys();

            Assert.Contains("key1", keys);
            Assert.Contains("key2", keys);
            Assert.Contains("key3", keys);
        }

        [Fact]
        public void HandleCollisionSuccessfully()
        {
            var hashTable = new HashTable(10);

            hashTable.Set("abc", "value1");
            hashTable.Set("bac", "value2");

            var result1 = hashTable.Get("abc");
            var result2 = hashTable.Get("bac");

            Assert.Equal("value1", result1);
            Assert.Equal("value2", result2);
        }

        [Fact]
        public void RetrieveValueFromCollisionBucketSuccessfully()
        {
            var hashTable = new HashTable(10);

            hashTable.Set("abc", "value1");
            hashTable.Set("bac", "value2");

            var result1 = hashTable.Get("abc");
            var result2 = hashTable.Get("bac");

            Assert.Equal("value1", result1);
            Assert.Equal("value2", result2);
        }

        [Fact]
        public void HashKeyToInRangeValueSuccessfully()
        {
            var hashTable = new HashTable(10);

            int index = hashTable.Hash("abc");

            Assert.InRange(index, 0, 9); 
        }
    }
}
