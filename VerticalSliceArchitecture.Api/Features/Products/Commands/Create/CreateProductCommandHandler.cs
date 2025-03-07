using AutoMapper;
using MediatR;
using Shared.Responses;
using VerticalSliceArchitecture.Api.Features.Products.Dtos;
using VerticalSliceArchitecture.Api.Features.Products.Interfaces;
using VerticalSliceArchitecture.Api.Persistence;

namespace VerticalSliceArchitecture.Api.Features.Products.Commands.Create;

public class CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper, IUnitOfWork unitOfWork)
    : IRequestHandler<CreateProductCommand, ServiceResult<ProductResponse>>
{
    public async Task<ServiceResult<ProductResponse>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = mapper.Map<Product>(request);
        await productRepository.AddAsync(product);
        await unitOfWork.SaveChangesAsync();

        var productResponse = mapper.Map<ProductResponse>(product);
        return ServiceResult<ProductResponse>.SuccessAsCreated(productResponse, "Product created.", $"api/products/{product.Id}");
    }
}