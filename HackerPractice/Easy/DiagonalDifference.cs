using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerPractice.Easy
{
    public class DiagonalDifference
    {



        /*****************************************************************
        * Procedure: diagonalDifference
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public int diagonalDifference(int[][] arr)
        {
            int fsd = 0, bsd = 0;

            for (int x = 0, y = (arr.Length - 1); x < arr.Length; x++, y--)
            {
                bsd += arr[x][x];
                fsd += arr[x][y];
            }

            return Math.Abs(fsd - bsd);
        }

    }
}
