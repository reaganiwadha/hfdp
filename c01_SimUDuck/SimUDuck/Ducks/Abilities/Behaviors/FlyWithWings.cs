using System;

namespace SimUDuck.Ducks.Abilities.Behaviors
{
    public class FlyWithWings : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Im a duck that flies normally");
        }
    }
}