namespace Warehouse
{
    internal class Program
    {

       public const string FILE_NAME = "C:\\Warehousefiles\\Importfiles.xlsx"; // stała dla całego programu wiec moze byc na górze z słowkiem public
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to warehouse app!");
            Console.WriteLine("Please let me know what you want to do:");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Remove Iteam");
            Console.WriteLine("3. Check Item");
            Console.WriteLine("Press 1, 2 or 3 ...");

            string choice = Console.ReadLine();

            Console.WriteLine($"You have choice option number: {choice}");


          //  const string FILE_NAME = "C:\\Warehousefiles\\Importfiles.xlsx";

            int choosenOption = 0; //deklaracja i inicjalizacja

            Int32.TryParse(choice, out choosenOption)
                ;

            Console.WriteLine("Please choose another option ...");

            choice = Console.ReadLine();


        }
    }
}