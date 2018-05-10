using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            Console.WriteLine(ShapeArea(n));
            Console.ReadLine();
        }

        static int ShapeArea(int n)
        {
            return ((int)Math.Pow(n, 2) + (int)Math.Pow(n - 1, 2));
        }
    }
}
