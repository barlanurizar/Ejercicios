using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

//--Fase 3 (5 points)--
//Once we have finished ordering the food, we will have to compare the list with the array we have made to the
//beginning In case the information that we have entered in the List matches that of the array, we will have to
//add the price of the requested product; in the opposite case we will have to show a message that says that
//Product we have requested does not exist.

namespace fase3

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

            int coin, B500, B200, B100, B50, B20, B10, B5;
            B500 = 0;
            B200 = 0;
            B100 = 0;
            B50 = 0;
            B20 = 0;
            B10 = 0;
            B5 = 0;
            coin = 0;

            int mesFood;
            bool follow = true;
            bool dishExists = false;
            bool dishExists1 = false;
            bool dishExists2 = false;

            string[] arrayMenu = new string[1];
            string[] arrayMenu1 = new string[1];
            int[] arrayPrice = new int[1];
            int[] arrayPrice1 = new int[1];
            string[] arrayMenu2 = new string[1];
            int[] arrayPrice2 = new int[1];


            List<string> listFood = new List<string>();

            for (int i = 0; i < arrayMenu.Length; i++)
            {
                Console.Write("\nGood afternon, What would you like to appetizer: ");
                arrayMenu[i] = Console.ReadLine();
                Console.Write("\nPrice of the appetizer: ");
                arrayPrice[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arrayMenu1.Length; i++)
            {
                Console.Write("\nIntroduce your  maincourse: ");
                arrayMenu1[i] = Console.ReadLine();
                Console.Write("\nPrice of the maincourse: ");
                arrayPrice1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arrayMenu2.Length; i++)
            {
                Console.Write("\nIntroduce your  dessert: ");
                arrayMenu2[i] = Console.ReadLine();
                Console.Write("\nPrice of the dessert: ");
                arrayPrice2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arrayMenu.Length; i++)
            {
                Console.Write("\nMenu of appetizer: \n");
                Console.Write(arrayMenu[i] + ": " + arrayPrice[i] + "€" + " \n");
            }


            for (int i = 0; i < arrayMenu1.Length; i++)
            {
                Console.Write("\nMenu of Maincourse: \n");
                Console.Write(arrayMenu1[i] + ": " + arrayPrice1[i] + "€" + " \n");
            }
            for (int i = 0; i < arrayMenu2.Length; i++)
            {
                Console.Write("\nMenu of dessert: \n");
                Console.Write(arrayMenu2[i] + ": " + arrayPrice2[i] + "€" + " \n");
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

            foreach (var item in listFood)
            {
                for (int i = 0; i < arrayMenu.Length; i++)
                {
                    if (item == arrayMenu[i])
                    {
                        coin += arrayPrice[i];
                        dishExists = true;
                    }

                }
               

                foreach (var item1 in listFood)
                {
                    for (int i = 0; i < arrayMenu1.Length; i++)
                    {
                        if (item == arrayMenu1[i])
                        {
                            coin += arrayPrice1[i];
                            dishExists1 = true;
                        }

                    }
                  

                    foreach (var item2 in listFood)
                    {
                        for (int i = 0; i < arrayMenu2.Length; i++)
                        {
                            if (item == arrayMenu2[i])
                            {
                                coin += arrayPrice2[i];
                                dishExists2 = true;
                            }

                        }
                        if (!dishExists)
                        if (!dishExists1)
                        if (!dishExists2)
                        {
                            Console.WriteLine("\nWe don't have this course: " + item);
                        }
                        dishExists2 = false;
                        
                    }
                    Console.WriteLine("\nLet's me see , all is :  " + coin + "€");


                    Console.Read();
                }
            }

        }
    }

}

 

        

        
    


            