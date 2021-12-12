namespace c09_DinerPancakeCafe
{
    public class MenuItem
    {
        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            Name = name;
            Description = description;
            Vegetarian = vegetarian;
            Price = price;
        }
        
        public string Name { get; init; }
        public string Description { get; init; }
        public bool Vegetarian { get; init; }
        public double Price { get; init; }
    }
}