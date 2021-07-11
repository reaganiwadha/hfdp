using System;

namespace SimUDuck.Ducks.Abilities.Behaviors
{
    public class NormalQuack : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("This is a very normal quack");
        }
    }
}