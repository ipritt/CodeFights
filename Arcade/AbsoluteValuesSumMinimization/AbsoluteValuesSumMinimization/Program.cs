using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Given a sorted array of integers a, find an integer x from a such that the value of

//abs(a[0] - x) + abs(a[1] - x) + ... + abs(a[a.length - 1] - x)
//is the smallest possible(here abs denotes the absolute value).
//If there are several possible answers, output the smallest one.

//Example

//For a = [2, 4, 7], the output should be
//absoluteValuesSumMinimization(a) = 4.

//Input/Output

//[execution time limit] 3 seconds(cs)

//[input]
//array.integer a

//A non-empty array of integers, sorted in ascending order.

//Guaranteed constraints:
//1 ≤ a.length ≤ 200,
//-106 ≤ a[i] ≤ 106.

//[output] integer

namespace AbsoluteValuesSumMinimization
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 4, 7 };
            int result = AbsoluteValuesSumMinimization(a);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static int AbsoluteValuesSumMinimization(int[] a)
        {
            int sum = 0;
            List<int> sumList = new List<int>();
            foreach(int x in a)
            {
                foreach (int value in a)
                {
                    sum += Math.Abs(value - x);
                }
                sumList.Add(sum);
                sum = 0;
            }
            return a[sumList.IndexOf(sumList.Min())];
        }
    }
}
