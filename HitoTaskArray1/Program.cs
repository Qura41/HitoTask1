namespace HitoTaskArray1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MenuManager menu = new MenuManager();
            
            menu.DisplayMenu();
            
            Console.ReadKey();
        }
    }
}