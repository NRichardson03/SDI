using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Richardson_Nathaniel_Lists
{
    class Program
    {
        // Nathaniel Richardson
        // SDI LIST PROJECT
        // 04 - 21 - 2018

            // stuff for me to remember.
            //add a list
        // list<data_type> = new list<data_type>();
        //listName.Add(stufftoadd);
            // call a list
        // Console.Write(list[i]);
            // insert into a list
        //listName(position_in_list, stufftoadd);
        static void Main(string[] args)
        {

            // declaring lists
            List<string> itemsPurchase = new List<string>();
            itemsPurchase.Add("Xbox One X");
            itemsPurchase.Add("4k TV");
            itemsPurchase.Add("Graphics Card");
            itemsPurchase.Add("Cell Phone");
            itemsPurchase.Add("Remote");
            itemsPurchase.Add("Water");
            itemsPurchase.Add("Soda");

            List<decimal> itemsPrice = new List<decimal>();
            itemsPrice.Add(499.99m);
            itemsPrice.Add(899.99m);
            itemsPrice.Add(399.99m);
            itemsPrice.Add(900.00m);
            itemsPrice.Add(29.99m);
            itemsPrice.Add(.99m);
            itemsPrice.Add(1.99m);
            // function call and stuff
            CombineTheList(itemsPurchase, itemsPrice);
            Console.WriteLine("We will be making some changes to this list, lets do that now.");
            Console.ReadKey();
            
            //remove and insert new products
            itemsPurchase.Remove("Xbox One X");
            itemsPurchase.Remove("4k TV");
            itemsPrice.Remove(499.99m);
            itemsPrice.Remove(899.99m);
            
            itemsPurchase.Insert(0, "Pizza");
            itemsPrice.Insert(0, 19.99m);

            CombineTheList(itemsPurchase, itemsPrice);
            Console.ReadKey();




        }

        static void CombineTheList(List<string> a,List<decimal> b)
        {
            for (int i= 0; i<a.Count;i++)
            {

                Console.WriteLine("The " + a[i] + " Costs $" + b[i]+".");

            }
           
        
            

            
        }
    }
}
