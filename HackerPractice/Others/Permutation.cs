using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerPractice.Others
{
    public class Permutation
    {


        public void GetPermutation()
        {
            var input = new List<int>() { 1, 2, 3, 4 };

            string output = string.Empty;

            int[] result = new int[4];

            for (var d = 0; d < 4; d++)
            {
                result[0] = input[d];
                var third = input.ToList();
                third.RemoveAt(d);

                for (var c = 0; c < 3; c++)
                {
                    result[1] = third[c];
                    var second = third.ToList();
                    second.RemoveAt(c);

                    for (var b = 0; b < 2; b++)
                    {
                        result[2] = second[b];
                        var first = second.ToList();
                        first.RemoveAt(b);

                        for (var a = 0; a < 1; a++)
                        {
                            result[3] = first[a];

                            var printout = string.Empty;
                            for (var r = 0; r < 4; r++)
                            {
                                printout += result[r] + " ";
                            }
                            Console.WriteLine(printout);
                        }
                    }
                }
            }
        }
    }
}
