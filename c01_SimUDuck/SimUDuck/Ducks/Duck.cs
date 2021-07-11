using System;

namespace SimUDuck.Ducks
{
    // Composition over inheritance
    public class Duck
    {
        // public virtual void Quack()
        // {
        //     Console.WriteLine("Quack!");
        // }
        
        // public virtual void Fly()
        // {
        //     Console.WriteLine("I am free wooo");            
        // }

        public virtual void Display()
        {
            Console.WriteLine("I am a Duck");
        }
    }
}