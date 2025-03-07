using AutoMapper;
using VerticalSliceArchitecture.Api.Features.Products.Commands.Create;
using VerticalSliceArchitecture.Api.Features.Products.Dtos;

namespace VerticalSliceArchitecture.Api.Features.Products.Profiles;

public class ProductMappingProfile : Profile
{
    public ProductMappingProfile()
    {
        CreateMap<CreateProductCommand, Product>();
        CreateMap<Product, ProductResponse>();
    }
}
