using AutoMapper;
using MediatR;
using Shared.Responses;
using VerticalSliceArchitecture.Api.Features.Products.Dtos;
using VerticalSliceArchitecture.Api.Features.Products.Interfaces;

namespace VerticalSliceArchitecture.Api.Features.Products.Queries.GetAll;

public class GetAllProductsQueryHandler(IProductRepository productRepository, IMapper mapper)
    : IRequestHandler<GetAllProductsQuery, ServiceResult<List<ProductResponse>>>
{
    public async Task<ServiceResult<List<ProductResponse>>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
    {
        var products = await productRepository.GetAllAsync();
        var productResponses = mapper.Map<List<ProductResponse>>(products);

        return ServiceResult<List<ProductResponse>>.SuccessResult(productResponses, "Successfully.");
    }
}