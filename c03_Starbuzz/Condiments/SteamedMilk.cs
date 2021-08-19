namespace c03_Starbuzz{
    public class SteamedMilk : CondimentDecorator
    {
        public SteamedMilk(Beverage _beverage){
            beverage = _beverage;
        }

        public override string description { 
            get { return $"{beverage.description}, Steamed Milk"; }
        }

        public override double cost()
        {
            return beverage.cost() + .20;
        }
    }
}