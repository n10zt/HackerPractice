using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerPractice.Model;

namespace HackerPractice.CodeWars
{
    public class CountBits_ : IProblem
    {
        /*****************************************************************
        * Procedure: RunTest
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public void RunTest()
        {
            Console.WriteLine("-----CountBits-----");

            var output = CountBits(7);
            Utilities.CheckOutput<int>(output, 3);
        }

        /*****************************************************************
        * Procedure: CountBits
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public int CountBits(int n)
        {
            var s = Convert.ToString(n, 2) //Convert to binary in a string
                .Select(c => int.Parse(c.ToString())) // convert each char to int
                .ToArray(); // Convert IEnumerable from select to Array

            return s.Sum();
        }
    }
}
