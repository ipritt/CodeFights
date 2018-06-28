using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Consider integer numbers from 0 to n - 1 written down along the circle in such a way that the distance between any two neighbouring numbers is equal(note that 0 and n - 1 are neighbouring, too).

//Given n and firstNumber, find the number which is written in the radially opposite position to firstNumber.

//Example

//For n = 10 and firstNumber = 2, the output should be
//circleOfNumbers(n, firstNumber) = 7.



//Input / Output

//[execution time limit] 3 seconds (cs)

//[input] integer n

//A positive even integer.

//Guaranteed constraints:
//4 ≤ n ≤ 20.

//[input] integer firstNumber

//Guaranteed constraints:
//0 ≤ firstNumber ≤ n - 1.

//[output] integer

namespace CircleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10, firstNumber = 7;
            int result = CircleOfNumbers(n, firstNumber);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        static int CircleOfNumbers(int n, int firstNumber)
        {
            return (firstNumber + (n / 2) > n - 1) ? (firstNumber + (n / 2)) - n : firstNumber + (n / 2);
        }
    }
}
