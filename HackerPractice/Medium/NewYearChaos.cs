using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerPractice.Model;

namespace HackerPractice.Medium
{
    public class NewYearChaos
    {
        private const string _chaotic = "Too chaotic";

        /*****************************************************************
        * Procedure: RunTest
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public void RunTest()
        {
            Console.WriteLine("-----minimumBribes-----");

            string output;
            output = minimumBribes(Utilities.GetIntArray("2 1 5 3 4"));
            Utilities.CheckOutput<string>(output, "3");

            output = minimumBribes(Utilities.GetIntArray("2 5 1 3 4"));
            Utilities.CheckOutput<string>(output, _chaotic);

            output = minimumBribes(Utilities.GetIntArray("5 1 2 3 7 8 6 4"));
            Utilities.CheckOutput<string>(output, _chaotic);

            output = minimumBribes(Utilities.GetIntArray("1 2 5 3 7 8 6 4"));
            Utilities.CheckOutput<string>(output, "7");

            output = minimumBribes(Utilities.GetIntArray("1 2 5 3 4 7 8 6"));
            Utilities.CheckOutput<string>(output, "4");

            output = minimumBribes(Utilities.GetIntArray(ConstHack.ConstStrUnsorted1K));
            Utilities.CheckOutput<string>(output, "966");
        }


        /*****************************************************************
        * Procedure: minimumBribes
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public string minimumBribes(int[] q)
        {
            var output = 0;

            //Bubble sort
            bool isSwapped;
            var sortIndexLimit = q.Length;

            do
            {
                isSwapped = false;
                sortIndexLimit--;
                for (var j = 0; j < sortIndexLimit; j++)
                {
                    if (q[j] > j + 3) return _chaotic;

                    if (q[j] <= q[j + 1]) continue;

                    // left > right therefore swap
                    var t = q[j + 1];
                    q[j + 1] = q[j];
                    q[j] = t;

                    output++; // increment counter
                    isSwapped = true; // indicate at least one swap in the loop
                }
            } while (isSwapped);

            //Console.WriteLine(output);
            return output.ToString();
        }

        public void chaotic()
        {
            Console.WriteLine(_chaotic);
        }
    }
}
