namespace BaseWebApi.Models.Dto
{
    // Data transfer object for Product
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
