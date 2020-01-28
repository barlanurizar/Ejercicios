using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp2_fase_2
{
    //PHASE 2
    //Change the array for a list(List<char>)
    //In the loop, if the letter is a vowel, print to the console: 'VOCAL'. However, he prints: 'CONSONANT'.
    //If you find a number, show on screen: 'Names of people do not contain numbers!'.
    
    class Program
    {
        static void Main(string[] args)
        {

                const string NAME = "BARLAN 123456789";
                const string VOWEL = "AEIOU";
                const string NUM = "0123456789";
                const string SURNAME = "URIZARTORRICO";
            
            
                foreach (var surname in SURNAME)
                {
                    if (VOWEL.IndexOf(surname) >= 0)
                    {
                        Console.WriteLine("The letter " + surname + " is vowel");
                    }
                    else if (NUM.IndexOf(surname) >= 0)
                    {
                        Console.WriteLine("The names of the persons not content numbers ");
                    }
                    else
                    {
                        Console.WriteLine("The letter " + surname + " is a consonat");
                    }

                }
                foreach (var name in NAME)
                {
                    if (NUM.IndexOf(name) >= 0)
                    {
                        Console.WriteLine(name + " People's name doesn't have  a number");
                    }
                    else if (NAME.IndexOf(name) >= 0)
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("The letter " + name + " is a consonat");
                    }

                
           
                }
        }
    }
}

