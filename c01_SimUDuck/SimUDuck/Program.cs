using SimUDuck.Ducks;

namespace SimUDuck
{
    class SimUDuck
    {
        static void Main(string[] args)
        {
            var duck = new Duck();
            duck.Display();

            var redheadDuck = new RedheadDuck();
            redheadDuck.Quack();

            var mallardDuck = new MallardDuck();
            mallardDuck.Fly();
        }
    }
}