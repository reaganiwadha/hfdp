using System;

namespace c08_Starbuzz2
{
    public class Tea : CaffeineBeverage
    {
        private bool _withCondiments;
        
        public Tea(bool withCondiments = true)
        {
            _withCondiments = withCondiments;
        }
        
        public override void Brew()
        {
            Console.WriteLine("Brewing and steeping the tea");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding lemon");
        }

        protected override bool CustomerWantsCondiments() => _withCondiments;
    }
}