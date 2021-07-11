using System;
using SimUDuck.Ducks.Abilities.Behaviors;

namespace SimUDuck.Ducks
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            quackBehavior = new NormalQuack();
        }
        
        public override void Display()
        {
            Console.WriteLine("I am a Redhead Duck");
        }
    }
}