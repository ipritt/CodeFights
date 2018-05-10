using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeArrayConsecutive2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] statues = { 6, 2, 3, 8 };
            Console.WriteLine(MakeArrayConsecutive2(statues));
            Console.ReadLine();
        }

        static int MakeArrayConsecutive2(int[] statues)
        {
            int count = 0;
            Array.Sort(statues);
            for(int i = 0; i < statues.Length - 1; i++)
            {
                if (statues[i + 1] - statues[i] != 1)
                    count += (statues[i + 1] - 1) - statues[i];
            }
            return count;
        }
    }
}
