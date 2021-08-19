namespace c03_Starbuzz{
    public class HouseBlend : Beverage{
        public override string description { 
            get { return "House Blend Coffee"; }
        }

        public override double cost()
        {
            return .89;
        }
    }
}