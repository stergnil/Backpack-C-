using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ryggsag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string object1 = "Nothing";

            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Welcome to the backpack");
                Console.WriteLine("[1]Put an item in the backpack");
                Console.WriteLine("[2]Print the items in the backpack");
                Console.WriteLine("[3]Empty the backpack");
                Console.WriteLine("[4]Exit");
                int menuInput = Convert.ToInt32(Console.ReadLine());

                switch (menuInput)
                {
                    case 1: 
                        Console.WriteLine("What are you putting in the backpack: ");
                        object1 = Console.ReadLine();
                        Console.WriteLine("You put " + object1 + " in the backpack.");
                        break;
                    case 2:
                        Console.WriteLine("The backpack contains: " + object1);
                        break;
                    case 3:
                        object1 = "nothing";
                        break;
                    case 4:
                        isRunning = false;
                        break;
                    default: 
                        Console.WriteLine("Please write a number between 1 and 4");
                        break;
                } 
                
            }

        }
    }
}
