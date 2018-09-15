using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerPractice.Medium
{
    public class _3DSurfaceArea
    {
        /*****************************************************************
        * Procedure: RunTest
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public void RunTest()
        {
            int output = 0;

            //*
            output = surfaceArea(Utilities.IntoJagArray(1, 1, "1"));
            Utilities.CheckOutput<int>(output, 6);

            output = surfaceArea(Utilities.IntoJagArray(3, 3, "1 3 4 2 2 3 1 2 4"));
            Utilities.CheckOutput<int>(output, 60);

            output = surfaceArea(Utilities.IntoJagArray(3, 3, "1 3 4 2 2 1 5 2 4"));
            Utilities.CheckOutput<int>(output, 74);
            //*/

            //*
            int[][] trythis = new int[4][];
            trythis[0] = new int[2] { 1, 2 };
            trythis[1] = new int[3] { 1, 3, 3 };
            trythis[2] = new int[5] { 1, 4, 3, 4, 5 };
            trythis[3] = new int[1] { 1 };
            output = surfaceArea(trythis);
            Utilities.CheckOutput<int>(output, 80);
            //*/
        }

        /*
         //int[][] x = new int[2][]; // Jagged Array
        var x0 = A[0].GetLength(0); // number of cols in row [0]
        var x1 = A[1].GetLength(0); // it's only 0 because int[][] (as opposed to int[][,])
        var x2 = A[2].GetLength(0);
        var x3 = A[3].GetLength(0);
        var y = A.Length;   // number of rows
        var z = A.LongLength;
        var w0 = A[0].Length; // number of cols in row [0]
        var w1 = A[1].Length; // number of cols in row [1]
        var w2 = A[2].Length;
        var w3 = A[3].Length;
        //*/


        /*****************************************************************
        * Procedure: surfaceArea
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public int surfaceArea(int[][] A)
        {
            int cost = 0;

            // Note that the orientation is that the front is the length of the array
            // left starts at index 0 and right is the last row.

            // Left
            cost += A[0].Sum();

            // Right
            cost += A[A.Length - 1].Sum();

            // Top and Bottom
            int topCost = 0;
            foreach(var row in A)
            {
                topCost += row.Length; 
            }

            topCost *= 2; // double for the bottom

            cost += topCost;

            //
            // Front
            //

            // Add sum of first column to cost
            for (var t = 0; t < A.Length; t++)
            {
                cost += A[t][0];
            }

            int longestCol = 0;

            foreach (var row in A)
            { // get the longest column
                if (row.Length > longestCol) longestCol = row.Length;
            }

            // Sweep through deltas between rows
            for (var s = 0; s < longestCol; s++)
            {
                for (var t = 0; t < A.Length-1; t++)
                {
                    int cavityCounter1 = 0, cavityCounter2 = 0;

                    // upper row
                    if (s < A[t].Length)
                    {
                        cavityCounter1 = A[t][s];
                    }

                    // adjacent lower row
                    if (s < A[t + 1].Length)
                    {
                        cavityCounter2 = A[t + 1][s];
                    }

                    cost += Math.Abs(cavityCounter2 - cavityCounter1);
                }
            }

            //
            // Rear
            //

            // Add sum of last column of each  row to cost
            for (var t = 0; t < A.Length; t++)
            {
                var lastCol = A[t].Length-1;
                cost += A[t][lastCol];
            }

            // Sweep through deltas between columns in each row
            for (var r = 0; r < A.Length; r++)
            {
                if (A[r].Length < 2) continue; // minimum of 2 columns to proceed

                for (var c = 0; c < A[r].Length-1; c++)
                {
                    cost += Math.Abs(A[r][c]-A[r][c+1]);
                }
            }

            return cost;
        }
    }
}
