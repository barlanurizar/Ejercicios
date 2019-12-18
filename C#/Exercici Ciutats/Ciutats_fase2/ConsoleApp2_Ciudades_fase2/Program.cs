using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//--Fase 2 (2 points)--
//Once we have the names of the cities stored in variables, we will have to pass the information to an array
//(arrayCiutats). (1 point)
//When we have the full array, we will have to show by console the name of the cities sorted by order
//alphabetic(1 point)

namespace ConsoleApp_Ciudades_fase2
{
    class Program
    {
        const int maxCities = 6;

        static void Main(string[] args)

        {

            string city = "";
            string city2 = "";
            string city3 = "";
            string city4 = "";
            string city5 = "";
            string city6 = "";

            string[] arrayCities = new string[maxCities];

            Console.WriteLine("Introduce a name of a city:   ");
            city = Console.ReadLine();
            Console.WriteLine("Introduce a name of a city:   ");
            city2 = Console.ReadLine();
            Console.WriteLine("Introduce a name of a city:   ");
            city3 = Console.ReadLine();
            Console.WriteLine("Introduce a name of a city:   ");
            city4 = Console.ReadLine();
            Console.WriteLine("Introduce a name of a city:   ");
            city5 = Console.ReadLine();
            Console.WriteLine("Introduce a name of a city:   ");
            city6 = Console.ReadLine();

            arrayCities[0] = city;
            arrayCities[2] = city2;
            arrayCities[3] = city3;
            arrayCities[4] = city4;
            arrayCities[5] = city5;
            arrayCities[6] = city6;

            Array.Sort(arrayCities);

            Console.WriteLine("\n Cities by order alphabetics:  ");

            for (int i = 0; i < maxCities; i++)
            {
                Console.WriteLine(arrayCities[1]);
            }

            Console.Read();

        }
    }
}
