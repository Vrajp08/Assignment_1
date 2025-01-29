using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Variables to store pet details
            string petType;
            string petName;

            //choose a pet type
            Console.WriteLine("Welcome to the Virtual Pet Care Game!");
            Console.WriteLine("Choose your pet type:");
            Console.WriteLine("1. Cat");
            Console.WriteLine("2. Dog");
            Console.WriteLine("3. Rabbit");
            Console.Write("Enter the number corresponding to your choice: ");
            string choice = Console.ReadLine();

            // Use a switch statement to set the pet type
            switch (choice)
            {
                case "1":
                    petType = "Cat";
                    break;
                case "2":
                    petType = "Dog";
                    break;
                case "3":
                    petType = "Rabbit";
                    break;
                default:
                    Console.WriteLine("Invalid choice! Defaulting to 'Unknown Pet'.");
                    petType = "Unknown Pet";
                    break;
            }

            // Prompt the user to give their pet a name
            Console.Write("Give your pet a name: ");
            petName = Console.ReadLine();

            // Display the welcome message
            Console.WriteLine($"\nWelcome, {petName} the {petType}!");
            Console.WriteLine("Take good care of your pet and enjoy the game!");

            // Pet attributes
            int hunger = 5;
            int happiness = 5;
            int health = 5;

            while (true)
            {
                // Display menu
                Console.WriteLine("\nWhat do you want to do?");
                Console.WriteLine("1. Feed");
                Console.WriteLine("2. Play");
                Console.WriteLine("3. Rest");
                Console.WriteLine("4. Check Status");
                Console.WriteLine("5. Exit");

                // Get user choice
                Console.Write("Choose an option (1-5): ");
                string actionChoice = Console.ReadLine();



                // Handle choice
                if (actionChoice == "1") // Feed the pet
                {
                    hunger -= 2; // Reduce hunger by 2
                    if (hunger < 1) hunger = 1; // Ensure hunger doesn't drop below 1
                    health += 1; // Slight increase in health
                    Console.WriteLine($"{petName} is fed. Hunger decreased, health slightly improved.");
                }
                else if (actionChoice == "2") // Play with the pet
                {
                    happiness += 2; // Increase happiness by 2
                    if (happiness > 10) happiness = 10; // Ensure happiness doesn't exceed 10

                    hunger += 1; // Playing increases hunger by 1
                    if (hunger > 10) hunger = 10; // Ensure hunger doesn't exceed 10

                    Console.WriteLine($"{petName} had fun playing! Happiness increased, hunger slightly increased.");
                }
                else if (actionChoice == "3") // Rest the pet
                {
                    health += 2; // Increase health by 2
                    if (health > 10) health = 10; // Ensure health doesn't exceed 10
                    happiness -= 1; // Decrease happiness slightly
                    Console.WriteLine($"{petName} rested and feels healthier. Happiness slightly decreased.");
                }
                else if (actionChoice == "4") // Check pet's status
                {
                    Console.WriteLine($"\n{petName}'s Status:");
                    Console.WriteLine($"Hunger: {hunger}/10");
                    Console.WriteLine($"Happiness: {happiness}/10");
                    Console.WriteLine($"Health: {health}/10");

                    if (hunger < 3 || happiness < 3 || health < 3)
                    {
                        Console.WriteLine("\nWarning: Your pet's stats are critically low! Please take immediate action.");
                    }
                }
                else if (actionChoice == "5") // Exit the game
                {
                    Console.WriteLine("\nThanks for playing! Take care of your virtual friend. Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option. Please try again.");
                }

                // Simulate time passing
                hunger += 1; // Hunger increases with time
                if (hunger > 10) hunger = 10; // Ensure hunger doesn't exceed 10

                happiness -= 1; // Happiness decreases with time
                if (happiness < 1) happiness = 1; 


                if (hunger >= 8 || happiness <= 2)
                {
                    health -= 1;
                    Console.WriteLine($"{petName} is starting to look unwell due to neglect!");
                    if (health < 3)
                    {
                        Console.WriteLine("Warning: Your pet's health is in critical danger!");
                    }
                }


            }
        }
    }
}
