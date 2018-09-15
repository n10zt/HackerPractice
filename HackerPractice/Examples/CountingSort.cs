using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerPractice.Examples
{
    public class CountingSort
    {
        /*****************************************************************
        * Procedure: RunTest
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public void RunTest()
        {
            Console.WriteLine("-----CountingSort-----");
            var output = countingSort(Utilities.GetIntArray("2 5 -4 11 0 8 22 67 51 6"));
            Utilities.CheckOutput<int>(output, Utilities.GetIntArray("-4 0 2 5 6 8 11 22 51 67"));
        }

        /*****************************************************************
        * Procedure: Foo
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public int[] countingSort(int[] array)
        {
            //*
            Console.WriteLine("Input: ");
            foreach (int aa in array)
                Console.Write(aa + " ");
            //*/

            int[] sortedArray = new int[array.Length];

            // find smallest and largest value
            int minVal = array.Min();
            int maxVal = array.Max();

            // init array of frequencies - Histogram
            int[] counts = new int[maxVal - minVal + 1];

            // init the frequencies
            for (int i = 0; i < array.Length; i++)
            {
                counts[array[i] - minVal]++;
            }

            // recalculate
            counts[0]--;
            for (int i = 1; i < counts.Length; i++)
            {
                counts[i] += counts[i - 1];
            }

            // Sort the array
            for (int i = 0; i < array.Length; i++)
            {
                var buff = array[i] - minVal;
                var countN = counts[buff];
                sortedArray[countN] = array[i];
            }
            /*
            for (int i = array.Length - 1; i >= 0; i--)
            {
                var buff = array[i] - minVal;
                var countN = counts[buff];
                sortedArray[countN] = array[i];
            }
            //*/

            return sortedArray;
        }
    }
}
