using System;
using System.Collections.Generic;
using HackerPractice.Model;

namespace HackerPractice.CodingChallenge
{
    public class Template3 : IProblem
    {
        /*****************************************************************
        * Procedure: RunTest
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public void RunTest()
        {
            Console.WriteLine("-----Foo-----");

            int output;

            output = CountChange(10, Utilities.GetIntArray("5 2 3"));

            /*
            output = CountChange(4, Utilities.GetIntArray("1 2"));
            Utilities.CheckOutput<int>(output, 3);

            output = CountChange(10, Utilities.GetIntArray("5 2 3"));
            Utilities.CheckOutput<int>(output, 4);

            output = CountChange(11, Utilities.GetIntArray("5 7"));
            Utilities.CheckOutput<int>(output, 0);
            //*/
        }

        /*****************************************************************
        * Procedure: Foo
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public int CountChange(int money, int[] coins)
        {
            //PrintAllWaysToMakeChange(money, 0, new List<int>(), coins);
            PrintAllWaysToMakeChange(money, 0, string.Empty, coins);

            return 0;
        }

        private static void PrintAllWaysToMakeChange(int sumSoFar, int minBill, string changeSoFar, IReadOnlyList<int> bills)
        {
            Console.WriteLine("------------------------------Function Entry-----------------------");
            Console.WriteLine("minBill = " + minBill);

            for (var i = minBill; i < bills.Count; i++)
            {
                var change = changeSoFar;
                var sum = sumSoFar;
                Console.WriteLine("change = " + change);
                Console.WriteLine("sum = " + sum);

                while (sum > 0)
                {
                    if (!string.IsNullOrEmpty(change))
                        change += " + ";

                    change += bills[i];
                    Console.WriteLine("bills[{0}]={1}",i, bills[i]);

                    sum -= bills[i];
                    if (sum > 0)
                    {
                        Console.WriteLine("PrintAllWaysToMakeChange({0},{1},'{2}')",sum, i+1, change);
                        PrintAllWaysToMakeChange(sum, i + 1, change, bills);
                        Console.WriteLine("***************After recurssion***************");
                    }

                    if (sum < 0)
                    {
                        Console.WriteLine("%%%%% Failed change = " + change);
                    }
                }

                if (sum == 0)
                {
                    Console.WriteLine("\t\t\t-----" + change);
                }
            }
            Console.WriteLine("##### End of for() loop");
        }

    }
}

/*
            // base case 
            if (money == 0) return 0;

            // Initialize result 
            int res = int.MaxValue;

            // Try every coin that has 
            // smaller value than V 
            for (int i = 0; i < coins.Length; i++)
            {
                if (coins[i] <= money)
                {
                    int sub_res = CountChange(money - coins[i], coins);

                    // Check for INT_MAX to  
                    // avoid overflow and see  
                    // if result can minimized 
                    if (sub_res != int.MaxValue &&
                        sub_res + 1 < res)
                        res = sub_res + 1;
                }
            }

            return res;
 
*/
