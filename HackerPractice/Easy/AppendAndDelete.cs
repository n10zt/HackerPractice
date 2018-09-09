using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerPractice.Easy
{
    public class AppendAndDelete
    {
        /* for "main"
            var tester = new AppendAndDelete();

            string output = string.Empty;
            /*
            output = tester.appendAndDelete("hackerhappy", "hacker", 9);
            output = tester.appendAndDelete("hackerhappy", "hackerhappy", 9);
            output = tester.appendAndDelete("g", "g", 9);

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

        output = tester.appendAndDelete("asdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcv",
                "bsdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcv", 100);
            Console.WriteLine(output); //No


            /*
            output = tester.appendAndDelete("y", "yu", 2);
            Console.WriteLine(output); //No
            output = tester.appendAndDelete("aba", "aba", 7);
            Console.WriteLine(output); //Yes
            output = tester.appendAndDelete("hackerhappy", "hackerrank", 9);
            Console.WriteLine(output); //Yes
            output = tester.appendAndDelete("ashley", "ash", 2);
            Console.WriteLine(output); //No
                        //*/
        //*/


        public string input = "";

        public string appendAndDelete(string s, string t, int k)
        {
            int initialOpsCounter = 0;
            int originalS = s.Length; 

            while ((t.IndexOf(s) != 0) && s.Length > 0)
            {
                s = s.Substring(0, s.Length - 1);
                initialOpsCounter++;
            }

            int requiredOps = 0;
            var output = string.Empty;
            bool isPossible = false;

            if (k >= originalS + t.Length)
            {
                isPossible = true;
            }
            else // k < s.Length + t.length
            {
                if (string.IsNullOrEmpty(s)) //zero match
                {
                    isPossible = false;
                }
                else if (s.Length > 0) // partial match; at least one letter
                {
                    requiredOps = initialOpsCounter + (t.Length - s.Length);

                    if (k == requiredOps)
                    {
                        isPossible = true;
                    }
                    else if (k > requiredOps)
                    {
                        if (((k-requiredOps) % 2) == 1)
                        {
                            isPossible = false;
                        }
                        else
                        {
                            isPossible = true;
                        }
                    }
                    else
                    {
                        isPossible = false;
                    }
                }
            }

            output =  isPossible ? "Yes" : "No";

            return output;
        }
    }
}
