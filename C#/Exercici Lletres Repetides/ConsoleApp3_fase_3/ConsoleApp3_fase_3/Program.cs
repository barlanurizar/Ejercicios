using System;
using System.Collections.Generic;

namespace ConsoleApp3_fase_3
{
    //FASE 3
    //Store in a dictionary both the letters in the list and the number of times they appear

    class Program
    {
        static void Main(string[] args)
        {
            List<char> lista_char = new List<char>() { 'B', 'A', 'R', 'L', 'A', 'N' };
            lista_char.Add('1');
            lista_char.Add('2');
            lista_char.Add('1');
            lista_char.Add('1');
            lista_char.Add('2');
            lista_char.Add('1');

            Dictionary<char, int> dict = new Dictionary<char, int>();
           
            for (int i = 0; i < lista_char.Count; i++)
            {
                Console.WriteLine(lista_char[i]);

            }
            Console.WriteLine();
            for (int i = 0; i < lista_char.Count; i++)
            {
                var currentcharacter = lista_char[i];
                if (!dict.ContainsKey(currentcharacter))
                {
                    dict.Add(currentcharacter, 1);
                }
                else
                {
                    dict[currentcharacter] += 1;
                }
            }


        }
    }
}
