using HackerPractice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HackerPractice.Medium
{
    public class FormingMagicSquare
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

            output = formingMagicSquare(Utilities.IntoJagArray(3, 3, "5 3 4 1 5 8 6 4 2"));
            Utilities.CheckOutput(output, 7);

            output = formingMagicSquare(Utilities.IntoJagArray(3, 3, "4 9 2 3 5 7 8 1 5"));
            Utilities.CheckOutput(output, 1);

            output = formingMagicSquare(Utilities.IntoJagArray(3, 3, "4 8 2 4 5 7 6 1 6"));
            Utilities.CheckOutput(output, 4);
        }

        /*****************************************************************
        * Procedure: formingMagicSquare
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public int formingMagicSquare(int[][] s)
        {
            var solutionSet = GetSolutionSet();

            return GetCost(s, solutionSet);
        }

        /*****************************************************************
        * Procedure: GetSolutionSet
        * Description: returns all possible sets of magic square each
        * row represents a single array of a single Magic Square solution
        * Input: none
        * Output: int[][]
        *****************************************************************/
        private int[][] GetSolutionSet()
        {
            int[] aSquare = new int[9];
            int[][] solutionSet = new int[8][]; // refactor to resizeable
            int i, j = 0;

            for (var firstElement = 1; firstElement <= 9; firstElement++)
            {
                for (var secondElement = 1; secondElement <= 9; secondElement++)
                {
                    //Validate input
                    if (firstElement + secondElement < 6) continue;
                    if (firstElement == 5 || secondElement == 5) continue;     // center is always 5 so this number is taken

                    // The 'secondElement' selection is skipped when paired with 'firstElement'
                    // Explanation: For example, selecting 1 (as firstElement) means 9 (secondElement) is already taken
                    if (firstElement == 1 && secondElement == 9) continue;     
                    if (firstElement == 2 && secondElement == 8) continue;
                    if (firstElement == 3 && secondElement == 7) continue;
                    if (firstElement == 4 && secondElement == 6) continue;

                    if (firstElement == 9 && secondElement == 1) continue;
                    if (firstElement == 8 && secondElement == 2) continue;
                    if (firstElement == 7 && secondElement == 3) continue;
                    if (firstElement == 6 && secondElement == 4) continue;

                    // MagicSquare {firstElement, secondElement, 3rd, 4th, 5th, 6th, 7th, 8th, 9th}
                    // 3rd to 9th are calculated so only the first two is up for grabs.
                    var result = IsMagicSquare(firstElement, secondElement);

                    if (result != null)
                    {
                        i = 0;
                        for (var r = 0; r < 3; r++)
                        {
                            for (var c = 0; c < 3; c++)
                            {
                                //Console.WriteLine("[" + r + "][" + c + "] = " + result[r][c]);
                                aSquare[i++] = result[r][c];
                            }
                        }
                        //Console.WriteLine("---------------------------------------");
                        solutionSet[j] = new int[aSquare.Length];
                        aSquare.CopyTo(solutionSet[j], 0);

                        j++;
                    }
                }
            }

            return solutionSet;
        }

        /*****************************************************************
        * Procedure: GetCost
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        private int GetCost(int[][] input, int[][] solutions)
        {
            // convert jagged array into single array for comparison
            int[] convertedInput = new int[GetJaggedArrayLen(input)];
            short index = 0;

            for (var x = 0; x < 3; x++)
            {
                for (var y = 0; y < 3; y++)
                {
                    convertedInput[index++] = input[x][y];
                }
            }

            int[] costCounter = new int[solutions.Length];
            int solutionCounter = 0;

            for (var a = 0; a < solutions.Length; a++) // 'a' represents each Magic Square
            {
                solutionCounter = 0;
                for (var i = 0; i < 9; i++)
                {
                    solutionCounter += Math.Abs(solutions[a][i] - convertedInput[i]);
                }

                costCounter[a] = solutionCounter;
            }

            return costCounter.Min();
        }

        /*****************************************************************
        * Procedure: IsMagic
        * Description: 
        *  Based on algebra analysis, only 2 numbers in the 1 and 2 
        *  position, respectively are needed to determine if they can be 
        *  a Magic Square.
        * Input: First and second numbers
        * Output: an instance of Magic Square
        *****************************************************************/
        public int[][] IsMagicSquare(int first, int second)
        {
            int[][] derivedSquare = new int[3][];
            const int ConstMagicSquare = 15;

            for (var x = 0; x < 3; x++)
            {
                derivedSquare[x] = new int[3];
            }

            // initialize 1st, 2nd, and 5th arrays
            derivedSquare[0][0] = first;    // first
            derivedSquare[0][1] = second;   // second
            derivedSquare[1][1] = 5;        // fifth

            derivedSquare[0][2] = ConstMagicSquare - first - second;    // third
            if (IsOutofRange(derivedSquare[0][2])) return null;

            derivedSquare[2][2] = 10 - derivedSquare[0][0]; // ninth
            if (IsOutofRange(derivedSquare[2][2])) return null;

            derivedSquare[1][2] = ConstMagicSquare - derivedSquare[0][2] - derivedSquare[2][2]; // sixth
            if (IsOutofRange(derivedSquare[1][2])) return null;

            derivedSquare[2][0] = 10 - derivedSquare[0][2]; // seventh
            if (IsOutofRange(derivedSquare[2][0])) return null;

            derivedSquare[2][1] = 10 - derivedSquare[0][1]; // eight
            if (IsOutofRange(derivedSquare[2][1])) return null;

            derivedSquare[1][0] = 10 - derivedSquare[1][2]; // fourth
            if (IsOutofRange(derivedSquare[1][0])) return null;

            if (!IsMagic(derivedSquare)) return null;

            return derivedSquare;
        }

        /*****************************************************************
        * Procedure: CheckRange
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private bool IsOutofRange(int num)
        {
            if (num < 1 || num > 9) return true;

            return false;
        }

        /*****************************************************************
        * Procedure: IsMagic
        * Description: Is sum of any row, columns, or diagonals equal?
        * Input: 
        * Output: 
        *****************************************************************/
        public bool IsMagic(int[][] s)
        {
            int[] rows = new int[3];
            int[] cols = new int[3];
            int[] diag = new int[2];

            const int ConstMagicSum = 15;

            // center better be 5
            if (s[1][1] != 5) return false;

            var numOfUniqueElements = s.SelectMany(a => a).Distinct().ToArray().Count();

            if (numOfUniqueElements != GetJaggedArrayLen(s)) return false;

            // Rows
            for (var x = 0; x < 3; x++)
            {
                for (var y = 0; y < 3; y++)
                {
                    rows[x] += s[x][y];
                }

                if (rows[x] != ConstMagicSum) return false;
            }

            // Columns
            for (var x = 0; x < 3; x++)
            {
                for (var y = 0; y < 3; y++)
                {
                    cols[x] += s[y][x];
                }

                if (cols[x] != ConstMagicSum) return false;
            }

            // Diagonal
            for (int x = 0, y = (s.Length - 1); x < s.Length; x++, y--)
            {
                diag[0] += s[x][x];
                diag[1] += s[x][y];
            }

            if (diag[0] != ConstMagicSum || diag[1] != ConstMagicSum) return false;


            return true;
        }

        /*****************************************************************
        * Procedure: GetJaggedArrayLen
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        private int GetJaggedArrayLen(int[][] s)
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
            Console.WriteLine("Rows");
            for (var x = 0; x < 3; x++)
            {
                //                Console.WriteLine(rows[x]);
            }

            Console.WriteLine("Cols");
            for (var x = 0; x < 3; x++)
            {
                //                Console.WriteLine(cols[x]);
            }

            Console.WriteLine("Diagonals");
            for (var x = 0; x < 2; x++)
            {
                //                Console.WriteLine(diag[x]);
            }

//*/
