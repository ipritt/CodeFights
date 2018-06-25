using System;

//Given an array of integers, replace all the occurrences of elemToReplace with substitutionElem.

//Example

//For inputArray = [1, 2, 1], elemToReplace = 1 and substitutionElem = 3, the output should be
//arrayReplace(inputArray, elemToReplace, substitutionElem) = [3, 2, 3].

//Input / Output

//[execution time limit] 3 seconds (cs)

//[input] array.integer inputArray

//Guaranteed constraints:
//2 ≤ inputArray.length ≤ 10,
//0 ≤ inputArray[i] ≤ 10.

//[input] integer elemToReplace

//Guaranteed constraints:
//0 ≤ elemToReplace ≤ 10.

//[input] integer substitutionElem

//Guaranteed constraints:
//0 ≤ substitutionElem ≤ 10.

//[output] array.integer

namespace ArrayReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            int elemToReplace = 1, substitutionElem = 10;
            int[] inputArray = { 1, 1, 1};
            int[] result = ArrayReplace(inputArray, elemToReplace, substitutionElem);
            for(int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
            Console.ReadLine();
        }

        static int[] ArrayReplace(int[] inputArray, int elemToReplace, int substitutionElem)
        {
            for(int i = 0; i < inputArray.Length; i++)
            {
                if(inputArray[i] == elemToReplace)
                {
                    inputArray[i] = substitutionElem;
                }
            }

            return inputArray;
        }
    }
}
