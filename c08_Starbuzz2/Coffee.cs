using System;

namespace c08_Starbuzz2
{
    public class Coffee : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Brewing coffee");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk");
        }
    }
}