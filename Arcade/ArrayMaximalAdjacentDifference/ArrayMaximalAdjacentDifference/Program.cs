using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Given an array of integers, find the maximal absolute difference between any two of its adjacent elements.

Example

For inputArray = [2, 4, 1, 0], the output should be
arrayMaximalAdjacentDifference(inputArray) = 3.

Input/Output

[execution time limit] 3 seconds (cs)

[input] array.integer inputArray

Guaranteed constraints:
3 ≤ inputArray.length ≤ 10,
-15 ≤ inputArray[i] ≤ 15.

[output] integer

The maximal absolute difference.
*/

namespace ArrayMaximalAdjacentDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { -1, 4, 10, 3, -2 };
            Console.WriteLine(ArrayMaximalAdjacentDifference(inputArray));
            Console.WriteLine();
        }

        static int ArrayMaximalAdjacentDifference(int [] a)
        {
            int count = 0;
            for (int i = 0; i < a.Length - 1; i++)
            {
                int temp;
                if (a[i] < a[i + 1])
                {
                    temp = a[i + 1] - a[i];
                }
                else
                {
                    temp = a[i] - a[i + 1];
                }
                if (temp > count)
                {
                    count = temp;
                }
            }
            return count;
        }
    }
}
