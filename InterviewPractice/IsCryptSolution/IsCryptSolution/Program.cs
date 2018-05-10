using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsCryptSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] crypt = { "AA", "BB", "AA" };
            char[][] solution =
            {
                new char[] { 'A', '1' },
                new char[] { 'B', '0' },
                //new char[] { 'D', '1' },
                //new char[] { 'I', '5' },
                //new char[] { 'J', '8' },
                //new char[] { 'K', '6' },
                //new char[] { 'L', '3' },
                //new char[] { 'O', '7' },
                //new char[] { 'P', '9' }
            };
            Console.WriteLine(IsCryptSolution(crypt, solution));
            Console.ReadLine();
        }

        static bool IsCryptSolution(string[] crypt, char[][] solution)
        {
            StringBuilder word1 = new StringBuilder();
            StringBuilder word2 = new StringBuilder();
            StringBuilder word3 = new StringBuilder();
            int wordCount = 0;
            foreach(string word in crypt)
            {
                wordCount++;
                for(int letter = 0; letter < word.Length; letter++ )
                {
                    foreach (char[] pair in solution)
                    {
                        if (pair[0] == word[letter])
                        {
                            switch(wordCount)
                            {
                                case 1:
                                    word1.Append(pair[1]);
                                    break;
                                case 2:
                                    word2.Append(pair[1]);
                                    break;
                                case 3:
                                    word3.Append(pair[1]);
                                    break;
                            }
                        }
                    }
                }
            }
            Int64 sum = Convert.ToInt64(word1.ToString()) + Convert.ToInt64(word2.ToString());
            if (word1.Length == 1 && word2.Length == 1 && word3.Length == 1)
            {
                if (sum == Convert.ToInt64(word3.ToString()))
                    return true;
                else
                    return false;
            }
            else if (word1[0] != '0' && word2[0] != '0' && word3[0] != '0' && sum.ToString()[0] != '0')
            {
                if (sum == Convert.ToInt64(word3.ToString()))
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
    }
}
