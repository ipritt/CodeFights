using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsLucky
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1230;
            Console.WriteLine(IsLucky(n));
            Console.ReadLine();
        }

        static bool IsLucky(int n)
        {
            bool isLucky = false;
            string strToSlit = n.ToString();
            string str1 = "", str2 = "";
            int sum1 = 0, sum2 = 0;
            for (int i = 0; i < strToSlit.Length / 2; i++)
                str1 += strToSlit[i];
            for (int i = strToSlit.Length / 2; i < strToSlit.Length; i++)
                str2 += strToSlit[i];
            foreach (char value in str1)
                sum1 += Convert.ToInt32(value);
            foreach (char value in str2)
                sum2 += Convert.ToInt32(value);
            if (sum1 == sum2)
                isLucky = true;
            return isLucky;
        }
    }
}
