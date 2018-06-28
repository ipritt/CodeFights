using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardCellColor
{
    class Program
    {
        static void Main(string[] args)
        {
            string cell1 = "A1", cell2 = "C3";
            bool sameColor = ChessBoardCellColor(cell1, cell2);
            Console.WriteLine(sameColor);
            Console.ReadLine();
        }

        static bool ChessBoardCellColor(string cell1, string cell2)
        {
            string[][] colors = new string[8][];
            string color = "white";
            int[] cell1Alpha = new int[8];
            Dictionary<string, string> cellColors = new Dictionary<string, string>();
            for(int i = 0; i < colors.Length; i++)
            {
                colors[i] = new string[8];
            }
            for(int i = 0; i < 8; i++)
            {
                color = Flip(color);
                for (int j = 0; j < 8; j++)
                {
                    colors[i][j] = color;
                    color = Flip(color);
                }
            }
            int x = 0;
            int y = 0;
            for(char alpha = 'A'; alpha <= 'H'; alpha++)
            {
                for(char num = '1'; num <= '8'; num++)
                {
                    string cell = alpha.ToString() + num.ToString();
                    cellColors.Add(cell, colors[x][y]);
                    y++;
                }
                y = 0;
                x++;
            }
            string cell1Color = cellColors[cell1];
            return (cell1Color == cellColors[cell2]) ? true : false;
        }

        private static string Flip(string color)
        {
            if (color == "black")
            {
                color = "white";
            }
            else
            {
                color = "black";
            }
            return color;
        }
    }
}
