using System.Collections.Generic;

namespace c09_DinerPancakeCafe
{
    public class ListMenuIterator : IIterator<MenuItem>
    {
        private readonly List<MenuItem> _menuItems;
        private int _position;

        public ListMenuIterator(List<MenuItem> menuItems)
        {
            _menuItems = menuItems;
        }

        public bool HasNext()
            => _position < _menuItems.Count && _menuItems[_position] != null;

        public MenuItem Next()
        {
            var item = _menuItems[_position];
            _position++;
            return item;
        }
    }
}