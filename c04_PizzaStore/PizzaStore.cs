using System;

namespace c04_PizzaStore
{
    class PizzaStore
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your kind of pizza : ");
            string pizzaType = Console.ReadLine();

            var pizza = SimplePizzaFactory.CreatePizza(pizzaType);
            if(pizza == null){
                Console.WriteLine("Sorry, we don't have that kind of pizza :(");
                return;
            }

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            Console.WriteLine("Thank you for your purchase!");
        }
    }
}
