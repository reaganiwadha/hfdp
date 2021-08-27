using c04_PizzaStore.Pizzas;

namespace c04_PizzaStore{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string pizzaType)
        {
            if (pizzaType == "cheese") {
                return new NYStyleCheesePizza();
            }
            return null;
        }
    }
}