using System;
using System.Linq;
using HackerPractice.CodeWars;
using HackerPractice.Model;

namespace HackerPractice.CodingChallenge
{
    public class Template2 : IProblem
    {
        /*****************************************************************
        * Procedure: RunTest
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public void RunTest()
        {
            Console.WriteLine("-----Foo-----");

            var output = string.Empty; 
            //*
            output = FirstNonRepeatingLetter("a");
            Utilities.CheckOutput<string>(output, "a");

            output = FirstNonRepeatingLetter("stress");
            Utilities.CheckOutput<string>(output, "t");

            output = FirstNonRepeatingLetter("moonmen");
            Utilities.CheckOutput<string>(output, "e");

            output = FirstNonRepeatingLetter("sTreSS");
            Utilities.CheckOutput<string>(output, "T");

            output = FirstNonRepeatingLetter("sTretTSS");
            Utilities.CheckOutput<string>(output, "r");
            //*/
            output = FirstNonRepeatingLetter("s,TrreetTSS");
            Utilities.CheckOutput<string>(output, ",");

            output = FirstNonRepeatingLetter("s#TrreetTSS");
            Utilities.CheckOutput<string>(output, "#");
        }

        //var strArray = str.ToCharArray().Select(c => c.ToString()).ToArray();

        /*****************************************************************
        * Procedure: Foo
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public string FirstNonRepeatingLetter(string str)
        {
            var strArray = str.ToCharArray();

            foreach (var letter in strArray)
            {
                var countL = str.Count(c => c == char.ToLower(letter));
                var countU = 0;
                if (char.IsLetter(letter))
                {
                    countU = str.Count(c => c == char.ToUpper(letter));
                }

                if (countL + countU < 2)
                {
                    return letter.ToString();
                }
            }

            return "";
        }
    }
}
