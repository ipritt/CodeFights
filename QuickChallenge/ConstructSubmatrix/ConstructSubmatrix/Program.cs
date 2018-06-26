using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Given a matrix(i.e.an array of arrays), find its submatrix obtained by deleting the specified rows and columns.

//Example

//For

//matrix = [[1, 0, 0, 2], 
//          [0, 5, 0, 1], 
//          [0, 0, 3, 5]]
//rowsToDelete = [1] and columnsToDelete = [0, 2], the output should be

//constructSubmatrix(matrix, rowsToDelete, columnsToDelete) = [[0, 2],
//                                                             [0, 5]]
//Input/Output

//[execution time limit] 3 seconds(cs)

//[input]
//array.array.integer matrix

//2-dimensional array of integers.

//Guaranteed constraints:
//1 ≤ matrix.length ≤ 5,
//1 ≤ matrix[0].length ≤ 5,
//0 ≤ matrix[i][j] ≤ 15.

//[input] array.integer rowsToDelete

//Array of indices (0-based) of rows to be deleted.

//Guaranteed constraints:
//0 ≤ rowsToDelete.length ≤ 2,
//0 ≤ rowsToDelete[i] < matrix.length.

//[input] array.integer columnsToDelete

//Array of indices (0-based) of columns to be deleted.

//Guaranteed constraints:
//0 ≤ columnsToDelete.length ≤ 2,
//0 ≤ columnsToDelete[i] < matrix[0].length.

//[output] array.array.integer

namespace ConstructSubmatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsToDelete = { 1 };
            int[] columnsToDelete = { 0, 2 };
            int[][] matrix = 
            {
                new int[] { 1, 0, 0, 2 },
                new int[] { 0, 5, 0, 1 },
                new int[] { 0, 0, 3, 5 }
            };
            int[][] result = ConstructSubmatrix(matrix, rowsToDelete, columnsToDelete);
            for(int i = 0; i < result.Length; i++)
            {
                for(int j = 0; j < result[0].Length; j++)
                {
                    Console.Write(result[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static int[][] ConstructSubmatrix(int[][] matrix, int[] rowsToDelete, int[] columnsToDelete)
        {
            int listCount = 0;
            List<int> intList = new List<int>();
            int[][] result = new int[matrix.Length - rowsToDelete.Length][];
            for(int i = 0; i < result.Length; i++)
            {
                result[i] = new int[matrix[0].Length - columnsToDelete.Length];
            }
            for(int i = 0; i < matrix.Length; i++)
            {
                for(int j = 0; j < matrix[0].Length; j++)
                {
                    if(!(rowsToDelete.Contains(i) || columnsToDelete.Contains(j)))
                    {
                        intList.Add(matrix[i][j]);
                    }
                }
            }
            for(int i = 0; i < result.Length; i++)
            {
                for(int j = 0; j < result[0].Length; j++)
                {
                    result[i][j] = intList[listCount];
                    listCount++;
                }
            }
            return result;
        }
    }
}
