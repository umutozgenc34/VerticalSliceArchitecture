using MediatR;
using Shared.Responses;
using VerticalSliceArchitecture.Api.Features.Products.Dtos;

namespace VerticalSliceArchitecture.Api.Features.Products.Commands.Create;

public record CreateProductCommand(string Name, decimal Price, int CategoryId) : IRequest<ServiceResult<ProductResponse>>;