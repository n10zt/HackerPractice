using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace HackerPractice.Medium
{
    public class ExtraLongFactorials
    {
        /* for "main"
            var tester = new ExtraLongFactorials();

            int input = Convert.ToInt16(Input2.Text.ToString());
            tester.extraLongFactorials(input);
        //*/

        public string input = "";

        public void extraLongFactorials(int n)
        {
            var output = Factorial(n);

            Console.WriteLine(output);
        }

        private BigInteger Factorial (BigInteger num)
        {
            if (num <= 1) return 1;

            return BigInteger.Multiply(num, Factorial(num - 1));
        }
    }
}


/*
            BigInteger big1 = new BigInteger(ulong.MaxValue);
            BigInteger big2 = new BigInteger(ulong.MaxValue);

            var double1 = BigInteger.Add(big1, big2);


            Console.WriteLine("Long MAX: " + big1.ToString());
            Console.WriteLine("Long MAX * 2: " + double1.ToString());
//*/
