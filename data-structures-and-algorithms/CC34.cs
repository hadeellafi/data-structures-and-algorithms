using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace data_structures_and_algorithms
{
    public class CC34
    {
        public string MostReapetedWord(string paragraph)
        {
            string[] words = Regex.Split(paragraph.ToLower(), @"[\W_]+");
            Hashtable hashtable = new Hashtable();
            foreach (string word in words)
            {
                if (hashtable.ContainsKey(word))
                {
                    hashtable[word]= (int)hashtable[word]+1;
                }
                else
                {
                    hashtable.Add(word, 1);
                }
            }
            int count = 0;
            string mostReapetedWord = null;
            foreach (DictionaryEntry item in hashtable)
            {
                if ((int)item.Value > count)
                {
                    count = (int)item.Value;
                    mostReapetedWord = item.Key.ToString();
                }
            }
            return mostReapetedWord;
        }
    }
}
