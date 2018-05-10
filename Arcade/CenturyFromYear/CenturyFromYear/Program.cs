using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturyFromYear
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 2005;
            Console.WriteLine(CenturyFromYear(year));
            Console.ReadLine();
        }

        static int CenturyFromYear(int year)
        {
            int cent = year / 100;
            int temp = year % 100;
            if (temp > 0)
                cent += 1;
            return cent;
        }
    }
}
