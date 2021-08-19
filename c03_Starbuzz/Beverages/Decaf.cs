namespace c03_Starbuzz{
    public class Decaf : Beverage{
        public override string description { 
            get { return "Decaf"; }
        }

        public override double cost()
        {
            return 1.05;
        }
    }
}