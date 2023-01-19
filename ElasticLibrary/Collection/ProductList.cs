using System.Collections.Generic;
using ElasticLibrary.Models;

namespace ElasticLibrary.Collection
{
    public static class ProductList
    {
        public static IList<Products> ProductSpecifications { get; } = new List<Products>()
        {
            new Products(id: 1, name: "Dell Xps", quantity: 30, price: 1500, category: "Laptop", orderCount: 1000),
            new Products(id: 2, name: "Ergonomic Chair", quantity: 400, price: 200, category: "Chairs",
                orderCount: 4000),
            new Products(id: 3, name: "Table", quantity: 500, price: 250, category: "Tables", orderCount: 3000),
        };
    }
}