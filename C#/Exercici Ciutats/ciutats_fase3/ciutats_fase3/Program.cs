using System;
//--Fase 3 (3 points)--
//Change the "a" vowels of city names by number 4 and save the names modified in a new one
//array(ArrayModified cities). (2 points)
//Show by console the modified array and sorted alphabetically. (1 point)


namespace ciutats_fase3
{
    class Program
    {
        const int levelcities = 7;

        static void Main(string[] args)
        {
            string city = "";
            string city1 = "";
            string city2 = "";
            string city3 = "";
            string city4 = "";
            string city5 = "";
            string city6 = "";

            string[] arrayCitiesNumbers = new string[levelcities];
            Console.WriteLine("Introduce the name of the city :  ");
            city = Console.ReadLine();
            Console.WriteLine("Introduce the name of the city :  ");
            city1 = Console.ReadLine();
            Console.WriteLine("Introduce the name of the city :  ");
            city2 = Console.ReadLine();
            Console.WriteLine("Introduce the name of the city :  ");
            city3 = Console.ReadLine();
            Console.WriteLine("Introduce the name of the city :  ");
            city4 = Console.ReadLine();
            Console.WriteLine("Introduce the name of the city :  ");
            city5 = Console.ReadLine();
            Console.WriteLine("Introduce the name of the city :  ");
            city6 = Console.ReadLine();

            arrayCitiesNumbers[0] = city.Replace('a', '4');
            arrayCitiesNumbers[1] = city1.Replace('a', '4');
            arrayCitiesNumbers[2] = city2.Replace('a', '4');
            arrayCitiesNumbers[3] = city3.Replace('a', '4');
            arrayCitiesNumbers[4] = city4.Replace('a', '4');
            arrayCitiesNumbers[5] = city5.Replace('a', '4');
            arrayCitiesNumbers[6] = city6.Replace('a', '4');

            Array.Sort(arrayCitiesNumbers);

            for (int i = 0; i < levelcities; i++)
            {
                Console.WriteLine(arrayCitiesNumbers[i]);
            }
            Console.Read();

        }
}   }
