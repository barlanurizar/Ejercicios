using System;

namespace ConsoleApp1_fase3B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nGuess if you was born  in a leapYear, tryy ittt!!!!");
            Console.WriteLine("\n");
            
            const int day = 1;

            const int month = 4;

            const int year = 1972;

            const int yearLeap = 1948;

            const int leapPeriod = 4;

            int yearl;

            for (yearl = 1948; yearl <= year; yearl += leapPeriod)
            {
               
                Console.WriteLine(yearl);
            }


            bool leap = (yearl == year);

            string textLeap = ("\nYou are a lucky , your birhtday is a leap");

            string textNotLeap = ("\nYou don't have luck, this is not leap");

            if (leap == false)
            {
                Console.WriteLine(textLeap);
            }
            else
            {
                Console.WriteLine(textNotLeap);
            }
            
        }
    }
}
