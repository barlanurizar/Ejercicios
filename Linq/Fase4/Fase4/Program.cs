using System;
using System.Collections.Generic;
using System.Linq;

namespace Fase4
{
    //Using linq queries, display names that are longer than 6 letters per console. (1 point)
    //(1 point)
    //PHASE 4 (3.5 points)
    //In this phase we will use an array with names: (David, Sergio, Maria, Laura, Oscar, Julia, Oriol)
    //Create an array with the names of the statements. (0.5 points)
    //Using linq queries, display the names of the letters that start with the letter "O". (1 point)
    //Using linq queries, display console names in descending order of the array.
   /* public class Names
    {
        public string  name { get; set;}

    }*/
    class Program
    {
        static void Main(string[] args)
        {
           

            string[] names = new string[] { "David", "Sergio", "Maria", "Laura", "Oscar", "Julia", "Oriol" };

            IEnumerable<string> myLinquery = from o in names
                                             where o.Contains("O")
                                             select o;
            

            string[] nameof = new string[myLinquery.Count()];

            int Index = 0;

            Console.Write("\nThe names with  O  are :  ");

            foreach (var name in myLinquery)
            {
                nameof[Index] = name;
                Index++;

                Console.Write(" " + name + "  " );

            }

            IEnumerable<string> myLinQuery2 = from o in names
                                             where o.Length ==6
                                             select o;

            string[] length = new string[myLinQuery2.Count()];

            int Index2 = 0;
          
            Console.Write("\nThe names with 6 letters are :  is only ");

            foreach (string name in myLinQuery2)
            {
                length[Index2] = name;
                Index2++;

                Console.Write("  " + name + "  ");

            }

            IEnumerable<string> myLinQuery3 = from o in names
                                              where o.Length < 7 && o.Length >1
                                              orderby length
                                              select o;

            string[] orderby = new string[myLinQuery3.Count()];

            int Index3 = 0;


            Console.WriteLine("\nThe names in order descendent are :   ");
            foreach (string name in myLinQuery3)
            {
                orderby[Index3] = name;
                Index3++;
                
                Console.WriteLine((name));

            }

        }



        

    }
        
       
}
