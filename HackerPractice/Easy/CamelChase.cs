using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerPractice.Easy
{
    public class CamelChase
    {
        /*****************************************************************
        * Procedure: RunTest
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public void RunTest()
        {
            Console.WriteLine("-----camelcase-----");

            var output = camelcase("saveChangesInTheEditor");
            Utilities.CheckOutput<int>(output, 5);
        }

        /*****************************************************************
        * Procedure: Foo
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public int camelcase(string s)
        {
            var counter = 0;

            foreach (var letter in s)
            {
                if (char.IsUpper(letter))
                {
                    counter++;
                }
            }

            return ++counter;
        }
    }
}
