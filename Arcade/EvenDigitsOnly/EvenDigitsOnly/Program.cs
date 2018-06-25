using System;

//Check if all digits of the given integer are even.

//Example

//For n = 248622, the output should be
//evenDigitsOnly(n) = true;
//For n = 642386, the output should be
//evenDigitsOnly(n) = false.
//Input/Output

//[execution time limit] 3 seconds(cs)

//[input]
//integer n

//Guaranteed constraints:
//1 ≤ n ≤ 109.

//[output] boolean

//true if all digits of n are even, false otherwise.

namespace EvenDigitsOnly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 24862562;
            bool allEven = EvenDigitsOnly(n);
            Console.WriteLine(allEven);
            Console.ReadLine();
        }

        static bool EvenDigitsOnly(int n)
        {
            bool allEven = true;
            string intString = n.ToString();
            for(int i = 0; i < intString.Length; i++)
            {
                if((int)intString[i] % 2 != 0)
                {
                    allEven = false;
                    break;
                }
            }
            return allEven;
        }
    }
}
