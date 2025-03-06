using AutoMapper;
using MediatR;
using Shared.Responses;
using VerticalSliceArchitecture.Api.Features.Categories.Dtos;
using VerticalSliceArchitecture.Api.Features.Categories.Interfaces;
using VerticalSliceArchitecture.Api.Persistence;

namespace VerticalSliceArchitecture.Api.Features.Categories.Commands.Create;

public class CreateCategoryHandler(ICategoryRepository categoryRepository, IMapper mapper, IUnitOfWork unitOfWork)
    : IRequestHandler<CreateCategoryCommand, ServiceResult<CategoryResponse>>
{
    public async Task<ServiceResult<CategoryResponse>> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        var category = mapper.Map<Category>(request);
        await categoryRepository.AddAsync(category);
        await unitOfWork.SaveChangesAsync();

        var categoryResponse = mapper.Map<CategoryResponse>(category);
        return ServiceResult<CategoryResponse>.SuccessAsCreated(categoryResponse, "Category created.", $"api/categories/{category.Id}");
    }
}
