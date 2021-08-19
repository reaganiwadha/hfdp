namespace c03_Starbuzz{
    public class Espresso : Beverage{
        public override string description { 
            get { return "Espresso"; }
        }

        public override double cost()
        {
            return 1.99;
        }
    }
}