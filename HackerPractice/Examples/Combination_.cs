using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerPractice.Examples
{
    public class Combination_
    {
        /*****************************************************************
        * Procedure: RunTest
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public void RunTest()
        {
            Console.WriteLine("-----Combinations-----");
            const int k = 2;
            var n = Utilities.GetStrArray("b e a f");

            Console.Write("n: ");
            foreach (var item in n)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            Console.WriteLine("k: {0}", k);
            Console.WriteLine();

            foreach (IEnumerable<string> i in Combinations(n, k))
                Console.WriteLine(string.Join(" ", i));
        }

        /*****************************************************************
        * Procedure: NextCombination
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        private static bool NextCombination(IList<int> num, int n, int k)
        {
            bool finished;

            var changed = finished = false;

            if (k <= 0) return false;

            for (var i = k - 1; !finished && !changed; i--)
            {
                if (num[i] < n - 1 - (k - 1) + i)
                {
                    num[i]++;

                    if (i < k - 1)
                        for (var j = i + 1; j < k; j++)
                            num[j] = num[j - 1] + 1;
                    changed = true;
                }
                finished = i == 0;
            }

            return changed;
        }

        /*****************************************************************
       * Procedure: Combinations
       * Description: 
       * Input: 
       * Output: 
       *****************************************************************/
        private static IEnumerable Combinations<T>(IEnumerable<T> elements, int k)
        {
            var elem = elements.ToArray();
            var size = elem.Length;

            if (k > size) yield break;

            var numbers = new int[k];

            for (var i = 0; i < k; i++)
                numbers[i] = i;

            do
            {
                yield return numbers.Select(n => elem[n]);
            } while (NextCombination(numbers, size, k));
        }


    }
}
