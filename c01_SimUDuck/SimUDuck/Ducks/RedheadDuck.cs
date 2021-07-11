using System;
using SimUDuck.Ducks.Behaviors;

namespace SimUDuck.Ducks
{
    public class RedheadDuck : Duck, IFlyable, IQuackable
    {
        public void Fly()
        {
            Console.WriteLine("Wooo im flyingggg");
        }

        public void Quack()
        {
            Console.WriteLine("Woo im quacking quack quackkkkkk");
        }

        public override void Display()
        {
            Console.WriteLine("I am a Redhead Duck");
        }
    }
}