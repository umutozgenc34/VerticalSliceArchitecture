using AutoMapper;
using VerticalSliceArchitecture.Api.Features.Categories.Commands.Create;
using VerticalSliceArchitecture.Api.Features.Categories.Dtos;

namespace VerticalSliceArchitecture.Api.Features.Categories.Profiles;

public class CategoryMappingProfile : Profile
{
    public CategoryMappingProfile()
    {
        CreateMap<CreateCategoryCommand, Category>();
        CreateMap<Category, CategoryResponse>();
    }
}
