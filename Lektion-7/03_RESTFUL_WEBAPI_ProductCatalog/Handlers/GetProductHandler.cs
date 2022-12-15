using _03_RESTFUL_WEBAPI_ProductCatalog.Contexts;
using _03_RESTFUL_WEBAPI_ProductCatalog.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace _03_RESTFUL_WEBAPI_ProductCatalog.Handlers
{
    public class GetProductHandler : IGetProductHandler
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public GetProductHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ProductResponse> Get(Guid id)
        {
            var product = _mapper.Map<ProductResponse>(await _context.Products.FirstOrDefaultAsync(x => x.Id == id));
            return product ?? null!;
        }
    }
}
