using _03_RESTFUL_WEBAPI_ProductCatalog.Models;
using _03_RESTFUL_WEBAPI_ProductCatalog.Models.Entities;
using AutoMapper;

namespace _03_RESTFUL_WEBAPI_ProductCatalog.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<ProductEntity, ProductResponse>().ReverseMap();
            CreateMap<Product, ProductEntity>().ReverseMap();
        }
    }
}
