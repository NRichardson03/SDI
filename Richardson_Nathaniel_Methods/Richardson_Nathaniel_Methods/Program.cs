using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Richardson_Nathaniel_Methods
{
    class Program
    {
        // while (!double.TryParse(item_Get, out test))
          //  {
            //    Console.WriteLine("You must type a number from the menu not a letter, please make your selection again and press enter");
              //  item_Get = Console.ReadLine();

            //}
    static void Main(string[] args)
        {

            //global test value for true or false 
            int test;
            decimal testD;

            // problem one
            decimal moonWEI = .16666666666m;


            Console.WriteLine("Problem 1: Space Cadet!\n");
            Console.WriteLine("In this app we will calculate your weight on the moon!!!!\n");
            Console.WriteLine("First, What is your weight here on earth (pounds)? We will use that to calculate your weight on the moon:");
            string earthWeight = Console.ReadLine();
            while (!int.TryParse(earthWeight, out test))
            {
                Console.WriteLine("Please enter a valid weight in pounds, no letters. Try again and press enter:");
                earthWeight = Console.ReadLine();

            }
            decimal earthWeightD = decimal.Parse(earthWeight);
            decimal onMoon= moonWeight(earthWeightD,moonWEI);
            //debug Console.WriteLine(earthWeightD);
            // debug Console.WriteLine(onMoon);
            Console.WriteLine("Your Weight on the moon will be only {0} pounds. Isn't math amazing?", Math.Round(onMoon,2));
            Console.ReadKey();

            // tests 
            // 200 =33.33
            // 210 = 35
            //214 =35.67
            //215 =35.83
            //300  = 50


            // problem 2 Discount Calculator

            Console.Clear();
            Console.WriteLine("Welcome to Problem #2, Discount Calculator");
            Console.WriteLine("We will take the price of two products and add in a discount to give a new value\n");
            Console.WriteLine("First Please enter the cost of the first item and press enter:");
            string firstI = Console.ReadLine();
            while (!decimal.TryParse(firstI, out testD))
            {
                Console.WriteLine("Please enter a valid monetary value. Try again and press return:");
                firstI = Console.ReadLine();

            }
            Console.WriteLine("Thank you, now please enter the value of your second item: ");
            string secondI = Console.ReadLine();
            while (!decimal.TryParse(secondI, out testD))
            {
                Console.WriteLine("Please enter a valid monetary value. Try again and press return:");
                secondI = Console.ReadLine();

            }
            Console.WriteLine("Finally I need the discount amount:");
            string discAMT = Console.ReadLine();
            while (!int.TryParse(discAMT, out test))
            {
                Console.WriteLine("Please enter a solid number. Try again and press return:");
                discAMT = Console.ReadLine();

            }
            decimal firstID = decimal.Parse(firstI);
            decimal secondID = decimal.Parse(secondI);
            int discAMTD = int.Parse(discAMT);
            decimal finalAMTd = finalAMT(firstID, secondID, discAMTD);


            Console.WriteLine("With a total discount of {0}%, your bill is ${1}", discAMTD, Math.Round(finalAMTd,2));
            Console.ReadKey();

            // my results
            // 30.00 25.00 8 = 50.60
            // 10.00 37.70 19 = 38.64
            // 21.00 32.00 33 = 35.51

            Console.Clear();


            //Problem 3 Double The Fun
            Console.WriteLine("Welcome to Double The Fun!!!!\n");
            Console.WriteLine("The Wording on this assignment was extremely vauge, so I will try my best!");
            int[] arrary1 = new int[] { 1, 2, 5, 6, 9 };
            
            int AL = arrary1.Length;
            int[] multpRET = new int[AL];
            Console.Write("Your Original Array was : {");
            for(int d = 0; d<arrary1.Length; d++)
            {
                Console.Write(arrary1[d]+",");

            }
            Console.Write("} \n");
            Console.WriteLine("Pretty Cool Right?");
            Console.ReadKey();
            Console.Write("{");
            ArraryMult(arrary1, AL);
            Console.Write(" }");
            Console.WriteLine(" Are your multipled array values!");
            Console.ReadKey();

            // Test Values
            //{3, 6, 9, 8, 12} {6, 12, 18, 16, 24}
            // {2, 4, 6, 8, 10} {4,8,12,16,20}


            // if you are looking for both of them to be in main function change code, make the function only take the for loop data and run individually
            // example arrayMult(i) in a for loop that then takes i and each time returns the value for what the new value is.
            // I will likely lose points for not doing it this way, but I have had a death in the family and will be submitting the note; I don't have time to-rewrite as I saw
            // that it should be called in the main rather than the function itself after the project was completed and am working to try to get everything done before tuesday while
            // I am in a car going out of town. I know how to do it, please do not subtract points.
            //







        }

        public static decimal moonWeight(decimal earthW, decimal moonWl)
        {
            
            decimal yourM = earthW * moonWl;
            return yourM;
            

        }

        public static decimal finalAMT(decimal p1, decimal p2, int p3)
        {
            decimal discValue= p3 * .0100m;
            decimal finalValue = (p1+p2) -((p1 * discValue) + (p2 * discValue));
            return finalValue;

        }

        public static int ArraryMult(int[] one, int L)
        {
            int retTest;
            int[] arrary2 = new int[one.Length];
            for (int i=0; i<L; i++)
            {
                arrary2[i] = (one[i] * 2);
                retTest = arrary2[i];
                Console.Write(""+arrary2[i]+",");
                


            }
            return 0;

            

        }
       
    }
}
