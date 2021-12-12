using System.Collections.Generic;

namespace c09_DinerPancakeCafe
{
    public class PancakeMenu : IMenu
    {
        private readonly List<MenuItem> _menuItems = new();

        public PancakeMenu()
        {
            AddItem("Pancake Breakfast", "maple syruppppppp woooo", true, 2.99);
            AddItem("Regular Pancake Breakfast", "fried egg", false, 2.99);
            AddItem("Blueberry pancakes", "pan blue cake", true, 2.99);
            AddItem("Waffles", "wafff blue cake", true, 2.99);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            var item = new MenuItem(name, description, vegetarian, price);
            _menuItems.Add(item);
        }

        public List<MenuItem> GetMenuItems() => _menuItems;
        public IIterator<MenuItem> CreateIterator() => new PancakeMenuIterator(_menuItems);
    }
}