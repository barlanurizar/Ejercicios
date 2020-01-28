using System;

namespace ConsoleApp1_fase4B
{
    class Program
    {       // -- Fase 4 --
            //PHASE 4(1 point)
            //Create a variable where you will find the name and surnames(all in one variable) and another where you will find the date
            //Birth separated by "/"(all in one variable).Show full name variables by console,
            //the date of birth and if the year of birth is transfer or not.
        static void Main(string[] args)
        {
            string name = "Barlan Tito";

            string surname1 = "Urizar";

            string surname2 = "Torrico";


            const int day = 01;

            const int month = 04;

            const int year = 1972;

            Console.WriteLine("\nThis is the  World of the Fantasy!!!!\n");

           
            string fullName = name + " " + surname1 + " " + surname2;

            Console.WriteLine("My full name is " + " " + fullName);


            string fullBirthday = String.Concat(day, "/", month, "/", year);

            Console.WriteLine("And my birhtday is " + " " + fullBirthday);



           
        }
    }
}
