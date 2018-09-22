using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerPractice.Medium;

namespace HackerPractice.Easy
{
    public class TwoCharacters
    {
        /*****************************************************************
        * Procedure: RunTest
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public void RunTest()
        {
            Console.WriteLine("-----alternate-----");

            var output = alternate("beabeefeab");
            Utilities.CheckOutput<int>(output, 5);
        }

        /*****************************************************************
        * Procedure: alternate
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public int alternate(string s)
        {
            var sArray = s.ToCharArray().Select(c => c.ToString()).ToArray();

            var distinct = sArray.Distinct(); // distinct.Count = n in Combinations Formula




            return 0;
        }


    }
}
