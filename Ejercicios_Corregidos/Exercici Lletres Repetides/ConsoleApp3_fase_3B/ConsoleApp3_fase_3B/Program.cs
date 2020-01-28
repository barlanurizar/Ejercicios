using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3_fase_3B
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary <char, int>();

            var characters = "BARLAN".ToCharArray();


            for (var i = 0; i < characters.Length; i++)
            {
                var currentCharacter = characters[i];
                currentCharacter = char.ToUpper(currentCharacter);

                if (!dict.ContainsKey(currentCharacter))
                    dict.Add(currentCharacter, 1);
                else
                    dict[currentCharacter] += 1;
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"The letter: {item.Key} show: {item.Value} times ");
            }

            Console.ReadKey();
        }
    }
}
