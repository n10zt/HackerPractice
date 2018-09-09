using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerPractice
{
    static public class Utilities
    {
        /*****************************************************************
        * Procedure: GetIntArray
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        static public int[] GetIntArray(string input)
        {
            int[] nums = Array.ConvertAll(input.Split(' '), int.Parse);

            return nums;
        }

        /*****************************************************************
        * Procedure: PrintArray
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        static public void PrintArray(int[] input)
        {
            Debug.Write("\r\n");

            foreach (var num in input)
            {
                //Console.Write(num.ToString());
                Debug.Write(num.ToString() + " ");
            }
        }

        /*****************************************************************
        * Procedure: IntoJagArray
        * Description: Converts a string of integers into a given 
        *           jagged array
        * Input: IntoJagArray(3,3, "1 2 3 4 5 6 7 8 9")
        * Output: int[][]
        *****************************************************************/
        static public int[][] IntoJagArray(short rowLen, short colLen, string input)
        {
            int[] s = GetIntArray(input);
            int[][] output = new int[rowLen][];

            for (var x = 0; x < rowLen; x++)
            {
                output[x] = new int[colLen];
            }

            if (rowLen * colLen < s.Length) return output; //make sure the array fits

            int i = 0;

            for (var x = 0; x < rowLen; x++)
            {
                for (var y = 0; y < colLen; y++)
                {
                    output[x][y] = s[i++];
                    //Console.WriteLine("[" + x + "][" + y + "] = " + output[x][y]);
                }
            }
            return output;
        }

        /*****************************************************************
        * Procedure: CheckOutput
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        static public void CheckOutput(int input, int criteria)
        {
            var result = input == criteria ? "pass" : "fail";

            Console.WriteLine(result + " --> " + input);
        }
    }
}