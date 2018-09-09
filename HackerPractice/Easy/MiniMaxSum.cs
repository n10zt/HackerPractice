using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerPractice.Easy
{
    public class MiniMaxSum
    {
        public string input = "1 2 3 4 5";
        public string input2 = "7 69 2 221 8974";


        public void miniMaxSum(int[] arr)
        {
            bool flag = true;
            int temp;

            for (var i = 1; i <= (arr.Length - 1) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (arr.Length - 1); j++)
                {
                    if (arr[j + 1] < arr[j])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        flag = true;
                    }
                }
            }

            long min = 0;
            long max = 0;

            for (int i = 0, j = 4; i < 4; i++, j--)
            {
                min += arr[i];
                max += arr[j];
            }

            Console.WriteLine(min + " " + max);
        }
    }
}
