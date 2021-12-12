namespace c09_DinerPancakeCafe
{
    class Program
    {
        static void Main(string[] args)
        {
            var pancakeMenu = new PancakeMenu();
            var dinerMenu = new DinerMenu();
            var waitress = new Waitress(pancakeMenu, dinerMenu);
            
            waitress.PrintFullMenu();
        }
    }
}
