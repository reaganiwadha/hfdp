using System;
using SimUDuck.Ducks.Abilities.Behaviors;

namespace SimUDuck.Ducks
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            this.flyBehavior = new FlyWithWings();
        }
        
        public override void Display()
        {
            Console.WriteLine("I am a Mallard Duck");
        }
    }
}