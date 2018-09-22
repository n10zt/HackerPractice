using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerPractice.CodeWars
{
    public class TribonacciSequence
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

            var output = Tribonacci(Utilities.GetDoubleArray("1 1 1"), 8);
            Utilities.CheckOutput<double>(output, Utilities.GetDoubleArray("1 1 1"));
        }

        /*****************************************************************
        * Procedure: Tribonacci
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public double[] Tribonacci(double[] signature, int n)
        {

            return new double[1];
        }
    }
}
