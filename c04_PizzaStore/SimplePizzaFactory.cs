using c04_PizzaStore.Pizzas;

namespace c04_PizzaStore{
    // I feel like factory classes should be static if it doesn't have that much stuff on it
    public static class SimplePizzaFactory{
        public static Pizza CreatePizza(string pizzaType){
            switch (pizzaType){
                case "cheese":
                return new CheesePizza();
                case "veggie":
                return new VeggiePizza();
            }
            
            return null;
        }
    }
}