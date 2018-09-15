using System;

namespace HackerPractice.Medium
{
    public class TimeInWords
    {
        /*****************************************************************
        * Procedure: RunTest
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public void RunTest()
        {
            Console.WriteLine("-----TimeInWords-----");

            var output = timeInWords(5, 47);
            Utilities.CheckOutput<string>(output, "thirteen minutes to six");

            output = timeInWords(3, 00);
            Utilities.CheckOutput<string>(output, "three o' clock");

            output = timeInWords(7, 15);
            Utilities.CheckOutput<string>(output, "quarter past seven");

            output = timeInWords(11, 59);
            Utilities.CheckOutput<string>(output, "one minute to twelve");

            output = timeInWords(12, 00);
            Utilities.CheckOutput<string>(output, "twelve o' clock");

            output = timeInWords(1, 01);
            Utilities.CheckOutput<string>(output, "one minute past one");

            output = timeInWords(2, 16);
            Utilities.CheckOutput<string>(output, "sixteen minutes past two");

            output = timeInWords(3, 30);
            Utilities.CheckOutput<string>(output, "half past three");

            output = timeInWords(4, 31);
            Utilities.CheckOutput<string>(output, "twenty nine minutes to five");

            output = timeInWords(5, 45);
            Utilities.CheckOutput<string>(output, "quarter to six");

            output = timeInWords(6, 50);
            Utilities.CheckOutput<string>(output, "ten minutes to seven");

            output = timeInWords(12, 55);
            Utilities.CheckOutput<string>(output, "five minutes to one");
        }

        /*****************************************************************
        * Procedure: timeInWords
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public string timeInWords(int h, int m)
        {
            string output = "";

            if (m == 0)
            {
                output = ConvertToWord(h);
                output += " o' clock";
            }
            else if (m >= 1 && m <= 30)
            {
                output = ConvertToWord(m);
                output += IsMinute(m); // minute, minutes or " "?
                output += " past";
                output += " " + ConvertToWord(h);
            }
            else if (m > 30)
            {
                output = ConvertToWord(60-m);
                output += IsMinute(60-m);    // backward
                output += " to";
                h = h < 12 ? ++h : 1;       // loop back to 1 not 13

                output += " " + ConvertToWord(h);
            }

            return output;
        }

        /*****************************************************************
        * Procedure: IsMinute
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        private string IsMinute(int m)
        {
            string output = "";

            if (m != 15 && m != 30)
            {
                output += " minute";
            }

            if (m != 1 && m != 15 && m != 30)
            {
                output += "s";
            }

            return output;
        }

        /*****************************************************************
        * Procedure: ConvertToWord
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public string ConvertToWord(int number)
        {
            string output = "";

            output = number < 20 
                ? ConvertToWordTeens(number)
                : output = ConvertToWords20Up(number);

            return output;
        }

        private string ConvertToWordTeens(int number)
        {
            string output = "";

            switch (number)
            {
                case 1:
                    output = "one";
                    break;
                case 2:
                    output = "two";
                    break;
                case 3:
                    output = "three";
                    break;
                case 4:
                    output = "four";
                    break;
                case 5:
                    output = "five";
                    break;
                case 6:
                    output = "six";
                    break;
                case 7:
                    output = "seven";
                    break;
                case 8:
                    output = "eight";
                    break;
                case 9:
                    output = "nine";
                    break;
                case 10:
                    output = "ten";
                    break;
                case 11:
                    output = "eleven";
                    break;
                case 12:
                    output = "twelve";
                    break;
                case 13:
                    output = "thirteen";
                    break;
                case 14:
                    output = "fourteen";
                    break;
                case 15:
                    output = "quarter";
                    break;
                case 16:
                    output = "sixteen";
                    break;
                case 17:
                    output = "seventeen";
                    break;
                case 18:
                    output = "eighteen";
                    break;
                case 19:
                    output = "nineteen";
                    break;
            }

            return output;
        }

        /*****************************************************************
        * Procedure: ConvertToWords20Up
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        private string ConvertToWords20Up(int m)
        {
            string output = "";

            var word = m.ToString();

            if (word[0] == '2')
            {
                output = "twenty";
                output += " " + ConvertToWord(word[1] - '0');
            }
            else if (word[0] == '3')
            {
                output = "half";
            }

            return output;
        }
    }
}
