using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerPractice.Easy
{
    public class PickingNumbers
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

            output = pickingNumbers(Utilities.GetIntArray("4 6 5 3 3 1"));
            Utilities.CheckOutput(output, 3);

            output = pickingNumbers(Utilities.GetIntArray("1 2 2 3 1 2"));
            Utilities.CheckOutput(output, 5);

            output = pickingNumbers(Utilities.GetIntArray("1 2 2 3 3 3 8 10"));
            Utilities.CheckOutput(output, 5);

            output = pickingNumbers(Utilities.GetIntArray("1 2 2 2 2 4 5 7 9"));
            Utilities.CheckOutput(output, 5);

            output = pickingNumbers(Utilities.GetIntArray("1 2 2 2 4 4 5 5 5 5 7 8"));
            Utilities.CheckOutput(output, 6);
        }

        /*****************************************************************
        * Procedure: pickingNumbers
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public int pickingNumbers(int[] a)
        {
            //Bubble sort
            bool isSwapped = false;
            int t;
            for (int p = 0; p <= a.Length - 2; p++)
            {
                for (int j = 0; j <= a.Length - 2; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        t = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = t;
                        isSwapped = true;
                    }
                }

                if (!isSwapped) break;
                isSwapped = false;
            }

            int k = 0;
            int baseNum = 0, wingNum = 0;
            int[] container = new int[100];

            //initialize
            container[k] += 1;
            baseNum = a[k];
            wingNum = a[k];

            for (var i = 1; i < a.Length; i++)
            {
                if (a[i]-baseNum > 1)
                {
                    k++;
                    if (wingNum > baseNum)
                    {
                        container[k + 1] += 1;
                        baseNum = wingNum;
                        wingNum = a[i];
                    }
                    else
                    {
                        baseNum = a[i];
                        wingNum = a[i];
                    }
                }
                else if (a[i]-baseNum == 1)
                {
                    wingNum = a[i];
                    container[k+1] += 1;
                }

                container[k] += 1;
            }

            return container.Max();
        }
    }
}
