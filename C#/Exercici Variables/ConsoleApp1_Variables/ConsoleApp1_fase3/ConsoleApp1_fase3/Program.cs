using System;

namespace ConsoleApp1_fase3
{
    class Program
    {
        static void Main(string[] args)
        {
            //--Fase 3-
            //Starting in 1948 you have to do a loop for and show the years of transfer until you reach your year
            //of birth(0.75 points)
            //ATTENTION! You must change the type of variable from 1948 to be able to modify it.
            //Create a bool variable that will be true if the birth year is transfer or false if it is not. (0.75 points)
            //If the bool variable is true, you must display a phrase where you say it by console, if it is
            //false will show the relevant phrase.Create two string variables to save the phrases. (1.5 points)

                {
                int birthday = 1972;

                Console.WriteLine("\n\nWrite a year:    ");
                birthday = int.Parse(Console.ReadLine());
                bool leap = false;
                if (birthday % 4 == 0)
                {
                    leap = true;
                }
                string tex1, text2;
                tex1 = "\nCongratulations ¡¡¡ your year  is leap";
                text2 = "\nso sorry ,your year is not leap , try again...";
                if (leap == true)
                {
                    Console.WriteLine(tex1);
                }
                else
                {
                    Console.WriteLine(text2);
                }

            }
        }
    }
}
