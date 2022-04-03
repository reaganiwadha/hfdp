using System;

namespace c09_DinerPancakeCafe
{
    public class Waitress
    {
        private readonly PancakeMenu _pancakeMenu;
        private readonly DinerMenu _dinerMenu;
        private readonly CafeMenu _cafeMenu;

        public Waitress(PancakeMenu pancakeMenu, DinerMenu dinerMenu, CafeMenu cafeMenu)
        {
            _pancakeMenu = pancakeMenu;
            _dinerMenu = dinerMenu;
            _cafeMenu = cafeMenu;
        }

        public void PrintFullMenu()
        {
            var pancakeIterator = _pancakeMenu.CreateIterator();
            PrintMenu(pancakeIterator);

            var dinerIterator = _dinerMenu.CreateIterator();
            PrintMenu(dinerIterator);

            var cafeIterator = _cafeMenu.CreateIterator();
            PrintMenu(cafeIterator);
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