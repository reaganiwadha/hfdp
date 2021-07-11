using System;
using SimUDuck.Ducks.Abilities;

namespace SimUDuck.Ducks
{
    // Composition over inheritance
    public class Duck
    {
        protected IQuackable quackBehavior;
        protected IFlyable flyBehavior;
        
        public void Fly()
        {
            flyBehavior.Fly();
        }
        public void Quack()
        {
            quackBehavior.Quack();
        }
        
        public virtual void Display()
        {
            Console.WriteLine("I am a Duck");
        }
    }
}