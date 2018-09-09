using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerPractice.Medium
{
    public class NewYearChaos
    {
        /* for "main"
        //*/

        public string input = "";

        public void minimumBribes(int[] q)
        {
            int output = 0;
            int i = 0;

            while (i < q.Count())
            {
                if (q[i] > i + 3)
                {
                    chaotic();
                    return;
                } // chaotic
                i++;
            }//end While

            bool isSwapped = false;
            int t;
            for (int p = 0; p <= q.Length - 2; p++)
            {
                for (int j = 0; j <= q.Length - 2; j++)
                {
                    if (q[j] > q[j + 1])
                    {
                        t = q[j + 1];
                        q[j + 1] = q[j];
                        q[j] = t;
                        output++;
                        isSwapped = true;
                    }
                }

                if (!isSwapped) break;
                isSwapped = false;
            }

            Console.WriteLine(output);
        }

        public void chaotic()
        {
            Console.WriteLine("Too chaotic");
        }
    }
}
