using BaseWebApi.Models.Dto;
using BaseWebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BaseWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductDto>> GetProducts()
        {
            var products = _service.GetProducts();
            return Ok(products);
        }
    }
}
