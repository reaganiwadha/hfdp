using System;
using SimUDuck.Ducks.Behaviors;

namespace SimUDuck.Ducks
{
    public class RubberDuck : Duck, IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Quack quack im a quacky rubber duck");
        }
    }
}