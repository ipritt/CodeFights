using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLongestStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = { "abc", "eeee", "abcd", "dcd" };
            string[] newArray = AllLongestStrings(inputArray);
            foreach(string str in newArray)
                Console.WriteLine(str);
            Console.ReadLine();
        }

        static string[] AllLongestStrings(string[] inputArray)
        {
            int length = 0;
            int count = 0;
            foreach (string str in inputArray)
            {
                if (str.Length >= length)
                {
                    length = str.Length;
                    if (str.Length == length)
                        count++;
                }
            }
            string[] newArray = new string[count];
            int j = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length == length)
                {
                    newArray[j] = inputArray[i];
                    j++;
                }
            }
            return newArray;
        }
    }
}
