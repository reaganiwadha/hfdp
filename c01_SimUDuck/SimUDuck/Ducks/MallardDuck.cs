using System;
using SimUDuck.Ducks.Behaviors;

namespace SimUDuck.Ducks
{
    public class MallardDuck : Duck, IFlyable, IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Quack quack im a mallard duck");
        }
        
        public void Fly()
        {
            Console.WriteLine("Im flying wooo");
        }

        public override void Display()
        {
            Console.WriteLine("I am a Mallard Duck");
        }
    }
}