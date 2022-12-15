using _03_RESTFUL_WEBAPI_ProductCatalog.Contexts;
using _03_RESTFUL_WEBAPI_ProductCatalog.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace _03_RESTFUL_WEBAPI_ProductCatalog.Handlers
{
    public class GetProductsHandler : IGetProductsHandler
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public GetProductsHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductResponse>> Get()
        {
            var products = _mapper.Map<IEnumerable<ProductResponse>>(await _context.Products.ToListAsync());
            return products ?? null!;
        }
    }
}
