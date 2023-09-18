using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace data_structures_and_algorithms
{
    public class RepeatedWordClass
    {
        public static string RepeatedWord(string paragraph)
        {
            string[] words = Regex.Split(paragraph, @"[\W_]+");
            HashSet<string> set = new HashSet<string>();
            foreach (var word in words)
            {
                string lowercase = word.ToLower();

                if (!set.Contains(lowercase))
                    set.Add(lowercase);
                else
                    return lowercase;
            }
            return null;


        }
    }
}
