using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Richardson_Nathaniel_CountCart
{

    // Nathaniel Richardson Count Cart
    //This class
    //Sunday April 15 2018

    // while(!double.TryParse(fakeGift, out test))
    //    { Console.WriteLine("You may only enter numbners, please try again enter your price now:");
    //      fakeGift = Console.ReadLine();
    //}
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome to Count Cart!
            double test;
            int num_items = 4;
            string[] items = new string[] { "snack", "drink", "vegetable", "meat", "drink", "snack", "vegetable", "snack", "drink", "drink" };
            Console.WriteLine(" Welcome to your virtual shopping cart\n");
            Console.WriteLine("Please, select an item: \n	Choose	(1)	for	Snacks\n (2)for Drinks\n (3) for Vegetables \n (4) for Meats ");
            string item_Get = Console.ReadLine();
            //determine if text is right 
            while (!double.TryParse(item_Get, out test))
            {
                Console.WriteLine("You must type a number from the menu not a letter, please make your selection again and press enter");
                item_Get = Console.ReadLine();

            }
            //if it is parse
            double item_GP = double.Parse(item_Get);
            //again determine if entered right
            while (item_GP <= 0 || item_GP > num_items)
            {
                Console.WriteLine("You must enter a number that corresponds with something on the list, please make your selection again and press enter");
                item_Get = Console.ReadLine();
                item_GP = double.Parse(item_Get);
            }
            //starting the for loop
            int amount_Times = 0;
            for (int a = 0; a <= 9; a++)
            {
                // make something that will match the selection to words
                if (item_GP == 1)
                {
                    if (items[a] == "snack")
                    {
                        amount_Times = amount_Times + 1;
                    }
                }
                    if (item_GP == 2)
                    {
                        if (items[a] == "drink") { amount_Times = amount_Times + 1; }
                    }
                if (item_GP == 3)
                {
                    if (items[a] == "vegetable") { amount_Times = amount_Times + 1; }
                }
                     if (item_GP == 4)
                        {
                            if (items[a] == "meat") { amount_Times = amount_Times + 1; }
                        }
                    }
                    


                //printing the results
                int tot = int.Parse(item_Get)-1;
                Console.WriteLine("In the Shopping cart there are " + amount_Times + " " + items[tot] + "");
                Console.ReadKey();


            }
        }
    }

