using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerPractice.Medium
{
    public class Encryption
    {
        /* for "main"
            var tester = new Encryption();

            string output = "";

            output = tester.encryption("ifmanwasmeanttostayonthegroundgodwouldhavegivenusroots");
            Console.WriteLine(output); // "hae and via ecy"

            output = tester.encryption("haveaniceday");
            Console.WriteLine(output); // "hae and via ecy"

            output = tester.encryption("feedthedog");
            Console.WriteLine(output); // "fto ehg ee dd"

            output = tester.encryption("chillout");
            Console.WriteLine(output); // "clu hlt io"

            output = tester.encryption("abc123xyz");//
            //output = tester.encryption("abcdefghi123456789abcdefghi123456789abcdefghi123456789abcdefghi123456789abcdefghi"); //81
            Console.WriteLine(output); // 
        //*/

        public string input = "";

        public string encryption(string s)
        {
            var sqrt = Math.Sqrt(s.Length);
            int numofrows = (int) Math.Floor(sqrt);
            int numofcols = (int) Math.Ceiling(sqrt);
            int rowOffset = 0;

            while ((numofrows+rowOffset)*numofcols < s.Length)
            {
                rowOffset++;
            }

            string[,] encryptArr = new string[numofrows + rowOffset, numofcols];
            int rI =0, cI=0;


            for(var i=0; i<s.Length; i++)
            {
                rI = (int)Math.Floor((double)i / (double)(numofcols));
                cI = i % numofcols;

                encryptArr[rI, cI] = s[i].ToString();
            }

            string out1 = string.Empty;
            for (var r=0; r<numofcols; r++)
            {
                for (var c = 0; c < numofrows + rowOffset; c++)
                {
                    out1 += encryptArr[c, r];
                }
                out1 += " ";
            }

            return out1;
        }
    }
}

//Debug.WriteLine(rI + " " + cI);

/* Test 4, 7, 10 fails
        public string encryption(string s)
        {
            var sqrt = Math.Sqrt(s.Length);
            int numofrows = (int) Math.Floor(sqrt);
            int numofcols = (int) Math.Ceiling(sqrt);
            int rowOffset = 0;

            while ((numofrows+rowOffset)*numofcols < s.Length)
            {
                rowOffset++;
            }

            string[,] encryptArr = new string[numofrows + rowOffset, numofcols];
            int rI =0, cI=0;


            for(var i=0; i<s.Length; i++)
            {
                rI = (int) Math.Floor((double)i / (double)(numofrows+rowOffset+(1-rowOffset)));
                cI = i % numofcols;

                encryptArr[rI, cI] = s[i].ToString();
            }

            string out1 = string.Empty;
            for (var r=0; r<numofcols; r++)
            {
                for (var c = 0; c < numofrows + rowOffset; c++)
                {
                    out1 += encryptArr[c, r];
                }
                out1 += " ";
            }

            return out1;
        }
//*/
