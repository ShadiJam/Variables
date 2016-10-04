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
            string[] shadiFaveBooks = { "Dune", "Oryx and Crake", "The Foundation", "Zen and the Art of Motorcycle Maintenance" };
            var f = new { born = "Tehran", love = "travel", hair = "big", age = "34" };
            var m = new { comedy = "The Big Lebowski", adventure = "The Princess Bride", visual = "The Revenant" };
            Console.WriteLine(greeting);
            Console.WriteLine("Columbus Sailed the world in " + year);
            Console.WriteLine("You have a dog at home. True or False?");
            Console.WriteLine(ifDogHome);
            if (ifDogHome) {
                Console.WriteLine("It is true that you have a dog at home.");
            } else
            {
                Console.WriteLine(!ifDogHome);
            }
            Console.WriteLine("Today is " + todayDate);
            Console.WriteLine("I spent " + "$" + cost + " on a cheeseburger.");
            Console.WriteLine(letter + " marks the Spot");
            Console.WriteLine("Some of Shadi's favorite books are " + shadiFaveBooks[0] + ", "+ shadiFaveBooks[1] + ", " + shadiFaveBooks[2] + ", and " + shadiFaveBooks[3] + ".");
            Console.WriteLine("Shadi was born in " + f.born +". She loves to " + f.love + ". Her hair is " + f.hair + " and she is " + f.age + " years old.");
            Console.WriteLine("Shadi's favorite comedy film is " + m.comedy + ". Her favorite adventure film is " + m.adventure + " and her favorite film, visually, is " + m.visual + ".");
            Console.ReadLine();
        }
            
            
        }
        
    }



