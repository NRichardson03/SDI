using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Richardson_Nathaniel_FinalProject
{
    /* Nathaniel Richardson
     * Final Project
     *  tuesday april 24 2018
     *  */
    class Program
    {
        static void Main(string[] args)
        {
            //starting up 
            Console.WriteLine("Final Project SON! This program will calculate 3 bills over six months to see how much you are spending.");
            Console.WriteLine("Lets get this party started!");
            String listOfBills;
            //input
            Console.Write("Enter the list of bills (comma separated): ");
            listOfBills = Console.ReadLine();
            // double check
            while (listOfBills == "")
            {
                Console.WriteLine("List cannot be empty.");
                //prompting the user for a text string a list of bills they have every month
                Console.Write("Enter the list of bills (comma separated): ");
                listOfBills = Console.ReadLine();
            }
            //for the item / name
            String[] bills = CreateBillArray(listOfBills);
            //for the cost
            decimal[] costOfBills = BillCosts(bills);
            //for the total
            decimal total = TotalOfBills(costOfBills);

          // more user input 
            int numOfMonths;
            Console.Write("Enter the number of months you would like to see: ");
            bool check = Int32.TryParse(Console.ReadLine(), out numOfMonths);
            while (!check)
            {
                Console.Write("Enter the number of months you would like to see: ");
                check = Int32.TryParse(Console.ReadLine(), out numOfMonths);
            }

           
            decimal amtOwed = numOfMonths * total;

           // final writing to the user
            Console.WriteLine("\nYour bills for 1 month come out to $" + total.ToString("0.00"));
            Console.WriteLine("For " + numOfMonths + " months, you will owe $" + amtOwed.ToString("0.00"));
            Console.Write("\nPress any key to continue, because this puppy is cooked.");
            Console.ReadKey();
        }

        //CreateBillArray Function
        
        public static string[] CreateBillArray(String listOfBills)
        {
            //split the list based on comma
            String[] bills = listOfBills.Split(',');
            listOfBills = listOfBills.Trim();
            //store the list in array
            for (int i = 0; i < bills.Length; i++)
            {
                bills[i] = bills[i].Trim();
            }
            return bills;
        }


        public static decimal[] BillCosts(String[] bills)
        {
            //create an array to hold the cost of each bill
            decimal[] costOfbills = new decimal[bills.Length];
            //iterate through all the bill items
            string testor;
            decimal decTest;

            for (int i = 0; i < bills.Length; i++)
            {
                //prompt and read the cost of bill
                Console.Write("Enter the cost of bill for " + bills[i] + ": ");
                testor = Console.ReadLine();
               

                //if cost is not valid prompt for valid cost
                while (!decimal.TryParse(testor, out decTest) || decimal.Parse(testor)<=0)
                {
                    Console.Write("Enter a valid cost of the bill in dollars, no letters allowed;\n And  the bill must be greater than 0.");
                    //prompt and read the cost of bill
                    Console.WriteLine("Enter the cost of bill for " + bills[i] + ": ");
                    testor = Console.ReadLine();
                    
                }

                costOfbills[i] = Convert.ToDecimal(testor);

                
            }return costOfbills;
        }

       
        public static decimal TotalOfBills(decimal[] costOfBills)
        {
            decimal total = 0;
            //maths
            for (int i = 0; i < costOfBills.Length; i++)
                total = total + costOfBills[i];
            return total;
        }
    }
}
    

