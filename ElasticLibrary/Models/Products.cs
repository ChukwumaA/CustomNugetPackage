

namespace ElasticLibrary.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public int OrderCount { get; set; }
        
        public Products(int id, string name, int quantity, double price, string category, int orderCount)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
            Price = price;
            Category = category;
            OrderCount = orderCount;
        }

       
    }
    
    
    
}