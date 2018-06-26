using System;
using System.Collections.Generic;

//A sequence of integers is called a zigzag sequence if each of its elements is either strictly less than all its neighbors or strictly greater than all its neighbors.For example, the sequence 4 2 3 1 5 3 is a zigzag, but 7 3 5 5 2 and 3 8 6 4 5 aren't. Sequence of length 1 is also a zigzag.

//For a given array of integers return the length of its longest contiguous sub-array that is a zigzag sequence.

//Example

//For a = [9, 8, 8, 5, 3, 5, 3, 2, 8, 6], the output should be
//zigzag(a) = 4.

//The longest zigzag sub-arrays are [5, 3, 5, 3] and[3, 2, 8, 6] and they both have length 4.

//For a = [4, 4], the output should be
//zigzag(a) = 1.

//The longest zigzag sub-array is [4] - it has only one element, which is strictly greater than all its neighbors (there are none of them).

//Input/Output

//[execution time limit] 3 seconds(cs)

//[input]
//array.integer a

//Guaranteed constraints:
//2 ≤ a.length ≤ 25,
//0 ≤ a[i] ≤ 100.

//[output]
//integer

//[C#] Syntax Tips

namespace Zigzag
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = { 0, 0, 0, 0, 1, 0, 0, 0, 1 };
            //9, 8, 8, 5, 3, 5, 3, 2, 8, 6 exp 4
            //2, 1, 4, 4, 1, 4, 4, 1, 2, 0, 1, 0, 0, 3, 1, 3, 4, 1, 3, 4 exp 6
            int output = Zigzag(sequence);
            Console.WriteLine(output);
            Console.ReadLine();
        }

        static int Zigzag(int[] a)
        {
            int result = 0;
            int previous = 0;
            int next = 0;
            List<int> subList = new List<int>();
            if (a.Length == 1 || a.Length == 2)
            {
                return 1;
            }
            for (int i = 1; i < a.Length - 1; i++)
            {
                previous = a[i - 1];
                next = a[i + 1];
                if((a[i] < previous && a[i] < next) || (a[i] > previous && a[i] > next))
                {
                    if(subList.Count == 0)
                    {
                        subList.Add(previous);
                        subList.Add(a[i]);
                    }
                    else
                    {
                        subList.Add(a[i]);
                    }
                    if(result < subList.Count + 1)
                    {
                        result = subList.Count + 1;
                    }
                }
                else
                {
                    subList.Clear();
                }
            }
            return result;
        }
    }
}
