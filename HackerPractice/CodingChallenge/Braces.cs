using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerPractice.CodingChallenge
{
    public class Braces
    {
        /*****************************************************************
        * Procedure: RunTest
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public void RunTest()
        {
            Console.WriteLine("-----braces-----");

            var input = Utilities.GetStrArray("()} {[()]} {[(])} {{[[(())]]}}");

            var output = braces(input);
            Utilities.CheckOutput<string>(output, Utilities.GetStrArray("NO YES NO YES"));
        }

        /*****************************************************************
        * Procedure: braces
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public string[] braces(string[] input)
        {
            //() {} []

            string[] output = new string[input.Length];
            var index = 0;
            var stack = new Stack();

            foreach (var word in input)
            {
                var wordArray = word.ToCharArray().Select(c => c.ToString()).ToArray();
                var isBalanced = true;

                foreach (var letter in wordArray)
                {
                    switch (letter)
                    {
                        case "{":
                        case "(":
                        case "[":
                            stack.Push(letter);
                            break;
                        case "}":
                            isBalanced = CheckTopAndBalanceStack(ref stack, "{");
                            break;
                        case ")":
                            isBalanced = CheckTopAndBalanceStack(ref stack, "(");
                            break;
                        case "]":
                            isBalanced = CheckTopAndBalanceStack(ref stack, "[");
                            break;
                    }

                    if (!isBalanced) break; // no need to continue if already not balanced
                }

                output[index++] = isBalanced ? "YES" : "NO";
            }
            return output;
        }

        /*****************************************************************
        * Procedure: CheckTopAndBalanceStack
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        private bool CheckTopAndBalanceStack(ref Stack st, string brace)
        {
            if (st.Count > 0 && st.Peek().Equals(brace))
            {
                st.Pop();
                return true;
            }

            return false;
        }
    }
}
