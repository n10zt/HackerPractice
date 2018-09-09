using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerPractice.Easy
{
    public class Kangaroo
    {
        /* for "main"
            var tester = new Kangaroo();

            var output = tester.kangaroo(0, 3, 4, 2);
            Console.WriteLine(output); //Yes

            output = tester.kangaroo(0, 2, 5, 3);
            Console.WriteLine(output); //No
        //*/

        public string input = "";

        public string kangaroo(int x1, int v1, int x2, int v2)
        {
            bool isPossible = false;

            if (x1 < x2 && v1 > v2)
            {
                isPossible = IsPossible(x1, x2, v1, v2);
            }
            else if (x1 > x2 && v1 < v2)
            {
                isPossible = IsPossible(x2, x1, v2, v1);
            }
            else if (x1 == x2 && v1 == v2)
            {
                isPossible = true;
            }

            return isPossible ? "YES" : "NO";
        }

        private bool IsPossible(int behinds1, int aheads2, int s1, int s2)
        {
            while (behinds1 < aheads2)
            {
                behinds1 += s1;
                aheads2 += s2;
            }

            return behinds1 == aheads2 ? true : false;
        }
    }
}
