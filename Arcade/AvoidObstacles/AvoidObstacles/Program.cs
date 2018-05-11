using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
You are given an array of integers representing coordinates of obstacles situated on a straight line.

Assume that you are jumping from the point with coordinate 0 to the right. You are allowed only to make jumps of the same length represented by some integer.

Find the minimal length of the jump enough to avoid all the obstacles.

Example

For inputArray = [5, 3, 6, 7, 9], the output should be
avoidObstacles(inputArray) = 4.

Check out the image below for better understanding:



Input/Output

[execution time limit] 3 seconds (cs)

[input] array.integer inputArray

Non-empty array of positive integers.

Guaranteed constraints:
2 ≤ inputArray.length ≤ 10,
1 ≤ inputArray[i] ≤ 40.

[output] integer

The desired length.
*/

namespace AvoidObstacles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 1, 4, 10, 6, 2 };
            Console.WriteLine(AvoidObstacles(inputArray));
            Console.ReadLine();
        }

        static int AvoidObstacles(int[] inputArray)
        {
            int jump = 2;
            int i = 0;
            while (i < inputArray.Max())
            {
                if (inputArray.Contains(jump))
                {
                    jump++;
                }
                for (int j = 2; j < inputArray.Max(); j++)
                {
                    if (inputArray.Contains(jump * j))
                    {
                        jump++;
                        break;
                    }
                }
                i++;
            }
            return jump;
        }
    }
}
