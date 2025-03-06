using MediatR;
using Shared.Responses;
using VerticalSliceArchitecture.Api.Features.Categories.Dtos;

namespace VerticalSliceArchitecture.Api.Features.Categories.Commands.Create;

public record CreateCategoryCommand(string Name) : IRequest<ServiceResult<CategoryResponse>>;