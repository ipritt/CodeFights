using System;
using System.Text;

//Given a string, replace each its character by the next one in the English alphabet(z would be replaced by a).

//Example

//For inputString = "crazy", the output should be
//alphabeticShift(inputString) = "dsbaz".

//Input/Output

//[execution time limit] 3 seconds(cs)

//[input]
//string inputString

//Non-empty string consisting of lowercase English characters.

//Guaranteed constraints:
//1 ≤ inputString.length ≤ 1000.

//[output] string

//The result string after replacing all of its characters.

namespace AlphabeticShift
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "crazy";
            Console.WriteLine(AlphabeticShift(inputString));
            Console.ReadLine();
        }

        static string AlphabeticShift(string input)
        {
            StringBuilder newString = new StringBuilder();
            for(int i = 0; i < input.Length; i++)
            {
                if(input[i] == 'z')
                {
                    newString.Append('a');
                }
                else
                {
                    newString.Append((char)(input[i] + 1));
                }
            }
            return newString.ToString();
        }
    }
}
