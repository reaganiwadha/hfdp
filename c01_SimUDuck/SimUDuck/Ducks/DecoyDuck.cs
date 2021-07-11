using SimUDuck.Ducks.Abilities.Behaviors;

namespace SimUDuck.Ducks
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            quackBehavior = new MuteQuack();
        }
    }
}