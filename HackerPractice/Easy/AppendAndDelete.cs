using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerPractice.Model;

namespace HackerPractice.Easy
{
    public class AppendAndDelete : IProblem
    {
        /* for "main"
            /*
            output = tester.appendAndDelete("xy", "xyu", 1);
            Console.WriteLine(output); //Yes
            output = tester.appendAndDelete("xy", "xyu", 2);
            Console.WriteLine(output); //No
            output = tester.appendAndDelete("xy", "xyu", 3);
            Console.WriteLine(output); //Yes
            output = tester.appendAndDelete("xy", "xyu", 4);
            Console.WriteLine(output); //No
            output = tester.appendAndDelete("xy", "xyu", 5);
            Console.WriteLine(output); //Yes

            output = tester.appendAndDelete("xy", "xyuu", 1);
            Console.WriteLine(output); //No
            output = tester.appendAndDelete("xy", "xyuu", 2);
            Console.WriteLine(output); //Yes
            output = tester.appendAndDelete("xy", "xyuu", 3);
            Console.WriteLine(output); //No
            output = tester.appendAndDelete("xy", "xyuu", 4);
            Console.WriteLine(output); //Yes
            output = tester.appendAndDelete("xy", "xyuu", 5);
            Console.WriteLine(output); //No
        //*/
        /*****************************************************************
        * Procedure: RunTest
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public void RunTest()
        {
            Console.WriteLine("-----appendAndDelete-----");

            var output = appendAndDelete("hackerhappy", "hacker", 9);
            Utilities.CheckOutput<string>(output, "Yes");

            output = appendAndDelete("aba", "aba", 7);
            Utilities.CheckOutput<string>(output, "Yes");

            output = appendAndDelete("ashley", "ash", 2);
            Utilities.CheckOutput<string>(output, "No");

            output = appendAndDelete("y", "yu", 2);
            Utilities.CheckOutput<string>(output, "No");

            output = appendAndDelete("asdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcv",
                "bsdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcv", 100);
            Utilities.CheckOutput<string>(output, "No");
        }

        /*****************************************************************
        * Procedure: appendAndDelete
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public string appendAndDelete(string s, string t, int k)
        {
            var initialOpsCounter = 0;
            var originalS = s.Length; 

            while (t.IndexOf(s) != 0 && s.Length > 0)
            {
                s = s.Substring(0, s.Length - 1);
                initialOpsCounter++;
            }

            var output = string.Empty;
            var isPossible = false;

            if (k >= originalS + t.Length)
            {
                isPossible = true;
            }
            else // k < s.Length + t.length
            {
                if (s.Length > 0) // partial match; at least one letter
                {
                    var requiredOps = initialOpsCounter + (t.Length - s.Length);

                    if (k == requiredOps)
                    {
                        isPossible = true;
                    }
                    else if (k > requiredOps)
                    {
                        if ((k-requiredOps) % 2 == 0)
                        {
                            isPossible = true;
                        }
                    }
                }
            }

            output =  isPossible ? "Yes" : "No";

            return output;
        }
    }
}
