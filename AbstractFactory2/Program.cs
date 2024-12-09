using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory2.Factories;
using AbstractFactory2.AbstractAnimals;

namespace AbstractFactory2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Where would you like to go?");

            Console.WriteLine("Type 1 for the arctic");
            Console.WriteLine("Type 2 for the jungle");
            Console.WriteLine("Type 3 for the forest");
            Console.WriteLine("Type 4 for the forest");

            string userInput;

            IFactory factory = null;
            
            while (factory == null)
            {

                userInput = Console.ReadLine();

                switch (userInput.Trim())
                {
                    case null:
                        Console.WriteLine("Please select a number");
                        break;

                    case "1":
                        Console.WriteLine("Going to the arctic...");
                        factory = new ArcticFactory();
                        break;

                    case "2":
                        Console.WriteLine("Going to the jungle...");
                        factory = new JungleFactory();
                        break;
                    case "3":
                        Console.WriteLine("Going to the forest...");
                        factory = new ForestFactory();
                        break;

                    case "4":
                        Console.WriteLine("Going to the mountain...");
                        factory = new MountainFactory();
                        break;

                    default :
                        Console.WriteLine("Please enter a valid number");
                        break;
                }

            }

            userInput = Console.ReadLine();

            while (userInput.ToLower() != "q")
            {
                AbstractAnimal animal = factory.CreateRandomAnimal();

                Console.WriteLine($"Looking for animals... Look it's a {animal.Name}! Did you know they are {animal.Diet}s? It looks {animal.State}.");

                Console.WriteLine("Press 'q' to quite, or ENTER to keep going.");

                userInput = Console.ReadLine();


            }
        }
    }
}
