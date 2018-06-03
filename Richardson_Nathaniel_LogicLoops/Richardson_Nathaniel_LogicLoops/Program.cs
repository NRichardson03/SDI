using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Richardson_Nathaniel_LogicLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            // Furst Problem RIGHT HERE
            Console.WriteLine("Welcome to Making The Grade!\n");
            Console.WriteLine("We will ask you for to grades then determine if they are passing!\n");
            int a = 0;
            double test;
            string grade1;
            string grade2;

            Console.WriteLine("Please Enter the First grade:");
            grade1 = Console.ReadLine();
            Console.WriteLine("Thank you, please enter your second grade:");
            grade2 = Console.ReadLine();
            if (double.TryParse(grade1, out test) && double.TryParse(grade2, out test))
            {
                double[] grades = new double[2];

                grades[0] = double.Parse(grade1);
                grades[1] = double.Parse(grade2);
                //double gradePASS = (grades[0]+grades[1]/2)

                // if they are actual grades
                if (grades[0] <= 70 || grades[1] <= 70)
                { Console.WriteLine("One or more of the grades is failing, try harder next time."); }
                else
                { Console.WriteLine("Both grades are passing, great job!"); }
            }
            // if they entered text ignore a was using it as part of a failed test,
            if (!double.TryParse(grade1, out test))
            { a = 0; Console.WriteLine("Please Enter Numeric Values"); }
            else if (!double.TryParse(grade2, out test))
            { a = 0; Console.WriteLine("Please enter Numeric Values"); }
            else a += 2;








            Console.ReadKey();

            // start problem the dos Logical Operators Brunch 
            Console.WriteLine("We are going to see the cost of your brunch today!\n Please enter your age:");
            string age = Console.ReadLine();
            int ageINT = int.Parse(age);
            int senior = 55;
            int kid = 10;
            if (ageINT >= senior || ageINT <= kid)
            { Console.WriteLine("The Cost of your food today is $10"); }
            else { Console.WriteLine("The cost of your food today is $15"); }
            Console.ReadKey();

            // age 11 result 15
            // age 56 result 10
            //age 9 result 10
            // age 54 result 15
            // BAH HUMBUG age 33 result 15

            // start of problem 3 FOR LOOP add them up! you know this is ACTUALLY more work than my actual JOB!!!! I like it weirdly because my job isn't great.

            //double[] movies = new double[3]; // the movie collection double
            Console.WriteLine("Let's determine how big your movie collection is shall we?\n");
            Console.WriteLine("First how many DVDs do you own (number format):");
            string dvds = Console.ReadLine();
            Console.WriteLine("Awesome, now how many BluRay do you own? (number format)\n");
            string bluray = Console.ReadLine();
            Console.WriteLine("Thanks for that input, now how many ULTRA VIOLET or DIGITAL MOVIES do you own? (number format): ");
            string digital = Console.ReadLine();
            if (double.TryParse(dvds, out test) && double.TryParse(bluray, out test) && double.TryParse(digital, out test))
            {
                double[] movies = new double[3];
                
                double allmovies = 0;
              
                if(double.TryParse(dvds, out test) && double.TryParse(bluray, out test) && double.TryParse(digital,out test))
                movies[0] = double.Parse(dvds);
                movies[1] = double.Parse(bluray);
                movies[2] = double.Parse(digital);


                for (int i = 0; i <= 2; i++ )
                {

                    allmovies=allmovies+movies[i];





                }

               
                if (allmovies >= 100) {
                   
                    Console.WriteLine("Wow you have " + allmovies + " I am impressed!");
                    Console.ReadKey();
                }
                else if (allmovies < 100)
                {
                    Console.WriteLine("You have a total of " + allmovies + " movies in your collection.");
                    Console.ReadKey();
                }
               



            }
            else if (!double.TryParse(dvds, out test) || !double.TryParse(bluray, out test) || !double.TryParse(digital, out test))
            {
                a = 0; Console.WriteLine("Please Enter Numeric Values Only");
                Console.ReadKey();

            }

            // End of that one... Boy I sure am tired of looking at this mac screen by now. That one didn't take so long though... FinallY 

            // Problem 4 CHA-CHING the easiest of them all ZOMG I AM SOO EXCITED

            Console.WriteLine("Alright final part of the program I promise\n");
            Console.WriteLine("We are going on an imaginary shopping trip, first I need you to tell me how much money is on your fake gift card:");
            string fakeGift = Console.ReadLine();
            while(!double.TryParse(fakeGift, out test))
            { Console.WriteLine("You may only enter numbners, please try again enter your price now:");
                fakeGift = Console.ReadLine();
            }
            double fakeGiftD = double.Parse(fakeGift);

            while(fakeGiftD>=0)
            {
                Console.Write("Please enter the cost of your purchase: ");
                string fakeP = Console.ReadLine();
                
                while(!Double.TryParse(fakeP, out test))
                {
                    Console.WriteLine("Again you must only enter numbers, Please try again\n");
                     fakeP= Console.ReadLine();
                    
                }
                double fakePD = double.Parse(fakeP);
                fakeGiftD = fakeGiftD-fakePD;
                if (double.TryParse(fakeP, out test))
                {
                    
                    if (fakeGiftD >= 0)
                    {
                        
                        Console.Write("With your current purchase cost of $" + fakePD + "You still have $" + fakeGiftD + " left that you may spend!\n");
                        Console.ReadKey();
                    }
                    else if (fakeGiftD < 0)
                    {
                        Console.WriteLine("With your current purchase of $" + fakePD + " you have used up your gift card and still owe $" + fakeGiftD + ".");
                        Console.ReadKey();
                    }
                }

                
            }

        }
    }
}


    

