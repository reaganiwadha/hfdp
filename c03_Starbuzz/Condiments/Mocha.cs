namespace c03_Starbuzz{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage _beverage){
            beverage = _beverage;
        }

        public override string description { 
            get { return $"{beverage.description}, Mocha"; }
        }

        public override double cost()
        {
            return beverage.cost() + .20;
        }
    }
}