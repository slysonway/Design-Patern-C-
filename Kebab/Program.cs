using System;
using System.Collections.Generic;

namespace Kebab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Kebab test = new Kebab(
                true, 
                true, 
                true, 
                new List<Meat>(){ Meat.Kebab }, 
                new List<Sauce>(){ Sauce.Samourai }, 
                0
                );
            Console.WriteLine($"Kebab = {test}");

            bool isVegetarian = test.isVegetarian();
            Console.WriteLine($"Is Vegetarian = {isVegetarian.ToString()}");
            
            bool isPescetarian = test.isPescetarian();
            Console.WriteLine($"Is Pescetarian = {isPescetarian.ToString()}");

            Kebab cheese = test.addCheese();
            Console.WriteLine($"Kebab Cheese = ${cheese}");
            Kebab noOnion = test.withOutOnion();
            Console.WriteLine($"No Onion = {noOnion}");
        }
    }
}