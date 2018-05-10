using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixElementsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix =
            {
                new int[] { 0, 1, 1, 2 },
                new int[] { 0, 5, 0, 0 },
                new int[] { 2, 0, 3, 3 },
            };
            Console.WriteLine(MatrixElementsSum(matrix));
            Console.ReadLine();
        }
        static int MatrixElementsSum(int[][] matrix)
        {
            int cost = 0;
            for (int rows = 0; rows < matrix[0].Length; rows++)
            {
                for (int cols = 0; cols < matrix.Length; cols++)
                {
                    if (matrix[cols][rows] == 0)
                        break;
                    else
                        cost += matrix[cols][rows];
                }
             }
            return cost;
        }
    }
}
