using BaseWebApi.Models;

namespace BaseWebApi.Helper
{
    public static class ProductHelper
    {
        // In a real application this might access a database
        public static IEnumerable<Product> GetSampleProducts()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 999.99m },
                new Product { Id = 2, Name = "Smartphone", Price = 699.50m },
                new Product { Id = 3, Name = "Headphones", Price = 199.99m }
            };
        }
    }
}
