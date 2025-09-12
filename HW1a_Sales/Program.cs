// HW1a Sales Total

// Your Name: Ally Khrais 
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // initial prompt to ask user
            Console.WriteLine("What is the name of the item you are purchasing?");
            String item = Console.ReadLine();

            //second prompt to figure out item amount 
            Console.WriteLine("How many " + item + "'s do you want to buy?");
            Double itemAmt = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the cost of the " + item + "?");
            Double itemCost = Convert.ToDouble(Console.ReadLine());

            //constant sales tax variable 
            const Double salesTax = 0.085;
           
            //calculate subtotal
            Double subtotal = itemAmt * itemCost;

            //calculate subtax amount 
            Double subtax = subtotal * salesTax;

            //calculate total
            Double total = subtotal + subtax;

            //this is for subtotal, sales tax, and total.
            Console.WriteLine("Your subtotal is $" + subtotal.ToString("F2") + ".");
            Console.WriteLine("Your Sales Tax is $" + subtax.ToString("F2") + ".");
            Console.WriteLine("Your total is $" + total.ToString("F2") + ".");


        }
    }
}
