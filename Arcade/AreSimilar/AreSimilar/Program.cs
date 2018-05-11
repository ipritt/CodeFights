using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Two arrays are called similar if one can be obtained from another by swapping at most one pair of elements in one of the arrays.

Given two arrays a and b, check whether they are similar.

Example

For a = [1, 2, 3] and b = [1, 2, 3], the output should be
areSimilar(a, b) = true.

The arrays are equal, no need to swap any elements.

For a = [1, 2, 3] and b = [2, 1, 3], the output should be
areSimilar(a, b) = true.

We can obtain b from a by swapping 2 and 1 in b.

For a = [1, 2, 2] and b = [2, 1, 1], the output should be
areSimilar(a, b) = false.

Any swap of any two elements either in a or in b won't make a and b equal.

Input/Output

[execution time limit] 3 seconds (cs)

[input] array.integer a

Array of integers.

Guaranteed constraints:
3 ≤ a.length ≤ 105,
1 ≤ a[i] ≤ 1000.

[input] array.integer b

Array of integers of the same length as a.

Guaranteed constraints:
b.length = a.length,
1 ≤ b[i] ≤ 1000.

[output] boolean

true if a and b are similar, false otherwise.
*/

namespace AreSimilar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 1, 2, 1, 1, 1, 2 };
            int[] b = { 1, 1, 2, 1, 2, 1, 2 };
            Console.WriteLine(AreSimilar(a, b));
            Console.ReadLine();
        }

        static bool AreSimilar(int[] a, int[] b)
        {
            bool similar = true;
            bool swapped = false;
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    count++;
                    if (count > 1)
                    {
                        break;
                    }
                    for (int j = i + 1; j < b.Length; j++)
                    {
                        if (a[j] != b[j])
                        {
                            if (a[i] == b[j])
                            {
                                int tmp = a[i];
                                a[i] = a[j];
                                a[j] = tmp;
                                swapped = true;
                                if (j == b.Length - 1 && swapped == false)
                                {
                                    count++;
                                }
                                break;
                            }
                        }
                    }
                }
            }
            if (count < 2)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] != b[i])
                    {
                        count++;
                    }
                }
            }
            if (count > 1)
            {
                similar = false;
            }
            return similar;
        }
    }
}
