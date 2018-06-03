using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Richardson_Nathaniel_Conditionals
{
    //Nathaniel Richardson
    //Scalable Data Infastructure Week 2 Project 2
    // 04/14/2018
    class Program
    {
        static void Main(string[] args)
        {
            // problem #1 baking converter
            double ouncetoGRM = 28.34952;
            double grmtoOZ = 0.035274;

            string cmpGRM = "g";
            string cmpOZ = "oz";

            Console.WriteLine("Problem #1: Baking Converter\n");
            Console.WriteLine("Please enter the weight amount you wish to convert in numbers:\n");
            string weightAmount = Console.ReadLine();
            double weightDouble = int.Parse(weightAmount);
            Console.WriteLine(" Thank you, now please enter  g for grams or oz for ounces:\n");
            string weightType = Console.ReadLine();

            for (int i = 0; i <= 1;)
            {
                if (weightType == cmpOZ)
                {
                    double weightEnd = weightDouble * ouncetoGRM;
                    Console.WriteLine("The weight of your ounces in grams is " + weightEnd + " ounces.");
                    Console.WriteLine("\nPress any key to continue");
                    Console.ReadKey();
                    i += 2;
                }
                if (weightType == cmpGRM)
                {
                    double weightEnd = weightDouble * grmtoOZ;
                    Console.WriteLine("The weight of your grams in ounces is " + weightEnd + " ounces.");
                    Console.WriteLine("\nPress any key to continue");
                    Console.ReadKey();
                    i += 2;
                }
                else {
                    Console.Write("You did not enter a valid conversion please enter g for grams or oz for ounces (lowercase)\n");
                    weightType = Console.ReadLine();

                }

                // end of problem 1


                //Problem 2 Pizza Per Person

                Console.WriteLine("Welcome to problem #2\n");
                Console.WriteLine("\nFirst up, how many pizzas did you order?");
                string pizzaOrd = Console.ReadLine();
                double pizzaorDBL = double.Parse(pizzaOrd);
                Console.WriteLine("\nThank you, how many slices per pizza were there?");
                string slices = Console.ReadLine();
                double slicesDBL = double.Parse(slices);
                Console.WriteLine("\nGreat, how many guests will be at the party?");
                string guests = Console.ReadLine();
                double guestsINT = double.Parse(guests);
                Console.WriteLine("Finally, how many slices will each guest get?");
                string slicePER = Console.ReadLine();
                double sliceperDBL = double.Parse(slicePER);

                //the worky part
                for (int y = 0; y <= 1;)
                {
                    //define stuff
                    double pizzaCount = pizzaorDBL * slicesDBL; //pizza ordered times slices, slices total
                    double pizzaPerG = (pizzaCount / sliceperDBL) / guestsINT; // slices per gues avaliable
                    double enough = pizzaCount / pizzaPerG; // slices divided by guests to see if enough
                    double needed = ((sliceperDBL * guestsINT) - pizzaCount); //how many slices are needed
                    double extra = pizzaCount - needed;
                    if (pizzaPerG < needed)
                    {
                        double z;
                        for (z = 1; z < needed; z++) ;

                        Console.WriteLine("Sorry, you need at least " + Math.Round(z, 2) + " slices more. We require more pizza");
                        // debug line Console.WriteLine("You have " + pizzaPerG + " slices per person and we need" + sliceperDBL + ".");  //debug line for myself
                        Console.ReadKey();
                        y += 2;
                    }
                    else if (enough >= sliceperDBL)
                    {
                        Console.WriteLine("You will have enough pizza with " + (-needed) + " spare slices. ");
                        // debug purposes Console.WriteLine(needed);
                        Console.ReadKey();
                        y += 2;
                    }


                }

                //Problem #3 Tax Brackets


                double[] taxBracket = new double[] { 10, 15, 25, 28, 33, 35, 39.6 };
                Console.WriteLine("How about we find out what tax bracket you are in>\n First please enter your income and press return ");
                string userIncome = Console.ReadLine();
                double userIncDBL = double.Parse(userIncome);
                double[] income = new double[] { 9000, 37950, 91900, 191650, 416700, 418400, 418400 };
                int tier;



                // longer section than it needed to be because I could't get my for loop to properly work and figured better to write it out manually to see what my problem was. 
                if (userIncDBL <= income[0])
                {
                    tier = 1;
                    Console.WriteLine("You have an income of " + userIncDBL + " which puts you in tier" + tier + " and your tax rate is " + taxBracket[0] + ".");
                    Console.ReadKey();


                }



                else if (userIncDBL <= income[1])
                {
                    tier = 2;
                    Console.WriteLine("You have an income of " + userIncDBL + " which puts you in tier" + tier + " and your tax rate is " + taxBracket[1] + ".");
                    Console.ReadKey();
                }




                else if (userIncDBL <= income[2])
                {
                    tier = 3;
                    Console.WriteLine("You have an income of " + userIncDBL + " which puts you in tier" + tier + " and your tax rate is " + taxBracket[2] + ".");
                    Console.ReadKey();
                }


                else if (userIncDBL <= income[3])
                {
                    tier = 4;
                    Console.WriteLine("You have an income of " + userIncDBL + " which puts you in tier" + tier + " and your tax rate is " + taxBracket[3] + ".");
                    Console.ReadKey();
                }

                else if (userIncDBL <= income[4])
                {
                    tier = 5;
                    Console.WriteLine("You have an income of " + userIncDBL + " which puts you in tier" + tier + " and your tax rate is " + taxBracket[4] + ".");
                    Console.ReadKey();
                }

                else if (userIncDBL <= income[5])
                {
                    tier = 6;
                    Console.WriteLine("You have an income of " + userIncDBL + " which puts you in tier" + tier + " and your tax rate is " + taxBracket[5] + ".");
                    Console.ReadKey();
                }

                else if (userIncDBL >= income[6])
                {
                    tier = 7;
                    Console.WriteLine("You have an income of " + userIncDBL + " which puts you in tier" + tier + " and your tax rate is " + taxBracket[6] + ".");
                    Console.ReadKey();
                }
                //did I mention this is really taking forever. First I tried to use strings in a for loop which turned out disasterous... so I went back to doing it manually. the old code had for(a=0;a<=userIncome.Length;a++) which didn't work.

            }

            //Problem #4 Discount Double Check.... 4 assignments in one isn't cool man it really isn't.

            Console.WriteLine("\n Welcome to Problem #4 Discount Double Check\n");
            Console.WriteLine("We will check to see if your are eligible for a discount on your purchase!\n Please enter the cost of the first item in dollars:");
            string firstItem = Console.ReadLine();
            double firstItemD = double.Parse(firstItem);
            Console.WriteLine("Thank you! Now, please enter the cost of your second item:");
            string secondItem = Console.ReadLine();
            double secondItemD = double.Parse(secondItem);
            double bothItems = firstItemD + secondItemD;
            double[] discount = new double[] { .5, .10 };
            double discount5 = bothItems - (discount[0] * bothItems);
            double discount10 = bothItems - (discount[1] * bothItems);
            //double[] discountCost = new double {  bothItems - (discount[1] * bothItems)};

            // okay take the discount multiply it by the main to get discount subtract from main



            if (bothItems < 100 && bothItems>50)
                {
                Console.WriteLine("Your First item cost $" + firstItemD + " your Second item cost $" + secondItemD + " You have saved 5% Making your total order cost $" + discount5 + ".");

            }

            if(bothItems<50)
            {
                Console.WriteLine("Your First item cost $" + firstItemD + " your Second item cost $" + secondItemD + " Your total purchase is $" + bothItems + ".");
            }
            if (bothItems >= 100)
            {
                Console.WriteLine("Your First item cost $" + firstItemD + " your Second item cost $" + secondItemD + " You have saved 5% Making your total order cost $" + discount10 + ".");
            }
            Console.WriteLine("\n Press Any Key to Exit This LONG LONG ASSIGNMENT!");
            Console.ReadKey();

        }

        }
        }
    

            

                


                
           
