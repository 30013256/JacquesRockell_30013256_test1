using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//app by jacques rockell
namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("-----------This program will give the sum total of 5 prices-----------");
            Console.WriteLine("----------------------------------------------------------------------");

            // limit is the ammount of times the loop will run
            int limit = 5;
            decimal total = 0;

            //this is a for loop, counter++ means the counter gose p by 1 every time it loops
            for (int counter = 1; counter <= limit; counter++)
            {
                Console.WriteLine("Enter the price of item " + counter + ":");
                total += decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine("The total of those items is $"+total);

            Console.ReadLine();

        }
    }
}
