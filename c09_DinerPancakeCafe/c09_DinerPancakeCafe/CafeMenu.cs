using System.Collections.Generic;
using System.Linq;

namespace c09_DinerPancakeCafe
{
    public class CafeMenu : IMenu
    {
        private readonly Dictionary<string, MenuItem> _menuItems = new Dictionary<string, MenuItem>();

        public CafeMenu()
        {
            AddItem("Veggie burger", "cool veggie burger", true, 3.99);
            AddItem("Soup of the day", "soup", false, 3.69);
            AddItem("Burrito", "a large burrito", true, 4.29);
        }
        
        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            _menuItems.Add(name, new MenuItem(name, description, vegetarian, price));
        }

        public IIterator<MenuItem> CreateIterator()
        {
            return new ListMenuIterator(_menuItems.Values.ToList());
        }
    }
}