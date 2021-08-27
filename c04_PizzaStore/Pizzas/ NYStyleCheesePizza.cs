using System.Collections.Generic;

namespace c04_PizzaStore.Pizzas{
    public class NYStyleCheesePizza : Pizza
    {
        public override string Name => "Cheese";

        public override string Dough => "A basic and soft dough";

        public override string Sauce => "Cheese sauce, obviously";

        public override List<string> Toppings => new List<string>() { "Reggiano Cheese?" };
    }
}