using _03_LSP.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _03_LSP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController_ : ControllerBase
    {
        private readonly ProductContext _productContext;

        public ProductsController_(ProductContext productContext)
        {
            _productContext = productContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return new OkObjectResult(await _productContext.Products.ToListAsync());
        }
    }
}
