using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq

{    //---Fase 2 ---
     //Calculate the mean, maximum, and minimum marks from the above range. (1 points)
     //Show results by console. (1 point)

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

            Console.Write("The array is:  ");
            foreach (int number in myLinQuery)

            {
                pairs[Index] = number;
                Index++;

                Console.Write("" + number + " ");
            }

            Console.Write("\nThe pairs number are : ");
            foreach (int item in pairs)

            {

                Console.Write("" + item + " ");
            }

            var largest = pairs.Max();

            Console.Write("\nThe largest number is : " + largest + " ");

            var avg = pairs.Average();

            Console.Write("\nThe average is : " + avg + " ");

            var minimun = pairs.Min();

            Console.Write("\nThe minimun is : " + minimun + "");
            
            {
                IEnumerable<int> myLinQuery2 =
                              from number in numbers
                              where number % 2 == 5
                              select number;

                int[] minimus = new int[myLinQuery.Count()];
                

                int Index2 = 0;

                Console.Write(" ");
                foreach (int number in myLinQuery2)

                {
                    minimus[Index2] = number;
                    Index++;
                    Console.Write("" + number + " ");
                }

                
            }
        }
        
    }

}

    



        
    
