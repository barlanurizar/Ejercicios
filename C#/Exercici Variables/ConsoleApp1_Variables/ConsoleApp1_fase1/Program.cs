using System;

namespace ConsoleApp1_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //-- Fase 1 --
            //PHASE 1(3 points)
            //Create three string variables and initialize them with the relevant data(name, surname 1, surname 2).
            //Create three initial and int variables with the relevant data(day, month, year).
            //Show by window the string variables concatenating them in this order(last name + cognom2, +name).
            //Show by window the variables int concatenating them with "/" between each one of them.
            {
                {
                    int day = 1;
                    int month = 04;
                    int year = 1972;

                    string name1 = "Barlan";
                    string surname1 = "Urizar";
                    string surname2 = "Torrico";


                    Console.WriteLine(surname1 + " " + surname2 + ", " + name1);

                    Console.WriteLine("\n"  + day + "/" + month + "/" + year);


                }

             
            }
        }
 }  }
