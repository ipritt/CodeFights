using System;

//Correct variable names consist only of English letters, digits and underscores and they can't start with a digit.

//Check if the given string is a correct variable name.

//Example

//For name = &quot; var_1__Int&quot;, the output should be
//variableName(name) = true;
//For name = &quot; qq-q&quot;, the output should be
//variableName(name) = false;
//For name = &quot;2w2&quot;, the output should be
//variableName(name) = false.
//Input/Output

//[execution time limit] 3 seconds(cs)

//[input]
//string name

//Guaranteed constraints:
//1 ≤ name.length ≤ 10.

//[output] boolean

//true if name is a correct variable name, false otherwise.

namespace VariableName
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "var_1__Int";
            bool validVariable = VariableName(name);
            Console.WriteLine(validVariable);
            Console.ReadLine();
        }

        static bool VariableName(string name)
        {
            bool isValid = true;
            if (name[0] >= '0' && name[0] <= '9')
            {
                isValid = false;
            }
            foreach (char value in name)
            {
                if(!(value >= 'a' && value <= 'z' || value >= 'A' && value <= 'Z'))
                {
                    isValid = false;
                    break;
                }
                else if(!(value >= '0' && value <= '9'))
                {
                    isValid = false;
                    break;
                }
                else if(!(value == '_'))
                {
                    isValid = false;
                    break;
                }
            }
            return isValid;
        }
    }
}
