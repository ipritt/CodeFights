using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortByHeight
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { -1, 150, 190, -1, -1, 160, 180 };
            Console.WriteLine(SortByHeight(a));
            Console.ReadLine();
        }

        static int[] SortByHeight(int[] a)
        {
            int[] newArray = new int[a.Length];
            List<int> list = new List<int>();
            List<int> treeList = new List<int>();
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] == -1)
                    treeList.Add(i);
            }
            foreach(int value in a)
            {
                if (value != -1)
                    list.Add(value);
            }
            list.Sort();
            foreach(int value in treeList)
                list.Insert(value, -1);
            newArray = list.ToArray();
            return newArray;
        }
    }
}
