using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms
{
    public class HashTable
    {
        public LinkedList<KeyValuePair<string, string>>[] Table;
        public HashTable(int size)
        {
            Table = new LinkedList<KeyValuePair<string, string>>[size];
        }

         
        public void Set(string key, string value)
        {
            int index = Hash(key);
            if (Table[index] == null)
                Table[index] = new LinkedList<KeyValuePair<string, string>>();
            KeyValuePair<string, string> entry = new KeyValuePair<string, string>(key, value);
            Table[index].AddFirst(entry);
        }
        public int Hash(string key)
        {
            int hashValue = 0;
            char[] letters = key.ToCharArray();
            for (int i = 0; i < letters.Length; i++)
            {
                hashValue += letters[i];
            }
            hashValue=(hashValue*11)%Table.Length;
            return hashValue;
        }
        public bool Has(string key)
        {
            int index = Hash(key);
            if (Table[index] == null)
                return false;

            foreach (var entry in Table[index])
            {
                if (entry.Key == key)
                {
                    return true;
                }
            }
            return false;
        }

        public string Get(string key)
        {
            int index = Hash(key);
            if (Table[index] == null)
                return null; 

            foreach (var entry in Table[index])
            {
                if (entry.Key == key)
                {
                    return entry.Value;
                }
            }

            return null; 
        }

        public List<string> Keys()
        {
            List<string> keysList = new List<string>();

            foreach (var list in Table)
            {
                if (list != null)
                {
                    foreach (var entry in list)
                    {
                        keysList.Add(entry.Key);
                    }
                }
            }

            return keysList;
        }

       
    }
}
