using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
You are given an array of integers. On each move you are allowed to increase exactly one of its element by one.
Find the minimal number of moves required to obtain a strictly increasing sequence from the input.

Example

For inputArray = [1, 1, 1], the output should be
arrayChange(inputArray) = 3.

Input/Output

[execution time limit] 3 seconds (cs)

[input] array.integer inputArray

Guaranteed constraints:
3 ≤ inputArray.length ≤ 105,
-105 ≤ inputArray[i] ≤ 105.

[output] integer

The minimal number of moves needed to obtain a strictly increasing sequence from inputArray.
It's guaranteed that for the given test cases the answer always fits signed 32-bit integer type.
*/

namespace ArrayChange
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 1, 1, 1 };
            Console.WriteLine(ArrayChange(inputArray));
            Console.ReadLine();
        }

        static int ArrayChange(int[] inputArray)
        {
            int count = 0;
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                if (inputArray[i] >= inputArray[i + 1])
                {
                    count += (inputArray[i] - inputArray[i + 1]) + 1;
                    inputArray[i + 1] = inputArray[i] + 1;
                }
            }
            return count;
        }
    }
}
