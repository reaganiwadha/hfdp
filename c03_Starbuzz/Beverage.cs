namespace c03_Starbuzz{
    public abstract class Beverage{
        public virtual string description { 
            get { return "Unknown Coffee"; }
        }

        public abstract double cost();
    }
}