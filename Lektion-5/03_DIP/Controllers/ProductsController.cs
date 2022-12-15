using _03_DIP.Contexts;
using _03_DIP.Handlers;
using _03_DIP.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _03_DIP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductHandler _productHandler;

        public ProductsController(IProductHandler productHandler)
        {
            _productHandler = productHandler;
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductRequest req)
        {
            await _productHandler.CreateAsync(req);
            return Created("", null);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _productHandler.GetAllAsync();
            return new OkObjectResult(products);
        }
    }
}
