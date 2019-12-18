using System;

namespace ConsoleApp1_fase2
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

            {

                {
                    const int leap2 = (1972 - 1948) / 4;

                    Console.WriteLine("\n");
                    Console.WriteLine(leap2);
                    Console.WriteLine("\n");

                    for (int i = 1948; i <= 1972; i += 4)
                    {

                        Console.WriteLine(i);
                    }

                }

            }
        }
    }
}
