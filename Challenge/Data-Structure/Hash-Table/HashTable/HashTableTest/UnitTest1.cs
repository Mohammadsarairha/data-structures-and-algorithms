using System;
using Xunit;
using HashTable;

namespace HashTableTest
{
    public class UnitTest1
    {
        MyHashTable hashTable = new MyHashTable(1024);
        //Setting a key/value to hashtable 
        [Fact]
        public void Test1()
        {
            hashTable.Set("1", "Cat");
            hashTable.Set("2", "Dog");
            hashTable.Set("3", "Fish");

            Assert.Equal("Cat",hashTable.Get("1").Value);
        }

        //Retrieving based on a key returns the value stored
        [Fact]
        public void Test2()
        {
            hashTable.Set("1", "Cat");
            hashTable.Set("2", "Dog");
            Assert.True(hashTable.Contains("2"));
        }
        //Successfully returns null for a key that does not exist in the hashtable
        [Fact]
        public void Test3()
        {
            MyHashTable hashTable1 = new MyHashTable(1024);
            Assert.Null(hashTable1.Get("3"));
        }
    }
}
