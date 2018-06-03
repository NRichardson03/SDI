using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Richardson_Nathaniel_StringObjects
{
    //Nathaniel Richardson
    // SDI WEEK 3
    // 04-21-2018
    class Program
    {
        static void Main(string[] args)
        {
            string theTest;
            Console.WriteLine("Telephone number checker:");
            Console.WriteLine("Please enter a valid telephone number in the format of (XXX) XXX-XXXX");
            string phone_NUM = Console.ReadLine();

            theTest = PhoneNUMF(phone_NUM);

            if(theTest == "True")
            {
                Console.WriteLine("The Phone number you entered " + phone_NUM + " is a valid phone number");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("The Phone Number you entered " + phone_NUM + " is invalid.");
                Console.ReadKey() ;

            }

            // 210 888 8888 invalid
            //(210) 718-6812 valid
            // (210) 7186812 invalid
            // 210 718-6812 invalid
            // 222 u wish u knew invalid

            Console.Clear();

            // The Fun Encryption Thingy 

            Console.WriteLine("Welcome to the encryption thingy!");
            Console.WriteLine("Write anything in code and we will decrypt! \n KEY: \n @=a \n #=e \n ^=i \n *=o \n + = u \n ");
            string inputstr;
            Console.WriteLine("Now Enter The String, ENCRYPTED.");
            inputstr = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(inputstr))
            {
                Console.WriteLine("Hey! Please enter an encrypted String not a blank space:");
                inputstr = Console.ReadLine();
            }
            string decryptedStr = getDecryptedString(inputstr);
            Console.WriteLine("\nThe encrypted text is " + inputstr);
            Console.WriteLine("The Deciphered text is " + decryptedStr);
            Console.ReadKey();

            //output @^# = aie
            // ^* = io
            // +* = uo

        }

        // method/function to decrypt the string
        static string getDecryptedString(string str)
        {
            char[] strarray = str.ToCharArray();
            for (int i = 0; i < strarray.Length; i++)
            {
                if (strarray[i] == '@')
                    strarray[i] = 'a';
                else if (strarray[i] == '#')
                    strarray[i] = 'e';
                else if (strarray[i] == '^')
                    strarray[i] = 'i';
                else if (strarray[i] == '*')
                    strarray[i] = 'o';
                else if (strarray[i] == '+')
                    strarray[i] = 'u';
            }
            string result = new string(strarray);
            return result;
        }
    

           


        
        public static string PhoneNUMF(string pn)
        {
            string i;
            if (pn.StartsWith("(") && (pn.IndexOf(')') == 4) && pn.IndexOf(' ') == 5 && pn.IndexOf('-') == 9 && pn.Length==14)
            {
                i = "True";
                return i;
            }
            else { i = "False"; return i; }
            
            

        }


    }
}
