using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Several people are standing in a row and need to be divided into two teams. The first person goes into team 1, the second goes into team 2, the third goes into team 1 again, the fourth into team 2, and so on.

You are given an array of positive integers - the weights of the people. Return an array of two integers, where the first element is the total weight of team 1, and the second element is the total weight of team 2 after the division is complete.

Example

For a = [50, 60, 60, 45, 70], the output should be
alternatingSums(a) = [180, 105].

Input/Output

[execution time limit] 3 seconds (cs)

[input] array.integer a

Guaranteed constraints:
1 ≤ a.length ≤ 10,
45 ≤ a[i] ≤ 100.

[output] array.integer
*/

namespace AlternatingSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 50, 60, 60, 45, 70 };
            int[] sums = AlternatingSums(a);
            foreach (int item in sums)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        static int[] AlternatingSums(int[] a)
        {
            int[] sums = new int[2];
            for (int i = 0; i < a.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sums[0] += a[i];
                }
                else
                {
                    sums[1] += a[i];
                }
            }
            return sums;
        }
    }
}
