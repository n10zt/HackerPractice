using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerPractice.Model;

namespace HackerPractice.Examples
{
    public class BubbleSort_
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

            var output = BubbleSort(Utilities.GetIntArray("2 1 5 3 4"));
            Utilities.CheckOutput<int>(output, Utilities.GetIntArray("1 2 3 4 5"));

            output = BubbleSort(Utilities.GetIntArray(ConstHack.ConstStrUnsorted1K));
            Utilities.CheckOutput<int>(output, Utilities.GetIntArray(ConstHack.ConstStrSorted1K));
        }

        /*****************************************************************
        * Procedure: BubbleSort
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public int[] BubbleSort(int[] n)
        {
            bool isSwapped;
            var rollingSortIndex = n.Length;

            do
            {
                isSwapped = false;
                rollingSortIndex--;
                for (var i = 0; i < rollingSortIndex; i++)
                {
                    if (n[i] < n[i + 1]) continue;

                    //Swap
                    var temp = n[i];
                    n[i] = n[i + 1];
                    n[i + 1] = temp;

                    isSwapped = true;
                }
            } while (isSwapped);

            return n;
        }
    }
}
