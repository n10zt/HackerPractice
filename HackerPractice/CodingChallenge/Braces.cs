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

            var input = Utilities.GetStrArray("{[()]} {[(])} {{[[(())]]}}");

            var output = braces(input);
            Utilities.CheckOutput<string>(output, Utilities.GetStrArray("YES NO YES"));
        }

        /*****************************************************************
        * Procedure: braces
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public string[] braces(string[] values)
        {
            //() {} []

            string[] output = new string[values.Count()];
            int index = 0;
            var st = new Stack();
            bool isBalanced = true;
            char lastChar = ' ';

            foreach (var brace in values)
            {
                //Console.WriteLine(brace);
                Char[] lineInput = brace.ToCharArray();

                foreach (var letter in lineInput)
                {
                    //Console.WriteLine(letter);
                    switch (letter)
                    {
                        case '{':
                        case '(':
                        case '[':
                            st.Push(letter);
                            lastChar = letter;
                            break;
                        case '}':
                            if (lastChar.Equals('{'))
                            {
                                if (st.Count == 0)
                                {
                                    isBalanced = false;
                                    break;
                                }
                                else
                                {
                                    st.Pop();
                                    if (st.Count > 0) lastChar = (char)st.Peek();
                                }
                            }
                            else
                            {
                                isBalanced = false;
                                break;
                            }
                            break;
                        case ')':
                            if (lastChar.Equals('('))
                            {
                                if (st.Count == 0)
                                {
                                    isBalanced = false;
                                    break;
                                }
                                else
                                {
                                    st.Pop();
                                    if (st.Count > 0) lastChar = (char)st.Peek();
                                }
                            }
                            else
                            {
                                isBalanced = false;
                                break;
                            }
                            break;
                        case ']':
                            if (lastChar.Equals('['))
                            {
                                if (st.Count == 0)
                                {
                                    isBalanced = false;
                                    break;
                                }
                                else
                                {
                                    st.Pop();
                                    if (st.Count > 0) lastChar = (char)st.Peek();
                                }
                            }
                            else
                            {
                                isBalanced = false;
                                break;
                            }
                            break;
                    }
                }

                if (isBalanced)
                {
                    output[index++] = "YES";
                }
                else
                {
                    output[index++] = "NO";
                    isBalanced = true;
                }
            }

            return output;
        }
    }
}
