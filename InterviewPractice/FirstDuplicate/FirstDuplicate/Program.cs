using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 4, 2, 2, 3, 6, 5, 1 };
            Console.WriteLine(FirstDuplicate(array)); 
            Console.ReadLine();
        }
        
        static int FirstDuplicate(int[] a)
        {
            Dictionary<int, int> valuePairs = new Dictionary<int, int>();
            for(int i = 0; i < a.Length; i++)
            {
                for(int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                        valuePairs[j] = a[j];
                }
            }
            
            if (valuePairs != null)
                return valuePairs[valuePairs.Select(item => item.Key).Min()];
            else
                 return -1;
        }
    }
}
