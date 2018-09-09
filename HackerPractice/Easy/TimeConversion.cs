using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerPractice.Easy
{
    public class TimeConversion
    {
        /* for "main"
            var tester = new TimeConversion();

            tester.RunTest();
        //*/

        public string input = "07:05:45PM";

        public void RunTest()
        {
            Test("12:00:00AM");
            Test("12:05:45AM");
            Test("01:05:45AM");
            Test("11:05:45AM");
            Test("11:59:59AM");

            Test("12:00:00PM");
            Test("12:05:45PM");
            Test("01:05:45PM");
            Test("11:05:45PM");
            Test("11:59:59PM");
        }

        public void Test(string input)
        {
            var tester = new TimeConversion();

            Console.WriteLine(input + " --> " + tester.timeConversion(input));
        }

        public string timeConversion(string s)
        {
            string[] sc = { ":" };

            string[] words = s.Split(sc, StringSplitOptions.RemoveEmptyEntries);

            int hour = Convert.ToInt16(words[0]);

            if (words[2].Contains("P") && hour < 12)
            {
                hour += 12;
            }
            else if (words[2].Contains("A"))
            {
                hour %= 12;
            }

            return hour.ToString("00") + ":" + words[1] + ":" + words[2].Remove(2,2);
        }

    }
}
