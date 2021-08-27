using System;
using System.Collections.Generic;

namespace c04_PizzaStore{
    public abstract class Pizza{
        public abstract string Name {get;}
        public abstract string Dough {get;}
        public abstract string Sauce {get;}
        public abstract List<String> Toppings {get;}

        public virtual void Prepare(){
            Console.WriteLine($"Preparing {Name} Pizza");
            Console.WriteLine($"Tossing {Dough} dough");
            Console.WriteLine($"Adding {Sauce} sauce...");
            Console.WriteLine($"Adding toppings: ");

            foreach(string topping in Toppings){
                Console.WriteLine(topping);
            }
        }

        public virtual void Bake(){
            Console.WriteLine($"Baking {Name} Pizza");
        }

        public virtual void Cut(){
            Console.WriteLine($"Cutting {Name} Pizza");
        }

        public virtual void Box(){
            Console.WriteLine($"Putting {Name} Pizza in a box!");
        }
    }
}