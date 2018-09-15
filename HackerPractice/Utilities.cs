using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerPractice
{
    public static class Utilities
    {
        /*****************************************************************
        * Procedure: GetIntArray
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public static int[] GetIntArray(string input)
        {
            int[] nums = Array.ConvertAll(input.Split(' '), int.Parse);

            return nums;
        }

        /*****************************************************************
        * Procedure: GetStrArray
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public static string[] GetStrArray(string input)
        {
            string[] nums = input.Split(' ');

            return nums;
        }

        /*****************************************************************
        * Procedure: Str2StrArray
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public static string[] Str2StrArray(string input)
        {
            return input.ToCharArray().Select(c => c.ToString()).ToArray();
        }

        /*****************************************************************
        * Procedure: PrintArray
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public static void PrintArray(int[] input)
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
        public static int[][] IntoJagArray(short rowLen, short colLen, string input)
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
        public static void CheckOutput<T>(T input, T criteria)
        {
            var result = input.Equals(criteria) ? "pass" : "fail";

            Console.WriteLine(result + " --> " + input);
        }

        public static void CheckOutput<T>(IList<T> input, IList<T> criteria)
        {
            var result = input.SequenceEqual(criteria) ? "pass" : "fail";

            Console.Write(result + " --> ");
            foreach(var e in input)
            {
                Console.Write(e + " ");
            }
            Console.WriteLine();
        }

        /*****************************************************************
        * Procedure: GetJaggedArrayLen
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public static int GetJaggedArrayLen(int[][] s)
        {
            int sElements = 0;

            foreach (var row in s)
            {
                sElements += row.GetLength(0);
            }

            return sElements;
        }
    }
}

/*
 * Sample
 * 
    static public T GeTArray<T>(this string input) where T : IConvertible
    {//https://stackoverflow.com/questions/10574504/how-to-use-t-tryparse-in-a-generic-method-while-t-is-either-double-or-int
        var thisType = default(T);
        var typeCode = thisType.GetTypeCode();

        if (typeCode == TypeCode.Int32)
        {
            int nums;
            int.TryParse(input, out nums);
            return (T)Convert.ChangeType(nums, typeCode);
        }
        else if (typeCode == TypeCode.String)
        {
            var nums = input.Split(',');
            return (T)Convert.ChangeType(nums, typeCode);
        }

        return (T)Convert.ChangeType(1, TypeCode.Int32);
    }
------------------------------------------------------------------------------

int[,,] intarray3Dd = new int[2, 2, 3] 
            { 
                { 
                    { 1, 2, 3 },
                    { 4, 5, 6 }
                },
                { 
                    { 7, 8, 9 },
                    { 10, 11, 12 }
                }
            };

//*/
