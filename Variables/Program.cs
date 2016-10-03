using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hello World";
            int year = 1492;
            bool ifDogHome = true;
            string todayDate = "10/03/16";
            float cost = 5.45f;
            char letter = 'X';
            string input = Console.ReadLine();


            Console.WriteLine(greeting);
            Console.WriteLine("Columbus Sailed the world in " + year);            
            Console.WriteLine("You have a dog at home. True or False?");
            Console.ReadLine();
            if(ifDogHome)
            {
                Console.WriteLine("It is true that you have a dog at home.");
            } else
            {
                Console.WriteLine("You are missing out!");
            }
            Console.WriteLine("Today is " + todayDate);
            Console.WriteLine("I spent " + "$" + cost + " on a cheeseburger.");
            Console.WriteLine(letter + " marks the Spot");
            Console.ReadLine();
        }
            
            
        }
        
    }



