using System;

namespace ElasticLibrary.Controllers
{
    public static class Application
    {
        public static void ProductInfo()
        {
            while (true)
            {
                Console.WriteLine("\nSelect an option from the menu:\n");
                Console.WriteLine("1. View all available product.\n2. View available product by name.");

                var input = Console.ReadLine() ?? string.Empty;
                Console.WriteLine();
                var option = int.Parse(input);
                switch (option)
                {
                    case 1:
                        PrintProducts.ListAllProducts();
                        break;
                    case 2:
                        PrintProducts.ListFirstPropertiesInList();
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        continue;
                }
                break;
            }
        }
    }
}