using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "a(bcdefghijkl(mno)p)q";
            Console.WriteLine(ReverseParentheses(s));
            Console.ReadLine();
        }

        static string ReverseParentheses(string s)
        {
            int lastOpenParen = 0;
            List<char> str = s.ToList();
            List<char> subString = new List<char>();
            for (int i = 0; i < str.Count; i++)
            {
                if (str[i] == '(')
                    if (i > lastOpenParen)
                        lastOpenParen = i;
            }
            for (int i = lastOpenParen; i >= 0; i--)
            {
                subString.Clear();
                if (str[lastOpenParen] == '(')
                {
                    int j = lastOpenParen + 1;
                    do
                    {
                        subString.Add(str[j]);
                        j++;
                    } while (str[j] != ')');
                    subString.Reverse();
                    str.RemoveRange(lastOpenParen, j - (lastOpenParen - 1));
                    str.InsertRange(lastOpenParen, subString);
                    lastOpenParen = 0;
                    for (int k = 0; k < str.Count; k++)
                    {
                        if (str[k] == '(')
                            if (k > lastOpenParen)
                                lastOpenParen = k;
                    }
                    i = lastOpenParen + 1;
                }
            }
            StringBuilder newString = new StringBuilder();
            foreach (char item in str)
                newString.Append(item);
            return newString.ToString();
        }
    }
}
