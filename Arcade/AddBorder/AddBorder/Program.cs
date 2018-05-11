using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Given a rectangular matrix of characters, add a border of asterisks(*) to it.

Example

For

picture = ["abc",
           "ded"]
the output should be

addBorder(picture) = ["*****",
                      "*abc*",
                      "*ded*",
                      "*****"]
Input/Output

[execution time limit] 3 seconds (cs)

[input] array.string picture

A non-empty array of non-empty equal-length strings.

Guaranteed constraints:
1 ≤ picture.length ≤ 100,
1 ≤ picture[i].length ≤ 100.

[output] array.string

The same matrix of characters, framed with a border of asterisks of width 1. 
*/

namespace AddBorder
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] picture = { "a" };
            string[] result = AddBorder(picture);
            foreach(string item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        static string[] AddBorder(string[] picture)
        {
            string[] result = new string[picture.Length + 2];
            StringBuilder TopBottomBorders = new StringBuilder();
            StringBuilder ItemBorders = new StringBuilder();
            for (int i = 0; i < picture[0].Length + 2; i++)
            {
                TopBottomBorders.Append("*");
            }
            for (int i = 0; i < result.Length; i++)
            {
                if (i == 0 || i == result.Length - 1)
                {
                    result[i] = TopBottomBorders.ToString();
                }
                else
                {
                    ItemBorders.Clear();
                    ItemBorders.Insert(0, "*");
                    ItemBorders.Insert(1, picture[i - 1]);
                    ItemBorders.Insert(picture[0].Length + 1, "*");
                    result[i] = ItemBorders.ToString();
                }
            }
            return result;
        }
    }
}
