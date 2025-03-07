using AutoMapper;
using MediatR;
using Shared.Responses;
using VerticalSliceArchitecture.Api.Features.Categories.Dtos;
using VerticalSliceArchitecture.Api.Features.Categories.Interfaces;

namespace VerticalSliceArchitecture.Api.Features.Categories.Queries.GetAll;

public class GetAllCategoriesQueryHandler(ICategoryRepository categoryRepository, IMapper mapper)
    : IRequestHandler<GetAllCategoriesQuery, ServiceResult<List<CategoryResponse>>>
{
    public async Task<ServiceResult<List<CategoryResponse>>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
    {
        var categories = await categoryRepository.GetAllAsync();
        var categoryResponses = mapper.Map<List<CategoryResponse>>(categories);

        return ServiceResult<List<CategoryResponse>>.SuccessResult(categoryResponses, "Successfully.");
    }
}