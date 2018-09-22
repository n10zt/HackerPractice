using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerPractice.Model;

namespace HackerPractice.Examples
{
    public class QuickSort2
    {
        /*****************************************************************
        * Procedure: RunTest
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public void RunTest()
        {
            Console.WriteLine("-----QuickSort-----");

            int[] x;
            x = Utilities.GetIntArray("1 5 4 11 20 8 2 98 90 16");
            var output = QuickSort(x, 0, x.Length - 1);
            Utilities.CheckOutput<int>(output, Utilities.GetIntArray(ConstHack.ConstStrSorted1K));

            /*
            x = Utilities.GetIntArray(ConstHack.ConstStrUnsorted1K);
            output = QuickSort(x, 0, x.Length - 1);
            Utilities.CheckOutput<int>(output, Utilities.GetIntArray(ConstHack.ConstStrSorted1K));
            //*/
        }

        /*****************************************************************
        * Procedure: QuickSort
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        private int[] QuickSort(int[] arr, int start, int end)
        {
            int i;
            if (start < end)
            {
                i = Partition(arr, start, end);
                Console.WriteLine("i={0} start={1} end={2}", i, start, end);

                QuickSort(arr, start, i - 1);
                Console.WriteLine("QuickSort(arr, {0} (start), {1} (i-1))", start, i-1);
                QuickSort(arr, i + 1, end);
                Console.WriteLine("QuickSort(arr, {0} (i+1), {1} (end))", i + 1, end);
            }

            return arr;
        }

        /*****************************************************************
        * Procedure: Partition
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        private int Partition(int[] arr, int start, int end)
        {
            int temp;
            int p = arr[end];
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (arr[j] <= p)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            temp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = temp;
            return i + 1;
        }
    }
}
