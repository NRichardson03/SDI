using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Richardson_Nathaniel_CustomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal testDec;
            string testSTR;
            int testINT;

            Console.WriteLine("Bank Account Project");
            Console.WriteLine("We will be doing some stuff related to money.");
            Console.WriteLine("Please enter your name:");
            string myName = Console.ReadLine();
            Console.WriteLine("Please enter the full amount of your Savings account:");
            string myBank = Console.ReadLine();
            Console.WriteLine("Please enter the amount only in your Checking account");
            string myChecking = Console.ReadLine();
            while(!decimal.TryParse(myBank, out testDec) || !Decimal.TryParse(myChecking, out testDec))
            {
                Console.WriteLine("Please enter valid properties in decimal form.");
                Console.ReadLine();
                Console.WriteLine("Please enter the full amount of your Savings account:");
                myBank = Console.ReadLine();
                Console.WriteLine("Please enter the amount only in your Checking account");
                myChecking = Console.ReadLine();
            }

            decimal myBankD = decimal.Parse(myBank);
            decimal myCheckingD = decimal.Parse(myChecking);
            

            customClass stuff1 = new customClass(myName, myCheckingD, myBankD);

            Console.WriteLine("Hard work has been done your bank account has been created");
            Console.WriteLine("Your Checking Account has ${0} and your Savings account itself has ${1}, {2}.", stuff1.GetSB(), stuff1.Get_MSC(), stuff1.Get_mName());
            Console.ReadKey();
            Console.WriteLine("The full amount in your bank account, checking and savings is ${0}",(stuff1.GetSB() + stuff1.Get_MSC()));
            Console.ReadKey();

            Console.WriteLine("Now lets make 3 deposits or withdrawals.");
            Console.ReadKey();
            Console.Clear();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter 1 for Deposit or 2 for withdrawal");
                string depowith = Console.ReadLine();
                
                while (!int.TryParse(depowith, out testINT))
                {
                    Console.WriteLine("This must be a number   and must be 1 or 2 please enter again, 1 for Deposit, 2 for withdrawl");
                     depowith = Console.ReadLine();

                }

                Console.WriteLine("Now which account would you like to do this to? Press 1 for Checking, 2 for Savings:");
                string whichACCT = Console.ReadLine();
                //testNUM = int.Parse(whichACCT);

                while (!int.TryParse(depowith, out testINT))
                {
                    Console.WriteLine("This must be a number  and must be 1 or 2 please enter again 1 for Checking, 2 for Savings:");
                    depowith = Console.ReadLine();

                }

                int depoY = int.Parse(depowith);
                int accS = int.Parse(whichACCT);
                // here is where it all goes down
                if (depoY == 1 && accS == 2) // saving deposit
                {
                    //currentC = stuff1.GetSB();
                    Console.WriteLine("How much would you like to deposit to savings? No letters please");
                    string amntDP = Console.ReadLine();
                    while (!decimal.TryParse(amntDP, out testDec))
                    {
                        Console.WriteLine("You must enter a valid deposit value! Please try again in numbers only!");
                        amntDP = Console.ReadLine();
                    }

                    decimal amntDPD = decimal.Parse(amntDP);
                    stuff1.SetSC_D(amntDPD);
                    Console.WriteLine("Your new Checking Account Balance is ${0}, and your new Savings Balance is ${1}",stuff1.Get_MSC(), stuff1.GetSB());
                }
                if(depoY==2 && accS == 2) // savings withdrawal
                {
                    //currentC = stuff1.GetSB();
                    Console.WriteLine("How much would you like to withdraw from Savings? No letters please");
                    string amntDP = Console.ReadLine();
                    while (!decimal.TryParse(amntDP, out testDec))
                    {
                        Console.WriteLine("You must enter a valid withdrawal value! Please try again in numbers only!");
                        amntDP = Console.ReadLine();
                    }
                    
                    decimal amntDPD = decimal.Parse(amntDP);
                    while (amntDPD > stuff1.GetSB())
                    {
                        Console.WriteLine("You are trying to withdraw ${0} from your savings with only ${1} avaliable;/n Please choose a different withdrawal amount and press enter", amntDPD, stuff1.GetSB());
                        amntDP = Console.ReadLine();
                        amntDPD = decimal.Parse(amntDP);
                    }
                    stuff1.SetSB_W(amntDPD);
                    Console.WriteLine("Your new Checking Account Balance is ${0}, and your new Savings Balance is ${1}", stuff1.Get_MSC(), stuff1.GetSB());
                }

                if(depoY==1 && accS == 1) // checking deposit
                {
                    //urrentC = stuff1.GetSB();
                    Console.WriteLine("How much would you like to deposit to checking? No letters please");
                    string amntDP = Console.ReadLine();
                    while (!decimal.TryParse(amntDP, out testDec))
                    {
                        Console.WriteLine("You must enter a valid deposit value! Please try again in numbers only!");
                        amntDP = Console.ReadLine();
                    }

                    decimal amntDPD = decimal.Parse(amntDP);
                    stuff1.SetSB_D(amntDPD);
                    Console.WriteLine("Your new Checking Account Balance is ${0}, and your new Savings Balance is ${1}", stuff1.Get_MSC(), stuff1.GetSB());

                }
                if(depoY==2 && accS == 1) //Checking Withdrawal
                {
                    //currentC = stuff1.GetSB();
                    Console.WriteLine("How much would you like to withdraw from checking? No letters please");
                    string amntDP = Console.ReadLine();
                    while (!decimal.TryParse(amntDP, out testDec))
                    {
                        Console.WriteLine("You must enter a valid deposit value! Please try again in numbers only!");
                        amntDP = Console.ReadLine();
                    }

                    decimal amntDPD = decimal.Parse(amntDP);
                    while (amntDPD > stuff1.Get_MSC())
                    {
                        Console.WriteLine("You are trying to withdraw ${0} from your checking with only ${1} avaliable; /nPlease choose a different withdrawal amount and press enter:",amntDPD, stuff1.Get_MSC());
                        amntDP = Console.ReadLine();
                        amntDPD = decimal.Parse(amntDP);
                    }
                    stuff1.SetSC_W(amntDPD);
                    Console.WriteLine("Your new Checking Account Balance is ${0}, and your new Savings Balance is ${1}", stuff1.Get_MSC(),stuff1.GetSB());

                }
                }

            Console.WriteLine("Your Final Checking Balance is ${0}, and your Savings Balance is ${1}", stuff1.Get_MSC(), stuff1.GetSB());
            Console.WriteLine("Your total Balance {0}, is ${1} thank you for using my program", stuff1.Get_mName(), grandTotal(stuff1.Get_MSC(),stuff1.GetSB()));
            Console.ReadKey();
            }
        
       static  decimal grandTotal(decimal a, decimal b)
        {
            decimal grand_total = a + b;
            return grand_total;

        }

        }
    }

