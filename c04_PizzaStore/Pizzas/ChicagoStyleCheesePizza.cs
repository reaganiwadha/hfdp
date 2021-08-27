using System.Collections.Generic;

namespace c04_PizzaStore.Pizzas{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public override string Name => "Chicago Style Deep Dish Cheezzzeey Pizza";

        public override string Dough => "Extra mega super duper thick dough";

        public override string Sauce => "Plum Tomato Sauce";

        public override List<string> Toppings => new List<string>() { "Mozzarela Cheese", "Pepperoni" };
    }
}