using BaseWebApi.Helper;
using BaseWebApi.Models.Dto;
using BaseWebApi.Models;

namespace BaseWebApi.Services
{
    public interface IProductService
    {
        IEnumerable<ProductDto> GetProducts();
    }

    public class ProductService : IProductService
    {
        public IEnumerable<ProductDto> GetProducts()
        {
            // Retrieve products using helper and map to DTO
            var products = ProductHelper.GetSampleProducts();
            return products.Select(p => new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price
            });
        }
    }
}
