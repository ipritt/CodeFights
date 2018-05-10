using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonCharacterCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "aabcc", s2 = "adcaa";
            Console.WriteLine(CommonCharacterCount(s1, s2));
            Console.ReadLine();
        }

        static int CommonCharacterCount(string s1, string s2)
        {
            Dictionary<char, int> values = new Dictionary<char, int>();
            List<char> list = s2.ToList();
            int count = 0;
            for(int i = 0; i < s1.Length; i++)
            {
                for(int j = 0; j < list.Count; j++)
                {
                    if (s1[i] == list[j])
                    {
                        if (!values.ContainsKey(list[j]))
                            values[list[j]] = 0;
                        values[list[j]]++;
                        list.RemoveAt(j);
                        break;
                    }
                }
            }
            foreach (var item in values)
                count += item.Value;
            return count;
        }
    }
}
