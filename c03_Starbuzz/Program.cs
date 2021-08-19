using System;

namespace c03_Starbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // wrap it up
            Beverage coffee = new Espresso();
            coffee = new Mocha(coffee);
            coffee = new SteamedMilk(coffee);

            Console.WriteLine(coffee.description);
            Console.WriteLine(coffee.cost());
        }
    }
}
