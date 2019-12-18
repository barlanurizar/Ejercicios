using System;

namespace ConsoleApp_Ciudades_fase1
{
    class Program
    {
        static void Main(string[] args)
        {
            //-- Fase 1 --
            
            //Create six empty string types variables. (0.5 points)
            //Ask for the console to enter the names. (0.5 points)
            //Enter the following names of cities(Barcelona, Madrid, Valencia, Malaga, Cádiz, Santander) for
            //keyboard(0.5 points)
            //Show by name the name of the 6 cities. (0.5 points)

            {
                string city1 = "";
                string city2 = "";
                string city3 = "";
                string city4 = "";
                string city5 = "";
                string city6 = "";


                Console.WriteLine("Introduce name of the city: ");
                city1 = Console.ReadLine();

                Console.WriteLine("Introduce name of the city: ");
                city2 = Console.ReadLine();
                Console.WriteLine("Introduce name of the city: ");
                city3 = Console.ReadLine();
                Console.WriteLine("Introduce name of the city: ");
                city4 = Console.ReadLine();
                Console.WriteLine("Introduce name of the city: ");
                city5 = Console.ReadLine();
                Console.WriteLine("Introduce name of the city: ");
                city6 = Console.ReadLine();

                Console.WriteLine(city1);
                Console.WriteLine(city2);
                Console.WriteLine(city3);
                Console.WriteLine(city4);
                Console.WriteLine(city5);
                Console.WriteLine(city6);

            }

            {

                Console.WriteLine("CONGRATULATIONS YOU DO IT!");
            }
        }
    }
}
