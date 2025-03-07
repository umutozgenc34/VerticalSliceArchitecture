using MediatR;
using Shared.Responses;
using VerticalSliceArchitecture.Api.Features.Products.Dtos;

namespace VerticalSliceArchitecture.Api.Features.Products.Queries.GetAll;

public record GetAllProductsQuery : IRequest<ServiceResult<List<ProductResponse>>>;