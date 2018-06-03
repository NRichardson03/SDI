using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Richardson_Nathaniel_ResturantCalc
{

    //created by nathaniel richardson, owned
    // Kinda late I was in hospital so April 8th, 2018
    //The resturant calc thingamjig
    class Program
    {
        // string course1 = "This is a String";
        //char char1;
        // convert string to int || int name = int.parse(varname)
       
        static void Main(string[] args)

            //blah blah hello world gettin some values from the user
        {
            Console.WriteLine("Hello, please enter the price of your first meal!");
            string firstMeal = Console.ReadLine();
            Console.WriteLine("\n Thank you! Please enter the price of your second meal!");
            string secondMeal = Console.ReadLine();
            Console.WriteLine("\n Thank you! Please enter the price of your third and final meal!");
            string thirdMeal = Console.ReadLine();


            // oh snap seclaring the first decimals converstion from strings
            decimal firstMealint = decimal.Parse(firstMeal);
            decimal secondMealint = decimal.Parse(secondMeal);
            decimal thirdMealint = decimal.Parse(thirdMeal);


            //Interacting with the user through console and totally scoping the value of their meals
            Console.WriteLine("Thank you for entering the values of your meal \n Will you please tell me what to tip based on how good your service was?( 1 - 100 based on satisifaction)");
            string firstTip = Console.ReadLine();
            Console.WriteLine("Thanks, now for the second meal please?");
            string secondTip = Console.ReadLine();
            Console.WriteLine("Finally, I need the third meal?");
            string thirdTip = Console.ReadLine();


            // math stuffs to convert strings into decimals zzz boring
            decimal firstTipint = decimal.Parse(firstTip);
            decimal secondTipint = decimal.Parse(secondTip);
            decimal  thirdTipint = decimal.Parse(thirdTip);

            //dividng the decimals to get an equal percentage for the tip based out of 100
            decimal mealTip1 = firstMealint + firstTipint / 100;
            decimal mealTip2 = secondMealint +secondTipint / 100;
            decimal mealTip3 = thirdMealint +thirdTipint / 100;




            //doing the part where I write to the screen
            Console.WriteLine("The total cost for meal one is:" + mealTip1 + " The second is: " + mealTip2 + ", and the third meal is" + mealTip3 + ".");
            Console.WriteLine("Your total bill, with tip added in is:" + (mealTip1 + mealTip2 + mealTip3));
            Console.WriteLine("The total cost of all the tips your waiter will make is" + ((firstTipint / 100)+(secondTipint / 100)+(thirdTipint / 100)));
            Console.WriteLine("If you wanted to cost-share the price per person would be "+(mealTip1+mealTip2+mealTip3/3)+" from each person");

       



            Console.WriteLine("press any key then enter to exit");
            string exit = Console.ReadLine();




        }
    }
}
