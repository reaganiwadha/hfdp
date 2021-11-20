using System;

namespace c08_Starbuzz2
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();

            // Template pattern hooks
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        public abstract void Brew();

        public abstract void AddCondiments();

        public virtual void BoilWater()
        {
            Console.WriteLine("Boiling water...");
        }

        public virtual void PourInCup()
        {
            Console.WriteLine("Pouring drink in cup...");
        }

        protected virtual bool CustomerWantsCondiments() => true;
    }
}