using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerPractice.Easy
{
    public class BreakingTheRecords
    {
        /* for "main"
            var tester = new BreakingTheRecords();

            var output = tester.breakingRecords(Utilities.GetIntArray(tester.a));
            Utilities.PrintArray(output); //2 4
            output = tester.breakingRecords(Utilities.GetIntArray(tester.b));
            Utilities.PrintArray(output); //4 0
            output = tester.breakingRecords(Utilities.GetIntArray(tester.c));
            Utilities.PrintArray(output); //1 1
        //*/

        public string a = "10 5 20 20 4 5 2 25 1";
        public string b = "3 4 21 36 10 28 35 5 24 42";
        public string c = "12 24 10 24";

        public int[] breakingRecords(int[] scores)
        {
            int mostCounter=0, leastCounter=0;
            int mostRecord = 0, leastRecord = 0;

            mostRecord = scores[0];
            leastRecord = scores[0];

            for (var i=1; i<scores.Length; i++)
            {
                if (scores[i] > mostRecord)
                {
                    mostRecord = scores[i];
                    mostCounter++;
                }
                else if (scores[i]<leastRecord)
                {
                    leastRecord = scores[i];
                    leastCounter++;
                }
            }

            int[] output = {mostCounter, leastCounter};

            return output;
        }
    }
}
