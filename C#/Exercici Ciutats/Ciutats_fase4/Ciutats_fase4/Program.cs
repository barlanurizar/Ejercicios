using System;
using System.Linq;

//--Fase 4--
//Create a new array for each of the cities we have.The size of the new arrays will be the
//Length of each string (string nomCiutat.Length). (0.5 points)
//Fill in the new arrays letter by letter(2 points)
//Show the new arrays with inverted names for console(Ex: Barcelona - anolecreB). (0.5 points)

namespace Ciutats_fase4
{
    class Program
    {
        

        static void Main(string[] args)
        {

            string Barcelona = "BARCELONA";
            string Madrid = "MADRID";
            string Valencia = "VALENCIA";
            string Malaga = "MALAGA";
            string Oñati = "OÑATI";
            string Cadiz = "CADIZ";
            string Santander = "SANTANDER";

            char[] arrayBarcelona = new char[Barcelona.Length];
            char[] arrayMadrid = new char[Madrid.Length];
            char[] arrayValencia = new char[Valencia.Length];
            char[] arrayMalaga = new char[Malaga.Length];
            char[] arrayOñati = new char[Oñati.Length];
            char[] arrayCadiz = new char[Cadiz.Length];
            char[] arraySantander = new char[Santander.Length];


            arrayBarcelona = (Barcelona.Reverse()).ToArray();
            arrayMadrid = (Madrid.Reverse()).ToArray();
            arrayValencia = (Valencia.Reverse()).ToArray();
            arrayMalaga = (Malaga.Reverse()).ToArray();
            arrayOñati = (Oñati.Reverse()).ToArray();
            arrayCadiz = (Cadiz.Reverse()).ToArray();
            arraySantander = (Santander.Reverse()).ToArray();


            PrintArray(arrayBarcelona);
            PrintArray(arrayMadrid);
            PrintArray(arrayValencia);
            PrintArray(arrayMalaga);
            PrintArray(arrayOñati);
            PrintArray(arrayCadiz);
            PrintArray(arraySantander);

            Console.ReadKey();
        }
        static void PrintArray(char[] cities)
        {
            foreach (char item in cities)
            {
                Console.Write(item);
            }
            Console.Write(", ");
        }



    }
}

     






       




            


        
    

