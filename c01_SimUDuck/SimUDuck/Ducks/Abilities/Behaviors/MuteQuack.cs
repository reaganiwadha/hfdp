using System;

namespace SimUDuck.Ducks.Abilities.Behaviors
{
    public class MuteQuack : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Shhhhh");
        }
    }
}