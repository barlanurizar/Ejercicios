using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_fase_1

    // --Fase 1--
    //Exercise:
    //The exercise consists in showing by console how many times each letter of your name appears with different variants(phases).
    //Create an array of characters(char[]) with your name where each position corresponds to a letter.
    //Make a loop that travels through this array and show consoles for each of the letters.

{
    class Program
    {
        const string NAME = "BARLAN";
        

        static void Main(string[] args)

        

        {
            Break_downNameArray();
            Console.WriteLine();

        }

        static void Break_downNameArray()
        {

            char[] name;
            name = NAME.ToCharArray();

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);

            }



              
        }
    }
}

       
        
        
        

           

        

        


        

    
      
    


