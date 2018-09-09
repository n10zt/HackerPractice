namespace HackerPractice.Medium
{
    public class TimeInWords
    {
        /* for "main"
            var tester = new TimeInWords();

            string output = "";

            output = tester.timeInWords(5, 47);
            CheckOutput(output, "thirteen minutes to six");

            output = tester.timeInWords(3, 00);
            CheckOutput(output, "three o' clock");

            output = tester.timeInWords(7, 15);
            CheckOutput(output, "quarter past seven");

            output = tester.timeInWords(11, 59);
            CheckOutput(output, "one minute to twelve");

            output = tester.timeInWords(12, 00);
            CheckOutput(output, "twelve o' clock");

            output = tester.timeInWords(1, 01);
            CheckOutput(output, "one minute past one");

            output = tester.timeInWords(2, 16);
            CheckOutput(output, "sixteen minutes past two");

            output = tester.timeInWords(3, 30);
            CheckOutput(output, "half past three");

            output = tester.timeInWords(4, 31);
            CheckOutput(output, "twenty nine minutes to five");

            output = tester.timeInWords(5, 45);
            CheckOutput(output, "quarter to six");

            output = tester.timeInWords(6, 50);
            CheckOutput(output, "ten minutes to seven");

            output = tester.timeInWords(12, 55);
            CheckOutput(output, "five minutes to one");

        private void CheckOutput (string input, string criteria)
        {
            var result = input.Equals(criteria) ? "pass" : "fail";

            Console.WriteLine(result + " --> " + input);
        }
        //*/

        public string input = "";

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
