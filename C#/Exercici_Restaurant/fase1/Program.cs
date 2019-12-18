using System;
using System.Collections.Generic;

namespace Exercici_Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            //fase1

            //-- Restaurant menu presentation --

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("");
            Console.WriteLine("                 WELCOME TO SAINT PETER RESTAURANT\n");
            Console.WriteLine("                         STARTER\n");
            Console.WriteLine("         1.-Orange salad with fresh cheese and onions..........9€");
            Console.WriteLine("         2.-Salad wiht salmon, tartar sauce....................9€");
            Console.WriteLine("         3.-Foie mousse salad wiht pistachios..................9€\n");
            Console.WriteLine("                         MAIN COURSE\n");
            Console.WriteLine("         4.- Tomato with belly, salted tuna and fresh sprouts...10€");
            Console.WriteLine("         5.-Taperia Hispania Salad...............................10€");
            Console.WriteLine("         6.-Zucchini Carpaccio wiht tuna turnk and chrunchy .....10€\n");
            Console.WriteLine("                         DESSERT\n");
            Console.WriteLine("         7.-Chocolate cake wiht vanilla cice cream from tahiti....3€");
            Console.WriteLine("         8.-Caramelized tosted egg and brioche torrija ...........3€");
            Console.WriteLine("         9.-Almond cake and meringue..............................3€");

            
            //Create an int variable for each of the money that exist from € 5 to € 500, 
            //create another variable to save the total price of the meal
            

            int coin, B5, B10, B20, B50, B100, B500;
            coin = 0;
            B5 = 0;
            B10 = 0;
            B20 = 0;
            B50 = 0;
            B100 = 0;
            B500 = 0;

            //Create two arrays, one where we will save the menu(5 dishes) and another where we will save the price of each
            //plate. 

            string[] arrayMenu = new string[1];
            int[] arrayPrice = new int[1];

        
            List<string> listFood = new List<string>();

            for (int i = 0; i < arrayMenu.Length; i++)
            {
                Console.Write("\nGood afternon, What would you like to appetizer: ");
                arrayMenu[i] = Console.ReadLine();
                Console.Write("\nPrice of the appetizer: ");
                arrayPrice[i] = int.Parse(Console.ReadLine());
            }

        }

    }
}
