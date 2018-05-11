using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
An IP address is a numerical label assigned to each device (e.g., computer, printer) participating in a computer network that uses the Internet Protocol for communication. There are two versions of the Internet protocol, and thus two versions of addresses. One of them is the IPv4 address.

IPv4 addresses are represented in dot-decimal notation, which consists of four decimal numbers, each ranging from 0 to 255 inclusive, separated by dots, e.g., 172.16.254.1.

Given a string, find out if it satisfies the IPv4 address naming rules.

Example

For inputString = "172.16.254.1", the output should be
isIPv4Address(inputString) = true;

For inputString = "172.316.254.1", the output should be
isIPv4Address(inputString) = false.

316 is not in range [0, 255].

For inputString = ".254.255.0", the output should be
isIPv4Address(inputString) = false.

There is no first number.

Input/Output

[execution time limit] 3 seconds (cs)

[input] string inputString

Guaranteed constraints:
1 ≤ inputString.length ≤ 30.

[output] boolean

true if inputString satisfies the IPv4 address naming rules, false otherwise.
*/

namespace IsIPv4Address
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "255.255.255.255abcdekjhf";
            Console.WriteLine(IsIPv4Address(inputString));
            Console.ReadLine();
        }

        static bool IsIPv4Address(string a)
        {
            bool isIPv4 = true;
            string[] subStrings = a.Split('.');
            if (subStrings.Length != 4)
            {
                isIPv4 = false;
            }
            else
            {
                foreach (string item in subStrings)
                {
                    try
                    {
                        if (Convert.ToInt32(item) < 0 || Convert.ToInt32(item) > 255)
                        {
                            isIPv4 = false;
                        }
                    }
                    catch
                    {
                        isIPv4 = false;
                    }
                }
            }
            return isIPv4;
        }
    }
}
