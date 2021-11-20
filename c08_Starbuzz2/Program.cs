using System;

namespace c08_Starbuzz2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Starbuzz v2");

            var tea = new Tea();
            tea.PrepareRecipe();

            var teaNoCondiments = new Tea(false);
            teaNoCondiments.PrepareRecipe();
        }
    }
}
