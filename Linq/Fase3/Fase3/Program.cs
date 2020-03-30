using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Fase3
{
    /*--Fase 3--
    By doing a linq query, save in an array which numbers are larger than 5 and in another array which
    they are smaller. (1.5 points)
    Show the two arrays by console. (1 point)*/

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4 };

            IEnumerable<int> myLinQuery = from number in numbers
                                          where number < 5
                                          select number;

            int[] smallers = new int[myLinQuery.Count()];

            int  Index = 0;

            Console.Write("The smaller numbers are :  ");

            foreach (int number in myLinQuery)

            {
                smallers[Index] = number;
                Index++;

                Console.Write("" + number + " ");
            }

            IEnumerable<int> myLinQuery2 = from number in numbers
                                          where number > 5
                                          select number;

            int[]largers = new int[myLinQuery2.Count()];

            int Index2 = 0;

            Console.Write("\nThe larger numbers  are:  ");

            foreach (int number in myLinQuery2)

            {

               largers[Index2] = number;
                Index2++;

                Console.Write("" + number + " ");
            }


        }
    }
}
