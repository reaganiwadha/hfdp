namespace c09_DinerPancakeCafe
{
    static class Program
    {
        static void Main(string[] args)
        {
            var pancakeMenu = new PancakeMenu();
            var dinerMenu = new DinerMenu();
            var cafeMenu = new CafeMenu();
            var waitress = new Waitress(pancakeMenu, dinerMenu, cafeMenu);
            
            waitress.PrintFullMenu();
        }
    }
}
