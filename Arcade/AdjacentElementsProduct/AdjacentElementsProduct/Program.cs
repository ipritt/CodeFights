using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacentElementsProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { -23, 4, -3, 8, -12 };
            Console.WriteLine(AdjacentElementsProduct(inputArray));
            Console.ReadLine();
        }

        static int AdjacentElementsProduct(int[] inputArray)
        {
            int product = inputArray[0] * inputArray[1]; 
            int temp;
            for(int i = 0; i < inputArray.Length - 1; i++)
            {
                temp = inputArray[i] * inputArray[i + 1];
                if (temp > product)
                    product = temp;
            }
            return product;
        }
    }
}
