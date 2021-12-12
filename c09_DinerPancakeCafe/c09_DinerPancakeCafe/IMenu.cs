namespace c09_DinerPancakeCafe
{
    public interface IMenu
    {
        public void AddItem(string name, string description, bool vegetarian, double price);
    }
}