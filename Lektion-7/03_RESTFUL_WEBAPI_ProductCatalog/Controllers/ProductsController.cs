using _03_RESTFUL_WEBAPI_ProductCatalog.Handlers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _03_RESTFUL_WEBAPI_ProductCatalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IGetProductHandler _product;
        private readonly IGetProductsHandler _products;

        public ProductsController(IGetProductHandler product, IGetProductsHandler products)
        {
            _product = product;
            _products = products;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(Guid id)
        {
            var product = await _product.Get(id);
            return product != null ? Ok(product) : NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _products.Get();
            return products != null ? Ok(products) : BadRequest();
        }
    }
}
