using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerPractice.Easy
{
    public class GradingStudents
    {
        /* for "main"
            var tester = new GradingStudents();

            tester.gradingStudents(Utilities.GetIntArray(tester.input)).ToString();
        //*/

        public string input = "73 67 38 33";

        public int[] gradingStudents(int[] grades)
        {
            int[] output = new int[grades.Length];

            ushort i = 0;

            foreach (var grade in grades)
            {
                output[i] = grade;
                if (grade >= 38)
                {
                    var diff2next5 = (5 - (grade % 5));
                    if (diff2next5 < 3)
                    {
                        output[i] += diff2next5;
                    } 
                }
                i++;
            }

            return output;
        }
    }
}
