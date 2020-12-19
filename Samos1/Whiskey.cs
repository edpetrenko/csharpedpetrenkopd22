using System;
using System.Collections.Generic;
namespace samos
{
    class Whiskey
    {
        public List<Drinks> nap = new List<Drinks>();

        public void AddNewDrinks()
        {
            string Excerpt;
            string Country_made;
            int Cost;
            int Volume;
            Console.Write("\nEnter a excerpt of drinks: ");
            Excerpt = Console.ReadLine();
            Console.Write("Enter a country made of drinks: ");
            Country_made = Console.ReadLine();
            Console.Write("Enter a drinks price: ");
            while (!int.TryParse(Console.ReadLine(), out Cost) || Cost <= 0)
            {
                Console.Write("Enter a correct speed value: ");
            }
            Console.Write("Enter a whiskey's volume of bottle: ");
            while (!int.TryParse(Console.ReadLine(), out Volume) || Volume > 10 || Volume < 0)
            {
                Console.Write("Enter a correct volume: ");
            }
            Drinks newDrinks = new Drinks(Excerpt, Country_made, Cost, Volume);
            nap.Add(newDrinks);
        }
        public void DisplayAllDrinkss()
        {
            int i = 1;
            foreach (Drinks c in nap)
            {
                DisplayInfoAboutDrinks(c);
                i++;
            }
        }
        public void SearchByOneCharacteristic(char characteristic)
        {
            int i = 0;
            switch (characteristic)
            {
                case 'n':
                    Console.Write("What excerpt would you like to find: ");
                    string excerpt = Console.ReadLine();

                    foreach (Drinks c in nap)
                    {
                        if (c.Excerpt == excerpt)
                        {
                            DisplayInfoAboutDrinks(c);
                            i++;
                        }
                    }
                    if (i == 0) Console.WriteLine("Sorry, no coincide found.");
                    i = 0;
                    break;

                case 'c':
                    Console.Write("What country made would you like to find: ");
                    string country_name = Console.ReadLine();
                    foreach (Drinks c in nap)
                    {
                        if (c.Country_made == country_name)
                        {
                            DisplayInfoAboutDrinks(c);
                            i++;
                        }
                    }
                    if (i == 0) Console.WriteLine("Sorry, no coincide found.");
                    i = 0;
                    break;

                case 's':
                    Console.Write("Which cost would you like to find: ");
                    int cost = Convert.ToInt32(Console.ReadLine());
                    foreach (Drinks c in nap)
                    {
                        if (c.Cost == cost)
                        {
                            DisplayInfoAboutDrinks(c);
                            i++;
                        }
                    }
                    if (i == 0) Console.WriteLine("Sorry, no coincide found.");
                    i = 0;
                    break;

                case 'y':
                    Console.Write("What name would you like to find: ");
                    int volume = Convert.ToInt32(Console.ReadLine());
                    foreach (Drinks c in nap)
                    {
                        if (c.Volume == volume)
                        {
                            DisplayInfoAboutDrinks(c);
                            i++;
                        }
                    }
                    if (i == 0) Console.WriteLine("Sorry, no coincide found.");
                    i = 0;
                    break;

                default:
                    Console.WriteLine("No such characteristic.");
                    break;
            }

        }

        public void DisplayInfoAboutDrinks(Drinks Drinks)
        {
            Console.WriteLine("\nExcerpt  : {0}\nCountry_made  : {1}\nCost  : {2}\nVolume  : {3}", Drinks.Excerpt, Drinks.Country_made, Drinks.Cost, Drinks.Volume);
        }
    }
}