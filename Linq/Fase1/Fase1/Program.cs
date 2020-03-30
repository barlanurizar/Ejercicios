using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq

{    //---fase 1 ---
    /*Create an array with the numbers given at the beginning of the practice. (0.5 points)
    Using linq queries store all even numbers in an array. (1 point)
    Show the even number array per console. (0.5 point)*/

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4 };

            IEnumerable<int> myLinQuery =
                            from number in numbers
                            where number % 2 == 0
                            select number;

            int[] pairs = new int[myLinQuery.Count()];

            int Index = 0;

            foreach (int number in myLinQuery)

            {
                pairs[Index] = number;
                Index++;

                Console.Write(" " + number + " ");
            }

            foreach (int item in pairs)

            {
                Console.Write(" "+ item + " " );
            }


        }

        
    }
}

