using AutoMapper;
using SkillMDFileDemo.Application.Features.Products.Queries.GetProducts;
using SkillMDFileDemo.Application.Features.Products.Queries.GetProductById;
using SkillMDFileDemo.Domain.Entities;

namespace SkillMDFileDemo.Application.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Product, GetProductsDTO>().ReverseMap();
            CreateMap<Product, GetProductByIdDTO>().ReverseMap();
        }
    }
}

