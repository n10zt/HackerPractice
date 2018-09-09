using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerPractice.Easy
{
    public class BetweenTwoSets
    {
        /* for "main"
            var tester = new BetweenTwoSets();

            var output = tester.getTotalX(Utilities.GetIntArray(tester.a), Utilities.GetIntArray(tester.b));
            Console.WriteLine(output); 
        //*/


        /*
        public string a = "2 6";
        public string b = "24 36";
        /*/
        public string a = "2 4";
        public string b = "16 32 96";
        //*/

        public int getTotalX(int[] a, int[] b)
        {
            var lstBetween = new List<int>();
            int[] smallerArray, biggerArray;

            if (a.Max() < b.Max())
            {
                smallerArray = a;
                biggerArray = b;
            }
            else
            {
                smallerArray = b;
                biggerArray = a;
            }

            for (var num = 2; num <= biggerArray.Max(); num++) 
            {
                // try each number from 2 to bigger Arrays max number
                // if it is a factor of all elements of both arrays {a, b}
                if (IsCommonDenominator(num, smallerArray) && IsCommonDenominator(num, biggerArray))
                {
                    // if it is then make sure it is in between both arrays
                    if (num >= smallerArray.Max() && num <= biggerArray.Min())
                    {
                        lstBetween.Add(num);
                    }
                }
            }

            return lstBetween.Count;
        }

        private bool IsCommonDenominator(int n, int[] a)
        {
            foreach (var num in a)
            {
                if (n >= num)
                {
                    if (n % num != 0) return false;
                }
                else
                {
                    if (num % n != 0) return false;     // is num multiple of the input number ?
                }
            }

            return true;
        }
    }
}
