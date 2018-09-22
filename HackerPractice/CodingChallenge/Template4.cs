using System;
using HackerPractice.Model;

namespace HackerPractice.CodingChallenge
{
    public class Template4 : IProblem
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

            var output = Foo(1);
            Utilities.CheckOutput<int>(output, 6);
        }

        /*****************************************************************
        * Procedure: Foo
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public int Foo(int n)
        {

            return 0;
        }
    }
}
