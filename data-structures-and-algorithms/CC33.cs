using System;
using System.Collections.Generic;

namespace data_structures_and_algorithms
{
    public class HashMapLeftJoin
    {
        public List<List<string>> LeftJoin(HashTable table1, HashTable table2)
        {
            List<List<string>> left = new List<List<string>>();

            foreach (var key in table1.Keys())
            {
                string value1 = table1.Get(key);
                
                string value2 = table2.Get(key);
                if (value2 == null)
                    value2 = "NULL";


                List<string> data = new List<string> { key, value1, value2 };
                left.Add(data);
            }

            return left;
        }
    }
}
