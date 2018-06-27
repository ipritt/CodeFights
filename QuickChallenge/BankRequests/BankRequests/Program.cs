using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//You've been asked to program a bot for a popular bank that will automate the management of incoming requests. There are three types of requests the bank can receive:

//transfer i j sum: request to transfer sum amount of money from the ith account to the jth one;
//deposit i sum: request to deposit sum amount of money in the ith account;
//withdraw i sum: request to withdraw sum amount of money from the ith account.
//Your bot should also be able to process invalid requests.There are two types of invalid requests:

//invalid account number in the requests;
//deposit / withdrawal of a larger amount of money than is currently available.
//For the given list of accounts and requests, return the state of accounts after all requests have been processed, 
//or an array of a single element[-< request_id >] (please note the minus sign), where<request_id> is the 1-based index of the first invalid request.

//Example

//For accounts = [10, 100, 20, 50, 30]
//and
//requests = ["withdraw 2 10", "transfer 5 1 20", "deposit 5 20", "transfer 3 4 15"],
//the output should be bankRequests(accounts, requests) = [30, 90, 5, 65, 30].

//Here are the states of accounts after each request:

//"withdraw 2 10": [10, 90, 20, 50, 30];
//"transfer 5 1 20": [30, 90, 20, 50, 10];
//"deposit 5 20": [30, 90, 20, 50, 30];
//"transfer 3 4 15": [30, 90, 5, 65, 30], which is the answer.
//For accounts = [20, 1000, 500, 40, 90] and
//requests = ["deposit 3 400", "transfer 1 2 30", "withdraw 4 50"],
//the output should be bankRequests(accounts, requests) = [-2].


//After the first request, accounts becomes equal to [20, 1000, 900, 40, 90], but the second one turns it into[-10, 1030, 900, 40, 90], 
//which is invalid.Thus, the second request is invalid, and the answer is [-2]. Note that the last request is also invalid, 
//but it shouldn't be included in the answer.


//Input/Output

//[execution time limit] 3 seconds (cs)

//[input] array.integer accounts


//Array of integers, where accounts[i] is the amount of money in the (i + 1)th account.

//Guaranteed constraints:
//0 < accounts.length ≤ 100,
//0 ≤ accounts[i] ≤ 105.


//[input] array.string requests


//Array of requests in the order they should be processed. Each request is guaranteed to be in the format described above.
//It is guaranteed that for each i and j in a request 0 < i, j ≤ 1000.


//Guaranteed constraints:
//0 < requests.length ≤ 100,
//for each i, j and sum in each element of request:

//0 < i ≤ 1000,
//0 < j ≤ 1000,
//0 ≤ sum ≤ 105.
//[output] array.integer

//The accounts after executing all of the requests or array with a single integer - the index of the first invalid request preceded by -.

namespace BankRequests
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] accounts = { 77367, 85558, 88570, 98242, 46552, 2772, 64226, 72128, 15176, 93254 };
            string[] requests = { "deposit 11 6",
 "transfer 2 6 91",
 "deposit 10 58",
 "transfer 5 3 49",
 "withdraw 8 40",
 "withdraw 6 67",
 "transfer 7 6 44",
 "withdraw 5 7",
 "transfer 8 2 20",
 "transfer 9 2 94"
                                };
            int[] result = BankRequests(accounts, requests);
            foreach(int value in result)
            {
                Console.Write(value);
                Console.Write(' ');
            }
            Console.ReadLine();
        }

        static int[] BankRequests(int[] accounts, string[] requests)
        {
            int error = 0;
            for(int i = 0; i < requests.Length; i++)
            {
                string[] request = requests[i].Split(' ');
                if(request[0] == "withdraw")
                {
                    int acct = Int32.Parse(request[1]);
                    int amt = Int32.Parse(request[2]);
                    if (acct - 1 < accounts.Length && accounts[acct - 1] - amt >= 0)
                    {
                        accounts[acct - 1] -= amt;
                    }
                    else
                    {
                        error = (i + 1) * -1;
                        break;
                    }
                }
                if(request[0] == "deposit")
                {
                    int acct = Int32.Parse(request[1]);
                    int amt = Int32.Parse(request[2]);
                    if(acct - 1 < accounts.Length)
                    {
                        accounts[acct - 1] += amt;
                    }
                    else
                    {
                        error = (i + 1) * -1;
                    }
                }
                if(request[0] == "transfer")
                {
                    int acctFrom = Int32.Parse(request[1]);
                    int acctTo = Int32.Parse(request[2]);
                    int amt = Int32.Parse(request[3]);
                    if(acctTo - 1 < accounts.Length && accounts[acctFrom - 1] - amt >= 0)
                    {
                        accounts[acctFrom - 1] -= amt;
                        accounts[acctTo - 1] += amt;
                    }
                    else
                    {
                        error = (i + 1) * -1;
                        break;
                    }
                }
            }
            if(error == 0)
            {
                return accounts;
            }
            else
            {
                return new int[] { error };
            }
        }
    }
}
