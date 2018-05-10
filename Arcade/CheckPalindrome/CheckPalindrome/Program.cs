using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "a";
            Console.WriteLine(CheckPalindrome(inputString));
            Console.ReadLine();
        }

        static bool CheckPalindrome(string inputString)
        {
            bool isPalindrome = true;
            int a = 0;
            int b = inputString.Length - 1;
            while (a < b)
            {
                if (inputString[a] != inputString[b])
                    isPalindrome = false;
                a++;
                b--;
            }

            return isPalindrome;
        }
    }
}
