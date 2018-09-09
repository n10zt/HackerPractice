using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerPractice.Easy
{
    public class BirthdayCC //Cake Candle
    {
        /* for "main"
        var tester = new BirthdayCC();

        Input1.Text = tester.birthdayCakeCandles(Utilities.GetIntArray(tester.input)).ToString();
        //*/

        public string input = "3 2 1 3";

        public int birthdayCakeCandles(int[] ar)
        {
            int tallest = 0;
            int counter = 0;

            for (var i=0; i<ar.Length; i++)
            {
                if (i == 0)
                {
                    tallest = ar[i];
                    counter++;
                }
                else if (ar[i] > tallest)
                {
                    tallest = ar[i];
                    counter = 1;
                }
                else if (ar[i] == tallest)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}