using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//app by jacques rockell
namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("----------------Can you solve the following algebraic expression:----------------");
            Console.WriteLine("--------------------------------2(x - 3) + x = 12--------------------------------");
            Console.WriteLine("---------------------------------------------------------------------------------");


            /*
           
              2(x-3)+x=12     =      3x-6=12    =    3x=18      =    x=18/3              x=6    
                                       +6 +6
             */




            int x = 6;

            Console.WriteLine("Enter your guess at the value of x: ");
            int guess = int.Parse(Console.ReadLine());

            // == means if guess is equal to x do whats in the brackets
            if(guess == x)
            {
                Console.WriteLine("Your guess is correct");           
            }


            // else means anything any guess that dosnt equal x do whats in the brackets 
            else
            {
                Console.WriteLine("Sorry that guess is incorrect");
            }

            Console.ReadLine();
        }
    }
}
