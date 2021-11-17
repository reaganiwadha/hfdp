using System;

namespace c05_ChocolateFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var chocolateFactory = ChocolateFactory.GetInstance();
            chocolateFactory.Fill();
            chocolateFactory.Boil();
            
            Console.WriteLine($"Is chocolateFactory boiled? {chocolateFactory.IsBoiled()}");
            
            chocolateFactory.Drain();
        }
    }
}
