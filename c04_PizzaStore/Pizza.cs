using System;

namespace c04_PizzaStore{
    public abstract class Pizza{
        public abstract string Name {get;}

        public virtual void Prepare(){
            Console.WriteLine($"Preparing {Name} Pizza");
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