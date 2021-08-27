using System;

namespace c04_PizzaStore
{
    class PizzaTestDrive
    {
        static void Main(string[] args)
        {
            var nyPizzaStore = new NYPizzaStore();
            var pizza = nyPizzaStore.OrderPizza("cheese");

            var chicagoPizzaStore = new ChicagoPizzaStore();
            var chicagoPizza = chicagoPizzaStore.OrderPizza("cheese");
        }
    }
}
