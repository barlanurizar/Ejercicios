using System;
using System.Collections.Generic;

namespace fase1B
{
    class Program
    {
        static void Main(string[] args)
        {
            /* The exercise consists of displaying a restaurant menu where 
             * we will add different dishes and then choose what we want
             * to eat. Once this is done, the price of the meal must be calculated, 
             * the program will tell us with which tickets we must pay.
           
             PHASE 1 
             Create an int variable for each of the tickets that exist from € 5 to € 500, 
            you must create another variable to save the total price of the meal. 
           */
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("");
            Console.WriteLine("                 WELCOME TO SAINT PETER RESTAURANT\n");
            Console.WriteLine("                         STARTER\n");
            Console.WriteLine("         1.-Orange salad with fresh cheese and onions...........9€");
            Console.WriteLine("         2.-Salad wiht salmon, tartar sauce.....................9€");
            Console.WriteLine("         3.-Foie mousse salad wiht pistachios...................9€\n");
            Console.WriteLine("                         MAIN COURSE\n");
            Console.WriteLine("         4.-Tomato with belly, salted tuna and fresh sprouts....10€");
            Console.WriteLine("         5.-Taperia Hispania Salad..............................10€");
            Console.WriteLine("         6.-Zucchini Carpaccio wiht tuna turnk and chrunchy ....10€\n");
            Console.WriteLine("                         DESSERT\n");
            Console.WriteLine("         7.-Chocolate cake wiht vanilla cice cream from tahiti..3€");
            Console.WriteLine("         8.-Caramelized tosted egg and brioche torrija .........3€");
            Console.WriteLine("         9.-Almond cake and meringue............................3€");
            #region Fase1

            int[] divisas = new int[8] { 500, 100, 50, 20, 10, 5, 2, 1 };

            

            Console.WriteLine("\n¿How many dishes will today's menu consist of??");
            int numDishess = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the name of the " + numDishess + " today's menu dishes");

            /*Create two arrays, one where we will save the menu(5 dishes) 
             * and another where we will save the price of each plate. */

            string[] dishesMenu = new string[numDishess];

            int[] preciodishesMenu = new int[dishesMenu.Length];

            #endregion
        }
    }
}
