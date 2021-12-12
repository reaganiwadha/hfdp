using System;

namespace c09_DinerPancakeCafe
{
    public class Waitress
    {
        private readonly PancakeMenu _pancakeMenu;
        private readonly DinerMenu _dinerMenu;

        public Waitress(PancakeMenu pancakeMenu, DinerMenu dinerMenu)
        {
            _pancakeMenu = pancakeMenu;
            _dinerMenu = dinerMenu;
        }

        public void PrintFullMenu()
        {
            var pancakeIterator = _pancakeMenu.CreateIterator();
            PrintMenu(pancakeIterator);

            var dinerIterator = _dinerMenu.CreateIterator();
            PrintMenu(dinerIterator);
        }

        private static void PrintMenu(IIterator<MenuItem> menuIterator)
        {
            while (menuIterator.HasNext())
            {
                var menuItem = menuIterator.Next();
                Console.WriteLine($"{menuItem.Name} -- {menuItem.Price} -- {menuItem.Description}");
            }
        }
    }
}