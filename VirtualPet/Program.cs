﻿using System;

namespace VirtualPet
{
    class Program 
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int startHunger = random.Next(50, 70);
            int startBoredom = random.Next(50, 60);
            int startHealth = random.Next(30, 50);

            Pet pet = new Pet();
            pet.Hunger = startHunger;
            pet.Boredom = startBoredom;
            pet.Health = startHealth;

            bool VirtualPet = true;
            
            do
            {
                pet.Tick();
                Console.WriteLine("Welcome to Pixel Pet!\n");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. Pick your pet species");
                Console.WriteLine("2. Name your pet!");
                Console.WriteLine("3. Feed your pet");
                Console.WriteLine("4. Play with your pet");
                Console.WriteLine("5. Take pet to the doctor");
                Console.WriteLine("6. Check the status of you pet");
                Console.WriteLine("7. Exit game.");

                string userChoice = Console.ReadLine().ToLower();
                Console.Clear();

                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("What species of animal would you like?");                
                        string speciesOfPet = Console.ReadLine();
                        pet.SetSpecies(speciesOfPet);
                        Console.WriteLine($"The species of your animal is: {pet.Species}");
                        break;
                    case "2":
                        Console.WriteLine("What would you like to name your pet?");                
                        string nameOfPet = Console.ReadLine();
                        pet.SetName(nameOfPet);
                        Console.WriteLine($"Congratulations! \nThe name of your pet is: {pet.Name}");
                        break;
                    case "3":
                        pet.Feed();
                        break;
                    case "4":
                        pet.Play();
                        break;
                    case "5":
                        pet.SeeDoctor();
                        break;
                    case "6":
                        Console.WriteLine("Check overall status of pet:\n");
                        Console.WriteLine($"The name of your pet is {pet.Name} with a species type of {pet.Species}");                     
                        Console.WriteLine($"Hunger: {pet.Hunger}");
                        Console.WriteLine($"Boredom: {pet.Boredom}");
                        Console.WriteLine($"Health: {pet.Health}");
                        break;
                    case "7":
                        VirtualPet = false;
                        Console.WriteLine("Good bye!");
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }

                Console.WriteLine("Return to main menu\n");
                Console.ReadKey();
                Console.Clear();

            } while (VirtualPet);
        }
    }
}
