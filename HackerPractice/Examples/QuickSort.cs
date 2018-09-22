using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerPractice.Model;

namespace HackerPractice.Examples
{
    public class QuickSort_
    {
        /*****************************************************************
        * Procedure: RunTest
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public void RunTest()
        {
            Console.WriteLine("-----quicksort-----");

            // Create an unsorted array of string elements
            //var unsorted2 = "5".GeTArray<int>();
            string[] unsorted = Utilities.GetStrArray("z e x c m q a");

            var test = "a c g d j".Split(' ');

            // Print the unsorted array
            for (int i = 0; i < unsorted.Length; i++)
            {
                Console.Write(unsorted[i] + " ");
            }

            Console.WriteLine();

            quicksort(unsorted, 0, unsorted.Length-1);

            //Utilities.CheckOutput<int>(output, 6);

            // Print the sorted array
            for (int i = 0; i < unsorted.Length; i++)
            {
                Console.Write(unsorted[i] + " ");
            }

            Console.WriteLine();
        }

        /*****************************************************************
        * Procedure: quicksort
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public void quicksort(IComparable[] elements, int left, int right)
        {
            int i = left, j = right;
            IComparable pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    IComparable tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                quicksort(elements, left, j);
            }

            if (i < right)
            {
                quicksort(elements, i, right);
            }
        }
    }
}
