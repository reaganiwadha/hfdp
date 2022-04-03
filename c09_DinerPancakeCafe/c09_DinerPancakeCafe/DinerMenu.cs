using System.Collections;
using System.Collections.Generic;

namespace c09_DinerPancakeCafe
{
    public class DinerMenu : IMenu
    {
        private const int MaxItems = 6;
        private readonly List<MenuItem> _menuItems = new(MaxItems);

        private int _position = 0;

        public DinerMenu()
        {
            AddItem("Vegetarian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99);
            AddItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99);
            AddItem("SOTD", "Soup of the day", false, 2.99);
            AddItem("hotDOG", "A hot dog with cheessseee", false, 3.29);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            var item = new MenuItem(name, description, vegetarian, price);
            _menuItems.Add(item);
        }

        public IIterator<MenuItem> CreateIterator() => new ListMenuIterator(_menuItems);
    }
}