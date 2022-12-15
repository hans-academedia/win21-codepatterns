using _03_ISP.Contexts;
using _03_ISP.Interfaces;
using _03_ISP.Models;
using _03_ISP.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _03_ISP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly NoSqlContext _noSqlContext;

        public ProductsController(DataContext context, NoSqlContext noSqlContext)
        {
            _context = context;
            _noSqlContext = noSqlContext;
        }

        [HttpPost]
        [Route("create/watch")]
        public async Task<IActionResult> CreateWatch(Watch item)
        {
            if (item.Category == "watches")
            {
                var product = new ProductCatalogEntity
                {
                    ProductInformation = item
                };
                _noSqlContext.Products.Add(product);
                await _noSqlContext.SaveChangesAsync();
            }

            return Created("", null);

        }






        [HttpGet]
        [Route("nosql")]
        public async Task<IActionResult> GetAllNoSql()
        {
            var items = await _noSqlContext.Products.ToListAsync();
            List<IProductItem> products = new List<IProductItem>();

            foreach (var item in items)
            {
                if (item.ProductInformation.Category == "watches")
                    products.Add((Watch)item.ProductInformation);

                if (item.ProductInformation.Category == "dresses")
                    products.Add((Dress)item.ProductInformation);
            }

            return new OkObjectResult(products);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var items = await _context.Products.Include(x => x.Category).ToListAsync();
            List<IProductItem> products = new List<IProductItem>(); 

            foreach(var item in items)
            {
                if (item.Category.CategoryName == "watches")
                    products.Add(new Watch
                    {
                        ArticleNumber = item.ArticleNumber,
                        WatherProof = true
                    });

                if (item.Category.CategoryName == "dress")
                    products.Add(new Dress
                    {
                        ArticleNumber = item.ArticleNumber,
                        Width = 36
                    });
            }

            return new OkObjectResult(products);
        }
    }
}
