namespace c04_PizzaStore{
    public abstract class PizzaStore{
        public abstract Pizza CreatePizza(string pizzaType);
        public Pizza OrderPizza(string pizzaType) {
            var pizza = this.CreatePizza(pizzaType);

            if(pizza == null) return null;

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}