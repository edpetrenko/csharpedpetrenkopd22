using System;
namespace samos
{
    class Program
    {
        static void Main(string[] args)
        {
            Whiskey myWhiskey = new Whiskey();
            int choice;
            do
            {
                Console.WriteLine();
                if (myWhiskey.nap.Count == 0)
                {
                    Console.WriteLine("[1] - add a new drinks");
                    Console.WriteLine("[0] - don't drink alcohol today");
                }
                else
                {
                    Console.WriteLine("[1] - add a new drinks");
                    Console.WriteLine("[2] - show all drinkss");
                    Console.WriteLine("[3] - find drinks by one characteristic");
                    Console.WriteLine("[0] - don't drink alcohol today");
                }
                Console.Write("Chose an option:");
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Enter a correct option: ");
                }
                switch (choice)
                {
                    case 1:
                        myWhiskey.AddNewDrinks();
                        Console.WriteLine("Drink was added");
                        Console.WriteLine(myWhiskey.nap.Count);
                        break;
                    case 2:
                        myWhiskey.DisplayAllDrinkss();
                        break;
                    case 3:
                        Console.WriteLine("Okay, which characteristic would you like to find?");
                        char characteristic;
                        Console.WriteLine("[e] - Excerpt");
                        Console.WriteLine("[m] - Country_made");
                        Console.WriteLine("[c] - Cost");
                        Console.WriteLine("[v] - Volume");
                        characteristic = Convert.ToChar(Console.ReadLine());
                        myWhiskey.SearchByOneCharacteristic(characteristic);
                        break;
                    case 0:
                        Console.WriteLine("Have a nice day!");
                        return;
                    default:
                        Console.WriteLine("Wrong option!");
                        break;
                }
            } while (choice != 0);
        }
    }
}
