using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//app by jacques rockell
namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine("-----------------This program can give the result of base^exponent-----------------");
            Console.WriteLine("-----------------------------------------------------------------------------------");

            
            

            Console.WriteLine("Enter the value of the base:");
            double bse = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of the exponet:");
            int expnt = int.Parse(Console.ReadLine());


            /* i am aware that bse*expnt will not give the correct result , im just stumped on how to work it out 
             i tried using loops think i was on righ track but just cant get it working*/




            /*this is a write line to writes whats inside the brackets to the console, any in quotation marks appers as writing any thing out side of them appers as there value*/
            Console.WriteLine(bse+"^"+ expnt + " = " + bse*expnt);

            Console.ReadLine();

        }
    }
}
