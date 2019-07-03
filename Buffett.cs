using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Buffet
    {
        public List<IConsumable> Menu;
        public Buffet()
        {
            Menu = new List<IConsumable>()
            {
                new Food("Cheeseburger", 1000, false, false),
                new Food("Fries", 500, false, false),
                new Food("Wings", 600, true, false),
                new Food("Pasta", 700, false, false),
                new Food("Sushi", 400, false, false),
                new Food("ChocolateCake", 600, false, true),
                new Food("Pizza", 500, false, false),
                new Drink("Soda", 200, false, false),
                new Drink("Juice", 150, false, false),
                new Drink("Water", 0, false, false)
            };
        }
        public IConsumable Serve()
        {
            Random rand = new Random();
            IConsumable item = Menu[rand.Next(Menu.Count)];
            Console.WriteLine(item);
            return item;
        }
    }
}
