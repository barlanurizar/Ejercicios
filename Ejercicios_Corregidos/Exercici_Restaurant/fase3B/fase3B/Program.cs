using System;
using System.Collections.Generic;

namespace fase3B
{
    class Program
    {
        static void Main(string[] args)
        {
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
            

            /* The exercise consists of displaying a restaurant menu where 
             * we will add different dishes and then choose what we want
              * to eat. Once this is done, the price of the meal must be calculated, 
             * the program will tell us with which tickets we must pay.
           
             PHASE 1 
             Create an int variable for each of the tickets that exist from € 5 to € 500, 
            you must create another variable to save the total price of the meal. 
           */

            #region Fase1

            int[] divisas = new int[8] { 500, 100, 50, 20, 10, 5, 2, 1 };

            int priceTotalMenu = 0;

            Console.WriteLine("\n¿How many dishes will today's menu consist of??");
            int numDishes = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the name of the " + numDishes + " today's menu dishes");

            /*Create two arrays, one where we will save the menu(5 dishes) 
             * and another where we will save the price of each plate. */

            string[] dishesMenu = new string[numDishes];

            int[] pricedishesMenu = new int[dishesMenu.Length];

            #endregion



            #region Fase2

            // PHASE 2 (3 points)
            // With a for loop we must fill in the two previously created arrays.
            // We will add the name of the dish and then the price. (1 point)

            for (int i = 0; i < dishesMenu.Length; i++)
            {
                Console.WriteLine("Enter the name of the plate number " + (i + 1));
                dishesMenu[i] = Console.ReadLine();

                Console.WriteLine("Price Dish númber " + (i + 1));
                pricedishesMenu[i] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine();
            Console.WriteLine("MENU RESTAURANT:" + "\r\n" + "Today's menu is as follows: " + "\r\n");

            for (int i = 0; i < dishesMenu.Length; i++)
            {
                Console.WriteLine(" Dish " + (i + 1) + ": " + dishesMenu[i] + " Price: " + pricedishesMenu[i] + " EUR" + "\r\n");
            }

            Console.WriteLine();

            /*Once the two arrays are filled we will have to show them and ask what they want to eat, 
             * we will save the information in a List using a loop while. (1 point)

             We will have to ask if you want to continue ordering food. You can use the system(1: Yes / 0: No), 
             therefore you must create another int variable

             To save the information. (1 point) */

            Console.WriteLine("¿What dishes do you want to choose? " + "\r\n");

            List<string> election = new List<string>();

            string electionitem = "";
            bool seguir = true;
            string continuar;

            while (seguir)
            {
                Console.WriteLine("Introduce the name of the dish");
                electionitem = Console.ReadLine();
                election.Add(electionitem);

                Console.WriteLine("¿Anything else? 1: Si / 0: No");
                continuar = Console.ReadLine();
                if (continuar == "1")
                {
                    seguir = true;
                }
                else
                    seguir = false;
            }

            Console.WriteLine();
            Console.WriteLine("The selected dishes are:");
            foreach (string s in election)
            {

                Console.WriteLine(s);
            }

            #endregion

            #region Fase3
            /*Una vez hemos acabado de pedir la comida, tendremos que comparar la lista con el array que hemos hecho al principio. En caso de que la información 
             que hemos introducido en la List coincida con la del array, tendremos que sumar el precio del producto solicitado; en el caso contrario tendremos que 
             mostrar un mensaje que diga que el producto que hemos pedido no existe.*/

            for (int i = 0; i < election.Count; i++)
            {
                bool control = false;
                var jfound = 0;
                for (int j = 0; j < dishesMenu.Length; j++)
                {

                    if (election[i] == dishesMenu[j])
                    {
                        control = true;
                        jfound = j;
                    }
                }

                if (control)
                {
                    priceTotalMenu = priceTotalMenu + pricedishesMenu[jfound];
                }
                else
                {
                    Console.WriteLine("\r\n" + election[i] + " we don't have on the  menu");
                }

            }

            Console.WriteLine();
            Console.WriteLine("\r\n" + "Let's go to get by: " + priceTotalMenu + " EUR");

            #endregion

            #region Fase4
            //Una vez hecho esto se deberá calcular el precio de la comida el programa nos dirá con qué billetes debemos pagar.


            Console.WriteLine("How would you like to pay? Introuce the  import  in  EUR");
            int cash = int.Parse(Console.ReadLine());

            int back = (cash - priceTotalMenu);

            int[] change = new int[divisas.Length];

            Console.WriteLine("\r\n" + "Total invoice in EUR: " + priceTotalMenu + "\r");
            Console.WriteLine("Amount delivered in EUR: " + cash + "\r");
            Console.WriteLine("Amount to back in EUR: " + back + "\r\n");

            do
            {

                for (var i = 0; i < divisas.Length; i++)
                {

                    if (back >= divisas[i])
                    {
                  
                        change[i] = back / divisas[i];

                        back = (back - (change[i] * divisas[i]));
                    }

                }

            } while (back > 0);
            Console.WriteLine();


            for (int i = 0; i < divisas.Length; i++)
            {
                if (change[i] != 0)
                {
                    Console.WriteLine("The amount in tickets of " + divisas[i] + " euros is: " + change[i] + "\n");
                }
            }

            #endregion

            Console.ReadLine();

        }
    }
}
