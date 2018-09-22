using System;
using HackerPractice.Model;

namespace HackerPractice.CodingChallenge
{
    public class Template1 : IProblem
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

            var output = FizzBuzz(9);
            Utilities.CheckOutput<string>(output, "");
        }

        /*****************************************************************
        * Procedure: Foo
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public string FizzBuzz(int n)
        {
            if (n < 1) return "Invalid";

            var output = string.Empty;

            for (var i = 1; i <= n; i++)
            {
                var isMult3 = i % 3 == 0;
                var isMult5 = i % 5 == 0;

                if (isMult3 && isMult5)
                {
                    output += "FizzBuzz";
                }
                else if (isMult3)
                {
                    output += "Fizz";
                }
                else if (isMult5)
                {
                    output += "Buzz";
                }
                else
                {
                    output += i.ToString();
                }

                if (i < n)
                {
                    output += "\n";
                }

            }

            return output;
        }
    }
}
