using System;

namespace ConsoleApp1_fase2B
{
    class Program
    {
        static void Main(string[] args)
        {
            // -- Fase 2 --

            //Knowing that in the year 1948 is a year of transfer:
            //Create a constant variable with the value of the year(1948).
            //Create a constant variable that you save every time there is a transfer year.
            //Calculate how many years of transfer between 1948 and your birth year and store the value
            //Resulting in a variable.
            //Show the result of the calculation on screen.

            const int yearLeap = 1948;

            const int leap = 4;

            const int birthyear = 1972;


            int yearl;

            int count = 0;

            for (yearl = yearLeap; yearl <= birthyear; yearl += leap)
            {
                count++;
            }


            {
              

                Console.WriteLine("\nThere are  {0} leap years.", count);

            }
        }
    }
}
