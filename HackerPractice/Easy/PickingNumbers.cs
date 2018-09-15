using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerPractice.Easy
{
    public class PickingNumbers
    {
        /*****************************************************************
        * Procedure: RunTest
        * Description: SOP
        * Input: 
        * Output: 
        *****************************************************************/
        public void RunTest()
        {
            int output = 0;

            output = pickingNumbers(Utilities.GetIntArray("4 6 5 3 3 1"));
            Utilities.CheckOutput<int>(output, 3);

            output = pickingNumbers(Utilities.GetIntArray("1 2 2 3 1 2"));
            Utilities.CheckOutput<int>(output, 5);

            //*
            output = pickingNumbers(Utilities.GetIntArray("1 2 2 3 3 3 8 10"));
            Utilities.CheckOutput<int>(output, 5);

            output = pickingNumbers(Utilities.GetIntArray("1 2 2 2 2 4 5 7 9"));
            Utilities.CheckOutput<int>(output, 5);

            output = pickingNumbers(Utilities.GetIntArray("1 2 2 2 4 4 5 5 5 5 7 8"));
            Utilities.CheckOutput<int>(output, 6);
            //*/
        }

        /*****************************************************************
        * Procedure: pickingNumbers
        * Description: 
        * Input: 
        * Output: 
        *****************************************************************/
        public int pickingNumbers(int[] anArray)
        {
            //Bubble sort - linked list
            LinkedList<int> list = new LinkedList<int>(anArray);
            LinkedList<int> sortedlist = new LinkedList<int>();

            LinkedListNode<int> current, a, previous, position = new LinkedListNode<int>(0);
            list.AddFirst(position);


            //*
            // "4 6 5 3 3 1"
            while (position.Next != null)
            {
                current = position.Next;
                previous = position;
                a = current.Next;

                while (a != null)
                {
                    if (a.Value < current.Value)
                    {
                        LinkedListNode<int> temp = a.Next;
                        /*
                        a.Next = previous.Next;
                        previous.Next = current.Next;
                        current.Next = temp;
                        previous = a;
                        //*/
                        a = temp;
                    }
                    else
                    {
                        a = a.Next;
                        current = current.Next;
                        previous = previous.Next;
                    }
                }
                position = position.Next;
            }
            //*/


            //Bubble sort
            bool isSwapped;
            int itemCount = anArray.Length;

            do
            {
                isSwapped = false;
                itemCount--;
                for (int j = 0; j < itemCount; j++)
                {
                    if (anArray[j] > anArray[j + 1])
                    {
                        var t = anArray[j + 1];
                        anArray[j + 1] = anArray[j];
                        anArray[j] = t;
                        isSwapped = true;
                    }
                }
            } while (isSwapped) ;

            int k = 0;
            int baseNum = 0, wingNum = 0;
            int[] container = new int[100];

            //initialize
            container[k] += 1;
            baseNum = anArray[k];
            wingNum = anArray[k];

            for (var i = 1; i < anArray.Length; i++)
            {
                if (anArray[i]-baseNum > 1)
                {
                    k++;
                    if (wingNum > baseNum)
                    {
                        container[k + 1] += 1;
                        baseNum = wingNum;
                        wingNum = anArray[i];
                    }
                    else
                    {
                        baseNum = anArray[i];
                        wingNum = anArray[i];
                    }
                }
                else if (anArray[i]-baseNum == 1)
                {
                    wingNum = anArray[i];
                    container[k+1] += 1;
                }

                container[k] += 1;
            }

            return container.Max();
        }
    }
}
