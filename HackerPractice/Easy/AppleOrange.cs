using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerPractice.Easy
{
    public class AppleOrange
    {
        /* for "main"
            var tester = new AppleOrange();

            tester.countApplesAndOranges(7, 11, 5, 15, Utilities.GetIntArray(tester.apples), Utilities.GetIntArray(tester.oranges));
        //*/

        public string apples = "-2 2 1";
        public string oranges = "5 -6";

        public void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            //s - Sam's house, start
            //t - Sam's house, end
            //a - location of Apple tree
            //b - location of Orange tree

            Console.WriteLine(CountFruitInHouse(s, t, a, apples));
            Console.WriteLine(CountFruitInHouse(s, t, b, oranges));
        }

        private int CountFruitInHouse(int s, int t, int location, int[] fruits)
        {
            int fruitCounter = 0;

            foreach (var fruit in fruits)
            {
                if ((fruit + location) >= s && (fruit + location) <= t) fruitCounter++;
            }

            return fruitCounter;
        }
    }
}

/*
        public void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            //s - Sam's house, start
            //t - Sam's house, end
            //a - location of Apple tree
            //b - location of Orange tree

            short aCounter = 0;
            short oCounter = 0;

            foreach (var apple in apples)
            {
                if ((apple + a) >= s && (apple + a) <= t) aCounter++;
            }

            foreach (var orange in oranges)
            {
                if ((orange + b) >= s && (orange + b) <= t) oCounter++;
            }

            Console.WriteLine(aCounter);
            Console.WriteLine(oCounter);
        }
//*/
