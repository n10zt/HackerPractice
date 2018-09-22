using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Concurrency;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace HackerPractice.Easy
{
    class MarsExploration
    {
        /*****************************************************************
        * Procedure: RunTest
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public void RunTest()
        {
            Console.WriteLine("-----marsExploration-----");

            var output = marsExploration("SOSSPSSQSSOR");
            Utilities.CheckOutput<int>(output, 3);

            output = marsExploration("SOSSOT");
            Utilities.CheckOutput<int>(output, 1);

            output = marsExploration("SOSSOSSOS");
            Utilities.CheckOutput<int>(output, 0);
        }

        /*****************************************************************
        * Procedure: marsExploration
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public int marsExploration(string s)
        {
            //convert to string[]
            var sArray = s.ToCharArray().Select(c => c.ToString()).ToArray();

            var i = 0;
            var output = 0;
            var w = new string[3]; // group string into a 3-letter word

            foreach (var letter in sArray)
            {
                w[i++%3] = letter;

                if (i%3 == 0) // every 3
                {
                    // count received error by comparing to "SOS"
                    output += CountRxError(w);
                }
            }

            return output;
        }

        private int CountRxError(IEnumerable<string> input)
        {
            var keyArray = new[] {"S", "O", "S"};

            return input.Where((t, i) => !t.Equals(keyArray[i])).Count();
        }

        /*
            for (var i = 0; i < input.Length; i++)
            {
                if (!input[i].Equals(keyArray[i])) output++;
            }
         
         */
    }
}

/*
        var array2D = new string[s.Length / 3, 3];
       // 2D array
        for (var r = 0; r < s.Length / 3; r++)
        {
            for (var c = 0; c < 3; c++)
            {
                array2D[r, c] = sArray[i++];
            }

            var y = Enumerable.Range(0, array2D.GetLength(1))
                .Select(a => array2D[r, a])
                .ToArray();

            output += CountRxError(y);
        }



        for (var r = 0; r < s.Length / 3; r++)
        {
            var y = Enumerable.Range(0, array2D.GetLength(1))
                .Select(c => array2D[r, c])
                .ToArray();

            output += CountRxError(y);
        }
//*/

