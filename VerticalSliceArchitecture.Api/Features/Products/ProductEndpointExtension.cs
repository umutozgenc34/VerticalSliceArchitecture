using VerticalSliceArchitecture.Api.Features.Products.Commands.Create;
using VerticalSliceArchitecture.Api.Features.Products.Queries.GetAll;

namespace VerticalSliceArchitecture.Api.Features.Products;

public static class ProductEndpointExtension
{
    public static void AddProductGroupEndpointExtension(this WebApplication app)
    {
        var group = app.MapGroup("api/products").WithTags("Products");
        group.CreateProductGroupItemEndpoint();
        group.GetAllProductsGroupItemEndpoint();
    }
}
