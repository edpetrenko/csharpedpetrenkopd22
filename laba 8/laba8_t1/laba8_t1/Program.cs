﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Petrenko_Eduard_PD-22
namespace laba8_t1
{
    class Program
    {
        static void Main(string[] args)
        {
            garage myGarage = new garage();
            Console.WriteLine("-_- WELCOME TO YOUR GARAGE, BOSS -_-");
            int choice;
            do
            {
                Console.WriteLine();
                if (myGarage.myCars.Count == 0)
                {
                    Console.WriteLine("[1] - add a new car");
                    Console.WriteLine("[0] - close the garage.");
                }
                else
                {
                    Console.WriteLine("[1] - add a new car");
                    Console.WriteLine("[2] - show all my cars");
                    Console.WriteLine("[3] - delete a car");
                    Console.WriteLine("[4] - find cars by one characteristic");
                    Console.WriteLine("[0] - close the garage.");
                }
                Console.Write("Chose an option:");
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Enter a correct option: ");
                }
                switch (choice)
                {
                    case 1:
                        myGarage.AddNewCar();
                        Console.WriteLine("Car was added");
                        Console.WriteLine(myGarage.myCars.Count);
                        break;
                    case 2:
                        myGarage.DisplayAllCars();
                        break;
                    case 3:
                        myGarage.RemoveCar();
                        break;
                    case 4:
                        Console.WriteLine("Make a choise of characteristic");
                        char characteristic;
                        Console.WriteLine("[n] - name");
                        Console.WriteLine("[c] - color");
                        Console.WriteLine("[s] - speed");
                        Console.WriteLine("[y] - year of issue");
                        characteristic = Convert.ToChar(Console.ReadLine());
                        myGarage.SearchByOneCharacteristic(characteristic);
                        break;
                    case 0:
                        Console.WriteLine("Garage closed.");
                        return;
                    default:
                        Console.WriteLine("Incorect option!");
                        break;
                }
            } while (choice != 0);
        }
    }
}
