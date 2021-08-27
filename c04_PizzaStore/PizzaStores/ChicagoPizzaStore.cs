using c04_PizzaStore.Pizzas;

namespace c04_PizzaStore{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string pizzaType)
        {
            if (pizzaType == "cheese") {
                return new ChicagoStyleCheesePizza();
            }
            return null;
        }
    }
}