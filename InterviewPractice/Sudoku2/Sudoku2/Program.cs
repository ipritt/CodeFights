using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] grid =
            {
                new char[] {'.', '.', '.', '1', '4', '.', '.', '2', '.'},
                new char[] {'.', '.', '6', '.', '4', '.', '.', '.', '.'},
                new char[] {'.', '.', '.', '.', '.', '.', '.', '.', '.'},
                new char[] {'.', '.', '1', '.', '.', '.', '.', '.', '.'},
                new char[] {'.', '6', '7', '.', '.', '.', '.', '.', '9'},
                new char[] {'.', '.', '.', '.', '.', '.', '8', '1', '.'},
                new char[] {'.', '3', '.', '.', '.', '.', '.', '.', '6'},
                new char[] {'.', '.', '.', '.', '.', '7', '.', '.', '.'},
                new char[] {'.', '.', '.', '5', '.', '.', '.', '7', '.'}
            };
            Console.WriteLine(Sudoku2(grid));
            Console.ReadLine();
        }

        static bool Sudoku2(char[][] grid)
        {
            bool noDuplicate = true;
            for (int outerRow = 0; outerRow < grid.Length; outerRow += 3 )
            {
                for (int outerCol = 0; outerCol < grid.Length; outerCol += 3)
                {
                    Dictionary<char, int> subDict = new Dictionary<char, int>();
                    for (int innerRow = outerRow; innerRow < (3 + outerRow); innerRow++)
                    {
                        for (int innerCol = outerCol; innerCol < (3 + outerCol); innerCol++)
                        {
                            if(grid[innerRow][innerCol] != '.')
                            {
                                if(!subDict.ContainsKey(grid[innerRow][innerCol]))
                                    subDict.Add(grid[innerRow][innerCol], 0);
                                subDict[grid[innerRow][innerCol]]++;
                            }
                        }
                    }
                    foreach(var pair in subDict)
                    {
                        if (pair.Value > 1)
                            noDuplicate = false;
                    }
                }
            }
            for(int row = 0; row < grid.Length; row++)
            {
                Dictionary<char, int> rowDict = new Dictionary<char, int>();
                Dictionary<char, int> colDict = new Dictionary<char, int>();
                for (int col = 0; col < grid.Length; col++)
                {
                    if(grid[row][col] != '.')
                    {
                        if (!rowDict.ContainsKey(grid[row][col]))
                            rowDict.Add(grid[row][col], 1);
                        else
                            noDuplicate = false;
                    }
                    if (grid[col][row] != '.')
                    {
                        if (!colDict.ContainsKey(grid[col][row]))
                            colDict.Add(grid[col][row], 1);
                        else
                            noDuplicate = false;
                    }
                }
            }
            //for(int row = 0; row < grid.Length; row++)
            //{
            //    for (int col = 0; col < grid.Length; col++)
            //    {
            //        if (grid[col][row] != '.')
            //        {
            //            if (!colDict.ContainsKey(grid[col][row]))
            //                colDict.Add(grid[col][row], 1);
            //            else
            //                noDuplicate = false;
            //        }
            //    }
            //}
            return noDuplicate;
        }
    }
}
