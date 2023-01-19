using System;
using ElasticLibrary.Collection;

namespace ElasticLibrary
{
    public class PrintProducts
    {
        public static void ListAllProducts()
        {
            foreach (var product in ProductList.ProductSpecifications)
            {
                Console.WriteLine($"{product.Id}, {product.Name}, {product.Quantity}, " +
                                  $"{product.Price}, {product.Category}, {product.OrderCount}");
                //This is a place holder
                Console.ReadLine();
            }
        }

        public static void ListByProperties()
        {
            
        }
    }
}
