using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerPractice.Easy
{
    public class UtopianTree
    {
        /*****************************************************************
        * Procedure: RunTest
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public void RunTest()
        {
            int output = 0;

            output = utopianTree(5);
            Utilities.CheckOutput<int>(output, 14);

            output = utopianTree(0);
            Utilities.CheckOutput<int>(output, 1);

            output = utopianTree(1);
            Utilities.CheckOutput<int>(output, 2);

            output = utopianTree(4);
            Utilities.CheckOutput<int>(output, 7);
        }

        /*
         * Spring - double
         * Summer - +1 meter
         * 
         * /

        /*****************************************************************
        * Procedure: utopianTree
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public int utopianTree(int n) // 0 <= n <= 60
        {
            if (n < 0 || n > 60) return -1;

            if (n == 0) return 1;

            int output = 1; // initial height

            for (var i = 1; i <= n; i++)
            {
                if (i % 2 == 1)
                {
                    output *= 2;
                }
                else
                {
                    output += 1;
                }
                //Console.WriteLine("i=" + i + " --> " + output);
            }

            return output;
        }
    }
}
