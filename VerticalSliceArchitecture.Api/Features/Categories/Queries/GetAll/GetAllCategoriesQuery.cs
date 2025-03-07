using MediatR;
using Shared.Responses;
using VerticalSliceArchitecture.Api.Features.Categories.Dtos;

namespace VerticalSliceArchitecture.Api.Features.Categories.Queries.GetAll;

public record GetAllCategoriesQuery() : IRequest<ServiceResult<List<CategoryResponse>>>;