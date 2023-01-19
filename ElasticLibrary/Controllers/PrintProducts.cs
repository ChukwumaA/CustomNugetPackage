using System;
using System.Collections.Generic;
using System.Dynamic;
using ElasticLibrary.Collection;

namespace ElasticLibrary.Controllers
{
    public static class PrintProducts
    {
        public static void ListAllProducts()
        {
            foreach (var product in ProductList.ProductSpecifications)
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Quantity: {product.Quantity} units ordered, " +
                                  $"Price: {product.Price} USD each, Category: {product.Category}, OrderCount: {product.OrderCount} units in stock");
            }
            Console.WriteLine();
            Application.ProductInfo();
        }

        public static void ListFirstPropertiesInList()
        {
            var items = new List<dynamic>();

            //putting the input into a list
            dynamic product = new ExpandoObject();
            Console.WriteLine("Enter the product Name, Quantity or OrderCount: ");
            var name = Console.ReadLine() ?? string.Empty;
            Console.WriteLine();
            items.Add(product);

            //searching for the input in the list[0]
            product.Name1 = name[0].ToString().ToUpper() + name.Substring(0);
            product.Name1 = ProductList.ProductSpecifications[0].Name;
            product.Quantity1 = ProductList.ProductSpecifications[0].Quantity;
            product.OrderCount1 = ProductList.ProductSpecifications[0].OrderCount;

            var firstItem = items[0];
            Console.WriteLine($"Name: {firstItem.Name1}");
            Console.WriteLine($"Quantity: {firstItem.Quantity1} units ordered");
            Console.WriteLine($"OrderCount: {firstItem.OrderCount1} units in stock");
            
            
            //searching for the input in the list[1]
            product.Name2 = name[1].ToString().ToUpper() + name.Substring(1);
            product.Name2 = ProductList.ProductSpecifications[1].Name;
            product.Quantity2 = ProductList.ProductSpecifications[1].Quantity;
            product.OrderCount2 = ProductList.ProductSpecifications[1].OrderCount;
            
            Console.WriteLine();
            
            Console.WriteLine($"Name: {product.Name2}");
            Console.WriteLine($"Quantity: {product.Quantity2} units ordered");
            Console.WriteLine($"OrderCount: {product.OrderCount2} units in stock");
            
            
            //searching for the input in the list[1]
            product.Name3 = name[2].ToString().ToUpper() + name.Substring(2);
            product.Name3 = ProductList.ProductSpecifications[2].Name;
            product.Quantity3 = ProductList.ProductSpecifications[2].Quantity;
            product.OrderCount3 = ProductList.ProductSpecifications[2].OrderCount;

            Console.WriteLine();
            
            Console.WriteLine($"Name: {product.Name3}");
            Console.WriteLine($"Quantity: {product.Quantity3} units ordered");
            Console.WriteLine($"OrderCount: {product.OrderCount3} units in stock");
            
            Application.ProductInfo();
        }

        
    }
}
