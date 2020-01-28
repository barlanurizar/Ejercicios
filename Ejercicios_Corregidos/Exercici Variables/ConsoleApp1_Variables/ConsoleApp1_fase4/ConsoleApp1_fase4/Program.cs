using System;

namespace ConsoleApp1_fase4
{
    class Program
    {
        static void Main(string[] args)
        {
            // -- Fase 4 --
            //PHASE 4(1 point)
            //Create a variable where you will find the name and surnames(all in one variable) and another where you will find the date
            //Birth separated by "/"(all in one variable).Show full name variables by console,
            //the date of birth and if the year of birth is transfer or not.

            {
                

                Console.WriteLine("\n\nTell me , what is your fullname?:   ");
                string x =Console.ReadLine();               
                Console.WriteLine("\n\nTell me , when is your birthday?:    ");
                string year =Console.ReadLine();


                string str = "\nMy name is " + x;
                System.Console.WriteLine(str);
                string sdr = "I was born in  " +"  "+ year ;
                System.Console.WriteLine(sdr);


                int num;

                Console.WriteLine("Introduce  your birthday again:   ");
                
                num = int.Parse(Console.ReadLine());

                if ((num % 400 == 0) || (num % 100 == 0) || (num % 4 == 0))
                {
                    Console.WriteLine(" \n\n\n Your birthday is a leap year ...! ");
                }
                else
                {
                    Console.WriteLine("\n\n\n  Your birthday is  not a leap year ...!");
                }


               

            }



        }
    }
}
