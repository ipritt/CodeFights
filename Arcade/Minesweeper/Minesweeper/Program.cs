using System;

//In the popular Minesweeper game you have a board with some mines and those cells that don't contain a mine have a number in it that indicates the total number of mines in the neighboring cells. Starting off with some arrangement of mines we want to create a Minesweeper game setup.

//Example

//For

//matrix = [[true, false, false],
//          [false, true, false],
//          [false, false, false]]
//the output should be

//minesweeper(matrix) = [[1, 2, 1],
//                       [2, 1, 1],
//                       [1, 1, 1]]       

//Input/Output

//[execution time limit] 3 seconds(cs)

//[input]
//array.array.boolean matrix

//A non-empty rectangular matrix consisting of boolean values - true if the corresponding cell contains a mine, false otherwise.

//Guaranteed constraints:
//2 ≤ matrix.length ≤ 5,
//2 ≤ matrix[0].length ≤ 5.

//[output]
//array.array.integer

//Rectangular matrix of the same size as matrix each cell of which contains an integer equal to the number of mines in the neighboring cells.Two cells are called neighboring if they share at least one corner.

namespace Minesweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[][] matrix = new bool[3][];
            matrix[0] = new bool[] { true, false, false, true };
            matrix[1] = new bool[] { false, false, true, false };
            matrix[2] = new bool[] { true, true, false, true };

            int[][] result = Minesweeper(matrix);
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

        static int[][] Minesweeper(bool[][] matrix)
        {
            //  Create and init int array to be returned
            int[][] array = new int[matrix.Length][];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = new int[matrix[0].Length];
            }
            //  intialize it with zeros
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array[0].Length; j++)
                {
                    array[i][j] = 0;
                }
            }
            //  Create buffer array that will have all false values around the edges
            //  this takes care of the edge cases
            bool[][] bufferArray = new bool[matrix.Length + 2][];
            for(int i = 0; i < bufferArray.Length; i++)
            {
                bufferArray[i] = new bool[matrix[0].Length + 2];
            }
            //  First init with all false values
            for(int i = 0; i < bufferArray.Length; i++)
            {
                for(int j = 0; j < bufferArray[0].Length; j++)
                {
                    bufferArray[i][j] = false;
                }
            }
            //  Then load values from matrix array inside the edges
            for(int i = 1; i <= matrix.Length; i++)
            {
                for(int j = 1; j <= matrix[0].Length; j++)
                {
                    bufferArray[i][j] = matrix[i - 1][j - 1];
                }
            }
            //  Iterate through bufferArray to find the true values and
            //  and load the int array
            for(int i = 1; i <= matrix.Length; i++)
            {
                for(int j = 1; j <= matrix[0].Length; j++)
                {
                    if (bufferArray[i - 1][j - 1] == true)
                        array[i - 1][j - 1] += 1;
                    if (bufferArray[i - 1][j] == true)
                        array[i - 1][j - 1] += 1;
                    if (bufferArray[i - 1][j + 1] == true)
                        array[i - 1][j - 1] += 1;
                    if (bufferArray[i][j + 1] == true)
                        array[i - 1][j - 1] += 1;
                    if (bufferArray[i + 1][j + 1] == true)
                        array[i - 1][j - 1] += 1;
                    if (bufferArray[i + 1][j] == true)
                        array[i - 1][j - 1] += 1;
                    if (bufferArray[i + 1][j - 1] == true)
                        array[i - 1][j - 1] += 1;
                    if (bufferArray[i][j - 1] == true)
                        array[i - 1][j - 1] += 1;
                }
            }
            return array;
        }
    }
}
