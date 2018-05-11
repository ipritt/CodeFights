using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Given a string, find out if its characters can be rearranged to form a palindrome.

Example

For inputString = "aabb", the output should be
palindromeRearranging(inputString) = true.

We can rearrange "aabb" to make "abba", which is a palindrome.

Input/Output

[execution time limit] 3 seconds (cs)

[input] string inputString

A string consisting of lowercase English letters.

Guaranteed constraints:
1 ≤ inputString.length ≤ 50.

[output] boolean

true if the characters of the inputString can be rearranged to form a palindrome, false otherwise.
*/


//  Palindromes have a nice characteristic where only 1 character can be present an odd number of times.
//  All other characters must exist in even numbers. Also, I tend to use Dictionaries to keep track of
//  of counts of multiple items. I'm not certain that this is the most efficient way to do so, but so
//  far it has worked for me within memory and time contraints on CodeFights.
namespace PalindromeRearranging
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "aaaddc";
            Console.WriteLine(PalindromeRearranging(inputString));
            Console.ReadLine();
        }

        static bool PalindromeRearranging(string inputString)
        {
            int count = 0;
            bool isPali = true;
            Dictionary<char, int> values = new Dictionary<char, int>();
            foreach (char item in inputString)
            {
                if (!values.ContainsKey(item))
                {
                    values[item] = 0;
                }
                values[item]++;
            }
            foreach (var item in values)
            {
                if (item.Value == 1)
                {
                    count++;
                }
            }
            if (count > 1)
            {
                isPali = false;
            }
            return isPali;
        }
    }
}
