using System;
using System.Collections.Generic;

namespace ConsoleApp4_fase_4
{
    //-- Fase 4 --
    //Create another list with your last name where each position corresponds to a letter.
    //Merge the two lists into one.Additionally, add a position with an empty space between the first and the second.That is, we start from the list name and surname and when we finish the execution we will only have one that will be called FullName.
    //FullName: ['N', 'A', 'M', 'E', '', 'S', 'U', 'R', 'N', 'A', 'M', 'E']

    class Program
    {
        static void Main(string[] args)
        {
            

                List<char> name = new List<char>() { 'B', 'A', 'R', 'L', 'A', 'N' };

                List<char> surname = new List<char>() { 'U', 'R', 'I', 'Z', 'A', 'R' };

                List<char> fullname = new List<char>();

                for (int i = 0; i < name.Count; i++)
                {
                    fullname.Add(name[i]);
                }

                fullname.Add(' ');

                for (int j = 0; j < surname.Count; j++)
                {
                    fullname.Add(surname[j]);
                }

                fullname.Add(' ');

                for (int k = 0; k < fullname.Count; k++)
                {
                    Console.Write(fullname[k]);
                }
            
        }
     

        
    }
}
