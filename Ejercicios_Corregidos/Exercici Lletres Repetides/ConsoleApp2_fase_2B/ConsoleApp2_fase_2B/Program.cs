using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2_fase_2B
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] name = { 'B', 'A', 'R', 'L', 'A', 'N' };
            
           
            List<char> listCharacters = name.ToList<char>();



            foreach (char value in listCharacters)
            {

                if (int.TryParse(value.ToString(), out int i))

                    Console.WriteLine(value + " The names of the persons do not content numbers ");


                else
                {

                    char element = Char.ToLower(value);
                    if (element == 'a' || element == 'e' || element == 'i' || element == 'o' || element == 'u')
                        Console.WriteLine(value + " is vowel");

                    else
                        Console.WriteLine(value + " is consonant");
                }

            }
        }
    }
}
