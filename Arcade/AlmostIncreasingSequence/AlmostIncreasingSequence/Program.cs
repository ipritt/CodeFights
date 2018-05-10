using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmostIncreasingSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = { 10, 1, 2, 3, 4, 5 };
            Console.WriteLine(AlmostIncreasingSequence(sequence));
            Console.ReadLine();
        }

        static bool AlmostIncreasingSequence(int[] sequence)
        {
            int count = 0;
            List<int> list = sequence.ToList();
            for(int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] >= sequence[i + 1])
                {
                    count++;
                    if (i != 0 && sequence[i + 1] <= sequence[i - 1])
                        list.RemoveAt(i + 1);
                    else
                        list.RemoveAt(i);
                    break;
                }
            }
            for(int j = 0; j < list.Count - 1; j++)
            {
                if (list[j] >= list[j + 1])
                    count++;
            }
            return count <= 1;
        }
    }
}
