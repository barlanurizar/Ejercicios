using System;
using System.Collections.Generic;

namespace fase2
{
    class Program
    {
        static void Main(string[] args)
        {
            // -- fase2 --

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

            int coin, B5, B10, B20, B50, B100, B500;
            coin = 0;
            B5 = 0;
            B10 = 0;
            B20 = 0;
            B50 = 0;
            B100 = 0;
            B500 = 0;

            int mesFood;
            bool follow = true;
            string[] arrayMenu = new string[1];
            int[] arrayPrice = new int[1];

            /*With a loop we will have to fill out the two arrays previously created.We will add the name of the dish and then
            the price. (1 point)
            ● Once the two arrays are full we will have to show them and ask what they want to eat, we will keep the
            Information in a List using a while loop. (1 point)
            ● We have to ask if you want to continue asking for food.You can use the system(1: Yes / 0: No), therefore
            you will need to create another variable int to save the information. (1 point)*/
            
            List<string> listFood = new List<string>();

            for (int i = 0; i < arrayMenu.Length; i++)
            {
                Console.Write("\nGood afternon, What would you like to appetizer: ");
                arrayMenu[i] = Console.ReadLine();
                Console.Write("\nPrice of the appetizer: ");
                arrayPrice[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arrayMenu.Length; i++)
            {
                Console.Write("\nMenu of appetizer: \n");
                Console.Write(arrayMenu[i] + ": " + arrayPrice[i] + "€" + " \n");
            }

            
            while (follow)
            {
                Console.Write("\nwhat do you want to eat? \n");
                listFood.Add(Console.ReadLine());
                Console.Write("\nAnything else? (1:Si / 0:No): ");
                mesFood = int.Parse(Console.ReadLine());

                if (mesFood == 0)
                {
                    follow = false;
                }
            }

        }

    }
}

